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
    public partial class WindowStypeMinClose : UserControl
    {
        Color ButtonCloseBackColor = Color.Red;
        Color ButtonMinimizeColor = Color.White;

        public WindowStypeMinClose()
        {
            InitializeComponent();

            this.ButtonClose.MouseHover += ButtonClose_MouseHover;
            this.ButtonClose.MouseLeave += ButtonClose_MouseLeave;
            this.ButtonClose.MouseEnter += ButtonClose_MouseHover;

            this.ButtonMinimize.MouseHover += ButtonMinimize_MouseHover;
            this.ButtonMinimize.MouseLeave += ButtonMinimize_MouseLeave;
            this.ButtonMinimize.MouseEnter += ButtonMinimize_MouseHover;
        }

        private void ButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonMinimize.BackColor = Color.FromArgb(0, this.ButtonMinimizeColor);
        }

        private void ButtonMinimize_MouseHover(object sender, EventArgs e)
        {
            this.ButtonMinimize.BackColor = Color.FromArgb(80, this.ButtonMinimizeColor);
        }


        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonClose.BackColor = Color.FromArgb(0, this.ButtonCloseBackColor);
        }

        private void ButtonClose_MouseHover(object sender, EventArgs e)
        {
            this.ButtonClose.BackColor = Color.FromArgb(80, this.ButtonCloseBackColor);
        }
    }
}
