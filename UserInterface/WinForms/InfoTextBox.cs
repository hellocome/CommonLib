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
    public partial class InfoTextBox : UserControl
    {
        public InfoTextBox()
        {
            InitializeComponent();

            this.rtbText.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            LabelBottom.Text = string.Format("Length: {0}", this.rtbText.Text.Length);
        }

        public RichTextBox TextBox
        {
            get
            {
                return this.rtbText;
            }
        }

        public string Title
        {
            get
            {
                return this.LabelTitle.Text;
            }

            set
            {
                this.LabelTitle.Text = value;
            }
        }

        public new string Text
        {
            get
            {
                return this.rtbText.Text;
            }

            set
            {
                this.rtbText.Text = value;
            }
        }

        public void OutputFormattedHexString(string hex)
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

                this.rtbText.Text = sb.ToString();

                LabelBottom.Text = string.Format("{0} {1} bytes", LabelBottom.Text, hex.Length / 2);
            }
            catch (Exception ex)
            {
                this.rtbText.Text = ex.Message;
            }
        }
    }
}
