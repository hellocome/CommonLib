﻿using System;
using System.Linq;
using System.Text;

namespace CommonLib.LibEncoding
{
    public static class StaticEncoder
    {
        public static byte[] AsciiString2Bytes(string data)
        {
            try
            {
                return Enumerable.Range(0, data.Length)
                         .Where(x => x % 3 == 0)
                         .Select(x => Convert.ToByte(data.Substring(x, 3), 10))
                         .ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string Ascii2HexString(byte[] data)
        {
            try
            {
                string hexString = BitConverter.ToString(data);

                hexString = hexString.Replace("-", "");
                return hexString;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string Base64Encode(string data)
        {
            var btData = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(btData);
        }

        public static string Base64Encode(byte[] btData)
        {
            return Convert.ToBase64String(btData);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string Base64DecodeToHex(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Ascii2HexString(base64EncodedBytes);
        }

        public static string Base64Decode(byte[] base64EncodedBytes)
        {
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static byte[] Base64DecodeToBytes(string base64EncodedData)
        {
            return Convert.FromBase64String(base64EncodedData);
        }

        public static string BytesToAscii(byte[] data)
        {
            string result = "";

            for (int index = 0; index < data.Length; index++)
            {
                byte bt = data[index];
                result += bt.ToString("D3");
            }
            return result;
        }

        public static int BytesToInt(byte[] data)
        {
            int threeCount = 0;
            int nextDigit = 0;
            int returnValue = 0;

            foreach (byte bt in data)
            {
                nextDigit = 10 * nextDigit + (bt - 48);
                if (++threeCount == 3)
                {
                    returnValue = returnValue * 10 + (nextDigit - 48);
                    threeCount = 0;
                    nextDigit = 0;
                }
            }
            return returnValue;
        }

        public static byte[] HexString2Ascii(string data)
        {
            try
            {
                return Enumerable.Range(0, data.Length)
                         .Where(x => x % 2 == 0)
                         .Select(x => Convert.ToByte(data.Substring(x, 2), 16))
                         .ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static byte[] String2Bytes(string data)
        {
            try
            {
                return Encoding.ASCII.GetBytes(data);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string Bytes2String(byte[] data)
        {
            try
            {
                return Encoding.ASCII.GetString(data);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
