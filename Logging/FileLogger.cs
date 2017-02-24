using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace CommonLib.Logging
{
    public class FileLogger : IDisposable
    {
        private string mFile = string.Empty;
        private StreamWriter sw = null;

        private Logger instance = null;
        public Logger SetInstance(string File)
        {
            mFile = File;

            instance = Logger.Instance;

            CreateSW(true);

            Logger.Instance.Init(WriteLog);

            return instance;
        }

        private void CreateSW(bool CreateNew)
        {
            try
            {
                if (sw == null || CreateNew)
                {
                    string di = new FileInfo(mFile).DirectoryName;
                    if (!Directory.Exists(di))
                    {
                        Directory.CreateDirectory(di);
                    }

                    sw = new StreamWriter(new FileStream(mFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
                    sw.AutoFlush = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void WriteLog(Object color, string log)
        {
            try
            {
                CreateSW(false);

                sw.WriteLine(log);
            }
            catch (Exception)
            {
                try
                {
                    CreateSW(true);
                    sw.WriteLine(log);
                    sw.Flush();
                }
                catch (Exception) 
                {
                }
            }
        }

        public void Dispose()
        {
            try
            {
                if (sw != null)
                {
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception) { }
        }
    }
}
