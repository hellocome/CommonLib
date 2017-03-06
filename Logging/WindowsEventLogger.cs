using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace CommonLib.Logging
{
    public sealed class WindowsEventLogger
    {
        private const int MaxEventLogEntryLength = 30000;
        public static string Source { get; set; }


        private static void Log(string message, EventLogEntryType entryType, string source)
        {
            // Note: I got an error that the security log was inaccessible. To get around it, I ran the app as administrator
            //       just once, then I could run it from within VS.

            if (string.IsNullOrWhiteSpace(source))
            {
                source = GetSource();
            }

            string possiblyTruncatedMessage = EnsureLogMessageLimit(message);
            EventLog.WriteEntry(source, possiblyTruncatedMessage, entryType);

            // If we're running a console app, also write the message to the console window.
            if (Environment.UserInteractive)
            {
                Console.WriteLine(message);
            }
        }

        private static string GetSource()
        {
            // If the caller has explicitly set a source value, just use it.
            if (!string.IsNullOrWhiteSpace(Source)) { return Source; }

            try
            {
                var assembly = Assembly.GetEntryAssembly();

                // GetEntryAssembly() can return null when called in the context of a unit test project.
                // That can also happen when called from an app hosted in IIS, or even a windows service.

                if (assembly == null)
                {
                    assembly = Assembly.GetExecutingAssembly();
                }


                if (assembly == null)
                {
                    assembly = new StackTrace().GetFrames().Last().GetMethod().Module.Assembly;
                }

                if (assembly == null) { return "Unknown"; }

                return assembly.GetName().Name;
            }
            catch
            {
                return "Unknown";
            }
        }

        private static string EnsureLogMessageLimit(string logMessage)
        {
            if (logMessage.Length > MaxEventLogEntryLength)
            {
                string truncateWarningText = string.Format(CultureInfo.CurrentCulture, "... | Log Message Truncated [ Limit: {0} ]", MaxEventLogEntryLength);

                // Set the message to the max minus enough room to add the truncate warning.
                logMessage = logMessage.Substring(0, MaxEventLogEntryLength - truncateWarningText.Length);

                logMessage = string.Format(CultureInfo.CurrentCulture, "{0}{1}", logMessage, truncateWarningText);
            }

            return logMessage;
        }
    }
}
