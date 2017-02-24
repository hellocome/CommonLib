using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace CommonLib.UserInterface.WinForms
{
    public class ControlBorder
    {        // Win32 Constants
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
        public static void RemoveBorder(System.Windows.Forms.Control.ControlCollection controls)
        {
            try
            {/*
                MdiClient mdiClient = null;

                for (int i = 0; i < controls.Count; i++)
                {
                    mdiClient = controls[i] as MdiClient;
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
                    SWP_NOOWNERZORDER | SWP_FRAMECHANGED);*/
            }
            catch
            { }
        }
    }
}
