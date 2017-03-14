using System;
using System.Collections.Generic;
using Microsoft.Win32;
using CommonLib.Logging;

namespace CommonLib.Utilities
{
    public class RegistryWrapper
    {
        public static int GetValueInt(RegistryKey root, string subKey, string keyName, int defaultValue, int min, int max)
        {
            int valueInt = GetValue<int>(root, subKey, keyName, defaultValue);

            if (valueInt < min || valueInt > max)
            {
                return defaultValue;
            }

            return valueInt;
        }

        public static List<string> EnumerateRegName(RegistryKey root, string subKey)
        {
            List<string> regNames = new List<string>();

            try
            {

                using (RegistryKey rkPackage = root.OpenSubKey(subKey))
                {
                    string[] subKeyNames = rkPackage.GetValueNames();
                    if (subKeyNames != null)
                    {
                        regNames.AddRange(subKeyNames);
                    }
                }
            }
            catch (Exception ex)
            {
                //Logger.Instance.Error("RegistryWrapper: ", ex);
            }

            return regNames;
        }

        public static T GetValue<T>(RegistryKey root, string subKey, string keyName, T defaultValue = default(T))
        {
            try
            {
                RegistryKey key = root.OpenSubKey(subKey, false);
                object v = key.GetValue(keyName);
                return v != null ? (T)v : defaultValue;
            }
            catch (Exception ex)
            {
                //Logger.Instance.Error("RegistryWrapper: ", ex);

                return defaultValue;
            }
        }

        public static bool SetValue<T>(RegistryKey root, string subKey, string keyName, T value)
        {
            try
            {
                RegistryKey key = root.CreateSubKey(subKey, RegistryKeyPermissionCheck.Default);
                key = root.OpenSubKey(subKey, true);

                if (key == null || value == null)
                    return false;

                key.SetValue(keyName, value);

                return true;
            }
            catch (Exception ex)
            {
                Logger.Instance.Error("RegistryWrapper: ", ex);
                return false;
            }
        }

        public static void DeleteKey(RegistryKey root, string keyPath, bool deleteTree = true)
        {
            RegistryKey key = root.OpenSubKey(keyPath, RegistryKeyPermissionCheck.ReadWriteSubTree);

            if (key != null)
            {
                if (deleteTree)
                    key.DeleteSubKeyTree("");
                else
                    key.DeleteSubKey("");
            }
        }

        public static void DeleteKey(RegistryKey key, bool deleteTree = true)
        {
            if (deleteTree)
                key.DeleteSubKeyTree("");
            else
                key.DeleteSubKey("");
        }

        public static void DeleteValue(RegistryKey key, string keyName) { key.DeleteValue(keyName); }

        public static RegistryKey GetKey(RegistryHive hive, string subKeyName, string computer = "")
        {
            RegistryKey registryKey = string.IsNullOrWhiteSpace(computer)
                                                  ? RegistryKey.OpenBaseKey(hive, View)
                                                  : RegistryKey.OpenRemoteBaseKey(hive, computer, View);
            if (!string.IsNullOrWhiteSpace(subKeyName))
                registryKey = registryKey.OpenSubKey(subKeyName);

            return registryKey;
        }

        protected static RegistryView View
        {
            get { return Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32; }
        }

        public static bool IsKeyExisting(RegistryKey hiveKey, string strSubKey, string valueName)
        {
            try
            {
                List<string> names = EnumerateRegName(hiveKey, strSubKey);
                foreach(string name in names)
                {
                    if(name.Equals(valueName, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {

            }

            return false;
        }

        public static bool IsKeyExisting(RegistryKey hiveKey, string strSubKey)
        {
            RegistryKey subKey = null;

            try
            {
                subKey = hiveKey.OpenSubKey(strSubKey);
                if (subKey == null)
                {
                    return false;
                }

                subKey.Close();
                hiveKey.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}