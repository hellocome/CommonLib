using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommonLib.UserInterface.WinForms
{
    public class NoBorderButton : System.Windows.Forms.Button
    {
        public NoBorderButton()
            : base()
        {
            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
        }
    }
}
