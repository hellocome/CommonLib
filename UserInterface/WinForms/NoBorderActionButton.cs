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
    public partial class NoBorderActionButton : System.Windows.Forms.Button
    {
        Color ButtonOriginColor = Color.FromArgb(155, 187, 89);

        public NoBorderActionButton() : base()
        {
            InitializeComponent();

            this.TabStop = false;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

            this.MouseLeave += ButtonMouseLeave;
            this.MouseEnter += ButtonMouseHover;
            this.MouseHover += ButtonMouseHover;
            this.MouseDown += ButtonMouseDown;
            this.MouseUp += ButtonMouseLeave;

            this.EnabledChanged += NoBorderActionButton_EnabledChanged;
        }

        private void NoBorderActionButton_EnabledChanged(object sender, EventArgs e)
        {
            if(!this.Enabled)
            {
                this.BackColor = Color.LightGray;
                
            }
            else
            {
                this.BackColor = this.ButtonOriginColor;
            }
        }

        private void ButtonMouseDown(object sender, MouseEventArgs e)
        {
            if (this.Enabled)
            {
                this.BackColor = Color.FromArgb(40, this.ButtonOriginColor);
            }
            else
            {
                this.BackColor = Color.LightGray;
            }
            
        }

        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                this.BackColor = this.ButtonOriginColor;
            }
            else
            {
                this.BackColor = Color.LightGray;
            }
        }

        private void ButtonMouseHover(object sender, EventArgs e)
        {
            if (this.Enabled)
            {
                this.BackColor = Color.FromArgb(80, this.ButtonOriginColor);
            }
            else
            {
                this.BackColor = Color.LightGray;
            }
        }
    }
}
