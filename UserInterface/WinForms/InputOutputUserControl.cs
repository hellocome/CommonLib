using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonLib.UserInterface.WinForms;
using CommonLib.LibEncoding;

namespace CommonLib.UserInterface.WinForms
{
    public partial class InputOutputUserControl : UserControl
    {
        private List<InfoTextBox> inforTextBox = new List<InfoTextBox>();

        public InputOutputNum mInputOutputNum = InputOutputNum.Two;

        public InputOutputUserControl()
        {
            InitializeComponent();

            InitializeInputOutputControl();
        }

        protected void InitializeInputOutputControl(InputOutputNum inputOutputNum = InputOutputNum.Two)
        {
            this.mInputOutputNum = inputOutputNum;

            inforTextBox.Clear();

            inforTextBox.Add(RTBInputOutput1);
            inforTextBox.Add(RTBInputOutput2);
            inforTextBox.Add(RTBInputOutput3);
            inforTextBox.Add(RTBInputOutput4);

            if (this.mInputOutputNum == InputOutputNum.Two)
            {
                this.SplitContainerInputOuput.Panel1.Controls.Clear();
                this.SplitContainerInputOuput.Panel2.Controls.Clear();

                this.RTBInputOutput1.Dock = DockStyle.Fill;
                this.RTBInputOutput2.Dock = DockStyle.Fill;

                this.SplitContainerInputOuput.Panel1.Controls.Add(this.RTBInputOutput1);
                this.SplitContainerInputOuput.Panel2.Controls.Add(this.RTBInputOutput2);
            }
            else
            {
                this.SplitContainerInputOuput.Panel1.Controls.Clear();
                this.SplitContainerInputOuput.Panel2.Controls.Clear();

                this.RTBInputOutput1.Dock = DockStyle.Fill;
                this.RTBInputOutput2.Dock = DockStyle.Fill;
                this.RTBInputOutput3.Dock = DockStyle.Fill;
                this.RTBInputOutput4.Dock = DockStyle.Fill;

                this.splitContainerLeft.Panel1.Controls.Add(this.RTBInputOutput1);
                this.splitContainerLeft.Panel2.Controls.Add(this.RTBInputOutput3);

                this.splitContainerRight.Panel1.Controls.Add(this.RTBInputOutput2);
                this.splitContainerRight.Panel2.Controls.Add(this.RTBInputOutput4);

                this.SplitContainerInputOuput.Panel1.Controls.Add(this.splitContainerLeft);
                this.SplitContainerInputOuput.Panel2.Controls.Add(this.splitContainerRight);
            }
        }

        protected void SetTitle(int id, string title)
        {
            inforTextBox[IdToIndex(id)].Title = title;
        }

        protected void OutputString(int id, string str, string title = "")
        {
            inforTextBox[IdToIndex(id)].TextBox.Text = str;
            this.SetTitle(id, title);
        }

        protected void OutputError(string str, string title = "")
        {
            new InfoOutput().ShowError(str, title);
            //int outputID = 1;
            //if (mInputOutputNum == InputOutputNum.Two)
            //{
            //    outputID = 1;
            //}
            //else
            //{
            //    outputID = 3;
            //}

            //if (string.IsNullOrEmpty(title))
            //{
            //    this.SetTitle(outputID, "ERROR");
            //}
            //else
            //{
            //    this.SetTitle(outputID, title);
            //}

            //OutputString(outputID, str);
        }

        protected void OutputString(int id, byte[] bytes, string title = "")
        {
            try
            {
                inforTextBox[IdToIndex(id)].TextBox.Text = StaticEncoder.Bytes2String(bytes);
                this.SetTitle(id, title);
            }
            catch (Exception ex) { OutputError(ex); }
        }


        protected void OutputError(Exception exp, string title = "")
        {
            OutputError(exp.ToString(), title);
        }

        protected void OutputToBase64(int id, string str, string title = "")
        {
            try
            {
                inforTextBox[IdToIndex(id)].TextBox.Text = StaticEncoder.Base64Encode(str);
                this.SetTitle(id, string.Format("{0} [Base64]", title));
            }
            catch (Exception ex) { OutputError(ex); }
        }

        protected void OutputToBase64(int id, byte[] bytes, string title = "")
        {
            try
            {
                inforTextBox[IdToIndex(id)].TextBox.Text = StaticEncoder.Base64Encode(bytes);


                this.SetTitle(id, string.Format("{0} [Base64]", title));
            }
            catch (Exception ex)
            {
                OutputError(ex);
            }
        }

        protected void OutputHexString(int id, string str, string title = "")
        {
            try
            {
                inforTextBox[IdToIndex(id)].OutputFormattedHexString(str);
                this.SetTitle(id, string.Format("{0} [Hex String]", title));
            }
            catch (Exception ex) { OutputError(ex); }
        }

        protected void OutputHexStringFromBytes(int id, byte[] bytes, string title = "")
        {
            try
            {
                string str = StaticEncoder.Ascii2HexString(bytes);
                inforTextBox[IdToIndex(id)].OutputFormattedHexString(str);
                this.SetTitle(id, string.Format("{0} [Hex String]", title));
            }
            catch (Exception ex) { OutputError(ex); }
        }

        protected string GetInputOutputHexString(int id)
        {
            return inforTextBox[IdToIndex(id)].Text.RemoveWhitespace();
        }

        protected string GetInputOutputString(int id)
        {
            return inforTextBox[IdToIndex(id)].Text;
        }

        protected byte[] GetInputOutputInBytes(int id)
        {
            return StaticEncoder.String2Bytes(inforTextBox[IdToIndex(id)].Text);
        }

        protected byte[] GetInputOutputInBytesFromHex(int id)
        {
            try
            {
                return StaticEncoder.HexString2Ascii(GetInputOutputHexString(id));
            }
            catch (Exception ex) { OutputError(ex); return null; }
        }

        protected byte[] GetInputOutputBase64InBytes(int id)
        {
            return StaticEncoder.Base64DecodeToBytes(inforTextBox[IdToIndex(id)].Text);
        }

        protected string GetInputOutputBase64InString(int id)
        {
            return StaticEncoder.Base64Decode(inforTextBox[IdToIndex(id)].Text);
        }

        private int IdToIndex(int id)
        {
            if (id >= 1 && id <= 4)
            {
                return id - 1;
            }
            else
            {
                FixedMessageBox.Show("Invalid index: " + (id - 1), "Error", FixedMessageBoxButtons.OK, FixedMessageBoxIcon.Error);
                return 0;
            }
        }
    }

    public enum InputOutputNum
    {
        Two,
        Four
    }
}
