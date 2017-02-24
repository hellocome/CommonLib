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
    public partial class WindowStypeMinMaxClose : UserControl
    {
        Color ButtonCloseBackColor = Color.Red;
        Color ButtonMinimizeColor = Color.White;
        Color ButtonMaximumColor = Color.White;
        
        public WindowStypeMinMaxClose()
        {
            InitializeComponent();
            
            this.ButtonClose.MouseHover += ButtonClose_MouseHover;
            this.ButtonClose.MouseLeave += ButtonClose_MouseLeave;
            this.ButtonClose.MouseEnter += ButtonClose_MouseHover;

            this.ButtonMinimize.MouseHover += ButtonMinimize_MouseHover;
            this.ButtonMinimize.MouseLeave += ButtonMinimize_MouseLeave;
            this.ButtonMinimize.MouseEnter += ButtonMinimize_MouseHover;

            this.ButtonMaximum.MouseHover += ButtonMaximum_MouseHover;
            this.ButtonMaximum.MouseLeave += ButtonMaximum_MouseLeave;
            this.ButtonMaximum.MouseEnter += ButtonMaximum_MouseHover;
        }

        private void ButtonMinimize_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonMinimize.BackColor = Color.FromArgb(0, this.ButtonMinimizeColor);
        }

        private void ButtonMinimize_MouseHover(object sender, EventArgs e)
        {
            this.ButtonMinimize.BackColor = Color.FromArgb(80, this.ButtonMinimizeColor);
        }

        private void ButtonMaximum_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonMaximum.BackColor = Color.FromArgb(0, this.ButtonMaximumColor);
        }

        private void ButtonMaximum_MouseHover(object sender, EventArgs e)
        {
            this.ButtonMaximum.BackColor = Color.FromArgb(80, this.ButtonMaximumColor);
        }


        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            this.ButtonClose.BackColor =  Color.FromArgb(0, this.ButtonCloseBackColor);
        }

        private void ButtonClose_MouseHover(object sender, EventArgs e)
        {
            this.ButtonClose.BackColor = Color.FromArgb(80, this.ButtonCloseBackColor);
        }


        public void ShowIconMax(bool isParentMax)
        {
            if (isParentMax)
            {
                this.ButtonMaximum.BackgroundImage = CommonLib.Properties.Resource.MaximumWhite;
            }
            else
            {
                this.ButtonMaximum.BackgroundImage = CommonLib.Properties.Resource.RestoreWhite;
            }
        }


        /*
        private void ChangeControlColour(Control activeControl, Color eventColour)
        {
            uint intervals = 20;
            var colorFader = new ColorFader(activeControl.BackColor, eventColour, intervals);
            
            Task t = Task.Factory.StartNew(() =>
            {
                System.Threading.Thread.Sleep(100);
                foreach (var color in colorFader.Fade())
                {
                    SetControlBackColor(activeControl, color);
                    System.Threading.Thread.Sleep(50);
                }
            });
        }


        private void SetControlBackColor(Control activeControl, Color colour)
        {
            if (activeControl.InvokeRequired)
                activeControl.Invoke((MethodInvoker)delegate { activeControl.BackColor = colour; });
            else
                activeControl.BackColor = colour;
        }

        public class ColorFader
        {
            private readonly Color _From;
            private readonly Color _To;

            private readonly double _StepR;
            private readonly double _StepG;
            private readonly double _StepB;

            private readonly uint _Steps;

            public ColorFader(Color from, Color to, uint steps)
            {
                if (steps == 0)
                    throw new ArgumentException("steps must be a positive number");

                _From = from;
                _To = to;
                _Steps = steps;

                _StepR = (double)(_To.R - _From.R) / _Steps;
                _StepG = (double)(_To.G - _From.G) / _Steps;
                _StepB = (double)(_To.B - _From.B) / _Steps;
            }

            public IEnumerable<Color> Fade()
            {
                for (uint i = 0; i < _Steps; ++i)
                {
                    yield return Color.FromArgb((int)(_From.R + i * _StepR), (int)(_From.G + i * _StepG), (int)(_From.B + i * _StepB));
                }

                yield return _To; // make sure we always return the exact target color last
            }
        }*/
    }
}
