using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace CommonLib.UserInterface.WinForms
{
    public enum FixedMessageBoxButtons
    {
        OK = 0,
        OKCancel = 1,
        YesNo = 4,
    }
    
    public enum FixedMessageBoxIcon
    {
        None,
        Stop,
        Error,
        Question,
        Warning,
        Information,
        Exclamation
    }

    public partial class FixedMessageBox : FixedToolForm
    {
        private static FixedMessageBox mMessageBox = null;
        
        private FixedMessageBox()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void CustomMessageBox_Paint(object sender, PaintEventArgs e)
        {
            //Graphics mGraphics = e.Graphics;
            //Pen penBorder = new Pen(Color.FromArgb(96, 155, 173), 1);

            //Rectangle Area1 = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            //LinearGradientBrush LGB = new LinearGradientBrush(Area1, Color.FromArgb(96, 155, 173), Color.FromArgb(245, 251, 251), LinearGradientMode.Vertical);
            //mGraphics.FillRectangle(LGB, Area1);
            //mGraphics.DrawRectangle(penBorder, Area1);

            //ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.FromArgb(96, 155, 173), ButtonBorderStyle.Solid);

        }

        public static DialogResult Show(string text)
        {
            return Show(null, text, string.Empty, FixedMessageBoxButtons.OK, FixedMessageBoxIcon.None);
        }

        public static DialogResult Show(string text, string caption)
        {
            return Show(null, text, caption, FixedMessageBoxButtons.OK, FixedMessageBoxIcon.None);
        }

        public static DialogResult Show(string text, string caption, FixedMessageBoxButtons buttons, FixedMessageBoxIcon icon)
        {
            return Show(null, text, caption, buttons, icon);
        }

        public static DialogResult Show(string text, string caption, FixedMessageBoxButtons buttons)
        {
            return Show(null, text, caption, buttons, FixedMessageBoxIcon.Information);
        }

        public static DialogResult Show(Form owner, string text, string caption, FixedMessageBoxButtons buttons, FixedMessageBoxIcon icon)
        {
            mMessageBox = new FixedMessageBox();
            mMessageBox.lblMessage.Text = text;
            mMessageBox.DisplayText = caption;

            if (owner != null)
            {
                mMessageBox.Owner = owner;
                mMessageBox.StartPosition = FormStartPosition.CenterParent;
            }
            else
            {
                mMessageBox.StartPosition = FormStartPosition.CenterScreen;
            }

            switch(icon)
            {
                case FixedMessageBoxIcon.None:
                    mMessageBox.pbMBIcon.BackgroundImage = global::CommonLib.Properties.Resource.MBOK;
                    break;
                case FixedMessageBoxIcon.Information:
                    mMessageBox.pbMBIcon.BackgroundImage = global::CommonLib.Properties.Resource.MBInformation;
                    break;
                case FixedMessageBoxIcon.Error:
                    mMessageBox.pbMBIcon.BackgroundImage = global::CommonLib.Properties.Resource.MBError;
                    break;
                case FixedMessageBoxIcon.Question:
                    mMessageBox.pbMBIcon.BackgroundImage = global::CommonLib.Properties.Resource.MBQuestion;
                    break;
                case FixedMessageBoxIcon.Stop:
                    mMessageBox.pbMBIcon.BackgroundImage = global::CommonLib.Properties.Resource.MBStop;
                    break;
                case FixedMessageBoxIcon.Warning:
                    mMessageBox.pbMBIcon.BackgroundImage = global::CommonLib.Properties.Resource.MBWarning;
                    break;
                case FixedMessageBoxIcon.Exclamation:
                    mMessageBox.pbMBIcon.BackgroundImage = global::CommonLib.Properties.Resource.MBExclamation;
                    break;
            }


            switch(buttons)
            {
                case FixedMessageBoxButtons.OK:
                    mMessageBox.MBPanelOK.Visible = true;
                    mMessageBox.MBPanelOKCancel.Visible = false;
                    mMessageBox.MBPanelYesNO.Visible = false;
                    break;
                case FixedMessageBoxButtons.OKCancel:
                    mMessageBox.MBPanelOK.Visible = false;
                    mMessageBox.MBPanelOKCancel.Visible = true;
                    mMessageBox.MBPanelYesNO.Visible = false;
                    break;
                case FixedMessageBoxButtons.YesNo:
                    mMessageBox.MBPanelOK.Visible = false;
                    mMessageBox.MBPanelOKCancel.Visible = false;
                    mMessageBox.MBPanelYesNO.Visible = true;
                    break;
            }

            mMessageBox.ShowDialog();

            return mMessageBox.DialogResult;
        }

        private void btnYesNoYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnYesNoNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnOKCancelCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOKCancelYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
