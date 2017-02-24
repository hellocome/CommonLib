using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonLib.UserInterface.WinForms
{
    public partial class InfoOutput : NoBorderMainForm
    {
        public InfoOutput()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            SendToCenter();

            this.SizeChanged += ErrorOutput_SizeChanged;
        }

        private void ErrorOutput_SizeChanged(object sender, EventArgs e)
        {
            SendToCenter();
        }

        private void SendToCenter()
        {
            this.PanelResize.Width = (PanelBottom.Width - PanelMiddle.Width) / 2;
        }

        public void ShowError(string str, string title = "")
        {
            this.rtbError.Text = str;

            if (!string.IsNullOrEmpty(title))
            {
                this.LabelTitle.Text = "Error: " + title;
            }
            else
            {
                this.LabelTitle.Text = "Error";
            }

            this.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
