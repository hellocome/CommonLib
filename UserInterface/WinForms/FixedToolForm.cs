using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CommonLib.UserInterface.WinForms
{
    public partial class FixedToolForm : Form
    {
        #region Private Constant and variables

        private int TogMove = 0;
        private int MValX = 0;
        private int MValY = 0;
        private const int GWL_STYLE = -16;
        private const int GWL_EXSTYLE = -20;

        private const int WS_BORDER = 0x00800000;
        private const int WS_EX_CLIENTEDGE = 0x00000200;

        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_NOZORDER = 0x0004;
        private const uint SWP_NOREDRAW = 0x0008;
        private const uint SWP_NOACTIVATE = 0x0010;
        private const uint SWP_FRAMECHANGED = 0x0020;
        private const uint SWP_SHOWWINDOW = 0x0040;
        private const uint SWP_HIDEWINDOW = 0x0080;
        private const uint SWP_NOCOPYBITS = 0x0100;
        private const uint SWP_NOOWNERZORDER = 0x0200;
        private const uint SWP_NOSENDCHANGING = 0x0400;

        private const int FEATURE_DISABLE_NAVIGATION_SOUNDS = 21;
        private const int SET_FEATURE_ON_PROCESS = 0x00000002;

        public bool ShowExitWarning = false;

        #endregion

        #region Win32
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowLong(IntPtr hWnd, int Index);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetWindowLong(IntPtr hWnd, int Index, int Value);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter,
            int X, int Y, int cx, int cy, uint uFlags);

        [DllImport("urlmon.dll")]
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        static extern int CoInternetSetFeatureEnabled(
            int FeatureEntry, [MarshalAs(UnmanagedType.U4)] int dwFlags, bool fEnable);

        #endregion

        #region Constructor
        public FixedToolForm()
        {
            InitializeComponent();

            RemoveBorder();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            this.MinCloseControl.ButtonClose.Click += ButtonClose_Click;
            this.MinCloseControl.ButtonMinimize.Click += ButtonMinimize_Click;

            this.StartPosition = FormStartPosition.CenterParent;
        }



        #endregion

        #region Private Methods , GUI
        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        protected virtual void CloseForm()
        {
            if (ShowExitWarning)
            {
                if (FixedMessageBox.Show("Do you want to Exit?", "Exit", FixedMessageBoxButtons.YesNo, FixedMessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CloseAll();
                }
            }
            else
            {
                CloseAll();
            }
        }

        private void RemoveBorder()
        {
            try
            {
                MdiClient mdiClient = null;

                for (int i = 0; i < this.Controls.Count; i++)
                {
                    mdiClient = this.Controls[i] as MdiClient;
                    if (mdiClient != null)
                    {
                        break;
                    }
                }
                mdiClient.BackColor = Color.Gray;

                int style = GetWindowLong(mdiClient.Handle, GWL_STYLE);
                int exStyle = GetWindowLong(mdiClient.Handle, GWL_EXSTYLE);

                style &= ~WS_BORDER;
                exStyle &= ~WS_EX_CLIENTEDGE;

                // Set the styles using Win32 calls
                SetWindowLong(mdiClient.Handle, GWL_STYLE, style);
                SetWindowLong(mdiClient.Handle, GWL_EXSTYLE, exStyle);

                // Update the non-client area.
                SetWindowPos(mdiClient.Handle, IntPtr.Zero, 0, 0, 0, 0,
                    SWP_NOACTIVATE | SWP_NOMOVE | SWP_NOSIZE | SWP_NOZORDER |
                    SWP_NOOWNERZORDER | SWP_FRAMECHANGED);
            }
            catch
            { }
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

        private void labelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X + this.labelTitle.Location.X;
            MValY = e.Y + this.labelTitle.Location.Y;
        }

        private void labelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void labelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
        
        #endregion

        #region Public Methods and Properties
        public void CloseAll()
        {
            try
            {
                Close();
            }
            catch (Exception)
            {
                Environment.Exit(0);
            }
        }

        [SettingsBindable(true)]
        public string DisplayText
        {
            get
            {
                return this.labelTitle.Text;
            }

            set
            {
                this.labelTitle.Text = value;
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
        
    }
}
