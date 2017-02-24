using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CommonLib.UserInterface.WinForms
{
    public partial class NoBorderMainForm : Form
    {
        protected bool CloseAllAfterClick = false;
        public NoBorderMainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ControlBorder.RemoveBorder(this.Controls);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.WSMinMaxClose.ButtonClose.Click += ButtonClose_Click;
            this.WSMinMaxClose.ButtonMinimize.Click += ButtonMinimize_Click;
            this.WSMinMaxClose.ButtonMaximum.Click += ButtonMaximum_Click;

            this.panelHeader.MouseDoubleClick += PanelHeader_MouseDoubleClick;
            this.SizeChanged += NoBorderMainForm_SizeChanged;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


            //this.StartPosition = FormStartPosition.Manual;
            //this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            //this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
 
        }

        protected override void OnShown(EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            base.OnShown(e);
        }

        private Color mBorderColor = Color.FromArgb(147, 147, 147);

        [Browsable(true)]
        public Color BorderColor
        {
            get
            {
                return mBorderColor;
            }
            set
            {
                mBorderColor = value;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, new Rectangle(0, 0, this.Width, this.Height), mBorderColor, ButtonBorderStyle.Solid);
        }


        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }
            try
            {
                base.WndProc(ref m);
            }
            catch (Exception) { }
        }
        //***********************************************************
        //***********************************************************
        //This gives us the ability to drag the borderless form to a new location
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void YOURCONTROL_MouseDown(object sender, MouseEventArgs e)
        {
            //ctrl-leftclick anywhere on the control to drag the form to a new location 
            if (e.Button == MouseButtons.Left && Control.ModifierKeys == Keys.Control)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        private void PanelHeader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void NoBorderMainForm_SizeChanged(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WSMinMaxClose.ShowIconMax(false);
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                this.WSMinMaxClose.ShowIconMax(true);
            }
        }

        #region User Interface


        [SettingsBindable(true)]
        public string DisplayText
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

        [SettingsBindable(true)]
        public Image DisplayIcon
        {
            get
            {
                return this.titleIcon.Image;
            }

            set
            {
                if (value != null)
                {
                    this.titleIcon.Image = value;
                }
            }
        }
        #endregion


        int TogMove = 0;
        int MValX = 0;
        int MValY = 0;
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonMaximum_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            if (CloseAllAfterClick)
            {
                this.CloseAll();
            }
            else
            {
                this.Close();
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        public virtual void CloseAll()
        {
            try
            {
                Close();
            }
            catch (Exception)
            {

            }

            try
            {
                Environment.Exit(0);
            }
            catch (Exception)
            {

            }
        }



        [Browsable(true)]
        public Color FormTitleColor
        {
            get
            {
                return this.panelHeader.BackColor;
            }

            set
            {
                this.panelHeader.BackColor = value;
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }
    }
}
