using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLib.UserInterface.WinForms
{
    public partial class TextPanel : UserControl
    {
        public bool IsBase64
        {
            get
            {
                return this.CBBase64.Checked;
            }
        }
        public enum TextPanelView
        {
            Hex,
            Plain
        }
        
        public new string Text
        {
            get
            {
                return this.rtbPlain.Text;
            }
        }

        private TextPanelView mTextView = TextPanelView.Hex;
        public TextPanelView TextView
        {
            get
            {
                return mTextView;
            }

            set
            {
                mTextView = value;
                OutputFormat(mBytes, mTextView);
            }
        }
        public TextPanel()
        {
            InitializeComponent();
            this.rtbPlain.TextChanged += Rtb_TextChanged;
        }

        private void Rtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.LabelInputInformation.Text = string.Format("Length: " + this.rtbPlain.Text.Length);

                if (this.CBBase64.Checked)
                {
                    mBytes = Base64DecodeToBytes(this.rtbPlain.Text);
                }
                else
                {
                    mBytes = String2Bytes(this.rtbPlain.Text);
                }

                OutputFormat(mBytes, mTextView);
            }
            catch (Exception) { }
        }

        private byte[] mBytes = null;

        public byte[] ByteData
        {
            get
            {
                return mBytes;
            }
        }

        public void SetContent(string str, bool base64)
        {
            try
            {
                this.rtbPlain.Text = str;
                this.CBBase64.Checked = base64; 
            }
            catch (Exception ex)
            {
                this.rtbPlain.Text = ex.ToString();
            }
        }

        private void OutputFormat(byte[] bytes, TextPanelView format)
        {
            try
            {
                switch (format)
                {
                    case TextPanel.TextPanelView.Hex:
                        if (mBytes != null)
                        {
                            OutputHexString(Ascii2HexString(mBytes));
                        }

                        break;
                    case TextPanel.TextPanelView.Plain:
                        if (mBytes != null)
                        {
                            this.rtbFormat.Text = Bytes2String(mBytes);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.rtbFormat.Text = ex.Message;
            }
        }

        private void OutputHexString(string hex)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hex.Length; i = i + 2)
                {
                    if (i > 0)
                    {
                        if (i % 32 == 0)
                        {
                            sb.Append("\r\n");
                        }
                        else if (i % 16 == 0)
                        {
                            sb.Append("  ");
                        }
                    }

                    sb.Append(string.Format("{0}{1} ", hex[i], hex[i + 1]));
                }

                this.rtbFormat.Text = sb.ToString();
            }
            catch (Exception) { }
        }
        
        private void btnHEX_Click(object sender, EventArgs e)
        {
            TextView = TextPanelView.Hex;
        }

        private void btnPLAIN_Click(object sender, EventArgs e)
        {
            TextView = TextPanelView.Plain;
        }


        #region Converter
        private static byte[] AsciiString2Bytes(string data)
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

        private static string Ascii2HexString(byte[] data)
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

        private static string Base64Encode(string data)
        {
            var btData = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(btData);
        }

        private static string Base64Encode(byte[] btData)
        {
            return Convert.ToBase64String(btData);
        }

        private static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private static string Base64DecodeToHex(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Ascii2HexString(base64EncodedBytes);
        }

        private static string Base64Decode(byte[] base64EncodedBytes)
        {
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private static byte[] Base64DecodeToBytes(string base64EncodedData)
        {
            return Convert.FromBase64String(base64EncodedData);
        }

        private static string BytesToAscii(byte[] data)
        {
            string result = "";

            for (int index = 0; index < data.Length; index++)
            {
                byte bt = data[index];
                result += bt.ToString("D3");
            }
            return result;
        }

        private static int BytesToInt(byte[] data)
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

        private static byte[] HexString2Ascii(string data)
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

        private static byte[] String2Bytes(string data)
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

        private static string Bytes2String(byte[] data)
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
        #endregion

    }
}
