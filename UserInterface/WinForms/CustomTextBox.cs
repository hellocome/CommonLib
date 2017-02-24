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
    public partial class CustomTextBox : UserControl
    {
        [Browsable(true)]
        public string DisplayText
        {
            get { return InnerTextBox.Text; }
            set { InnerTextBox.Text = value; }
        }

        [Browsable(true)]
        public Font DisplayFont
        {
            get { return InnerTextBox.Font; }
            set { InnerTextBox.Font = value; }
        }

        public TextBox DisplayTextBox
        {
            get { return InnerTextBox; }
        }

        [Browsable(true)]
        public Color DisplayForeColor
        {
            get { return InnerTextBox.ForeColor; }
            set { InnerTextBox.ForeColor = value; }
        }

        private Color mBorderColor = Color.Gray;
        [Browsable(true)]
        public Color BorderColor
        {
            get { return mBorderColor; }
            set { mBorderColor = value; }
        }

        public CustomTextBox()
        {
            InitializeComponent();

            TextBoxRelocation();
        }

    

        private void CustomTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void TextBoxRelocation()
        {
            InnerTextBox.Width = this.PanelTextBox.Width - 10;
            //this.Height = InnerTextBox.Height + 10;

            InnerTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            InnerTextBox.Left = (this.PanelTextBox.Width - InnerTextBox.Width) * 2 / 3;
            InnerTextBox.Top = (this.PanelTextBox.Height - InnerTextBox.Height) / 2;// * 2 / 3;
        }

        private void UserControl_Resize(object sender, EventArgs e)
        {
            TextBoxRelocation();
        }

        private void UserControl_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, mBorderColor, ButtonBorderStyle.Solid);
        }


        [Browsable(true)]
        public Image UserIcon
        {
            get
            {
                return this.PBIcon.BackgroundImage;
            }

            set
            {
                this.PBIcon.BackgroundImage = value;
            }
        }


        [Browsable(true)]
        public char PasswordChar
        {
            get
            {
                return this.InnerTextBox.PasswordChar;
            }

            set
            {
                this.InnerTextBox.PasswordChar = value;
            }
        }

        [Browsable(true)]
        public int MaxLength
        {
            get
            {
                return this.InnerTextBox.MaxLength;
            }

            set
            {
                this.InnerTextBox.MaxLength = value;
            }
        }


        [Browsable(true)]
        public Color ControlBackColor
        {
            get
            {
                return this.BackColor;
            }

            set
            {
                this.BackColor = value;
                this.InnerTextBox.BackColor = value;
                this.PanelTextBox.BackColor = value;
                this.PBIcon.BackColor = value;
            }
        }
    }
}
