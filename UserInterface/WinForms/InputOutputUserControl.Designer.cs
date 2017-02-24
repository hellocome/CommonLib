namespace CommonLib.UserInterface.WinForms
{
    partial class InputOutputUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SplitContainerInputOuput = new System.Windows.Forms.SplitContainer();
            this.splitContainerLeft = new System.Windows.Forms.SplitContainer();
            this.splitContainerRight = new System.Windows.Forms.SplitContainer();
            this.RTBInputOutput1 = new CommonLib.UserInterface.WinForms.InfoTextBox();
            this.RTBInputOutput3 = new CommonLib.UserInterface.WinForms.InfoTextBox();
            this.RTBInputOutput2 = new CommonLib.UserInterface.WinForms.InfoTextBox();
            this.RTBInputOutput4 = new CommonLib.UserInterface.WinForms.InfoTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerInputOuput)).BeginInit();
            this.SplitContainerInputOuput.Panel1.SuspendLayout();
            this.SplitContainerInputOuput.Panel2.SuspendLayout();
            this.SplitContainerInputOuput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).BeginInit();
            this.splitContainerLeft.Panel1.SuspendLayout();
            this.splitContainerLeft.Panel2.SuspendLayout();
            this.splitContainerLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).BeginInit();
            this.splitContainerRight.Panel1.SuspendLayout();
            this.splitContainerRight.Panel2.SuspendLayout();
            this.splitContainerRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(2, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(851, 203);
            this.MainPanel.TabIndex = 1;
            // 
            // SplitContainerInputOuput
            // 
            this.SplitContainerInputOuput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerInputOuput.Location = new System.Drawing.Point(2, 205);
            this.SplitContainerInputOuput.Name = "SplitContainerInputOuput";
            // 
            // SplitContainerInputOuput.Panel1
            // 
            this.SplitContainerInputOuput.Panel1.Controls.Add(this.splitContainerLeft);
            // 
            // SplitContainerInputOuput.Panel2
            // 
            this.SplitContainerInputOuput.Panel2.Controls.Add(this.splitContainerRight);
            this.SplitContainerInputOuput.Size = new System.Drawing.Size(851, 414);
            this.SplitContainerInputOuput.SplitterDistance = 412;
            this.SplitContainerInputOuput.TabIndex = 3;
            // 
            // splitContainerLeft
            // 
            this.splitContainerLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerLeft.Name = "splitContainerLeft";
            this.splitContainerLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLeft.Panel1
            // 
            this.splitContainerLeft.Panel1.Controls.Add(this.RTBInputOutput1);
            // 
            // splitContainerLeft.Panel2
            // 
            this.splitContainerLeft.Panel2.Controls.Add(this.RTBInputOutput3);
            this.splitContainerLeft.Size = new System.Drawing.Size(412, 414);
            this.splitContainerLeft.SplitterDistance = 209;
            this.splitContainerLeft.TabIndex = 0;
            // 
            // splitContainerRight
            // 
            this.splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerRight.Name = "splitContainerRight";
            this.splitContainerRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerRight.Panel1
            // 
            this.splitContainerRight.Panel1.Controls.Add(this.RTBInputOutput2);
            // 
            // splitContainerRight.Panel2
            // 
            this.splitContainerRight.Panel2.Controls.Add(this.RTBInputOutput4);
            this.splitContainerRight.Size = new System.Drawing.Size(435, 414);
            this.splitContainerRight.SplitterDistance = 209;
            this.splitContainerRight.TabIndex = 1;
            // 
            // RTBInputOutput1
            // 
            this.RTBInputOutput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTBInputOutput1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBInputOutput1.Location = new System.Drawing.Point(0, 0);
            this.RTBInputOutput1.Name = "RTBInputOutput1";
            this.RTBInputOutput1.Size = new System.Drawing.Size(412, 209);
            this.RTBInputOutput1.TabIndex = 0;
            this.RTBInputOutput1.Title = "";
            // 
            // RTBInputOutput3
            // 
            this.RTBInputOutput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTBInputOutput3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBInputOutput3.Location = new System.Drawing.Point(0, 0);
            this.RTBInputOutput3.Name = "RTBInputOutput3";
            this.RTBInputOutput3.Size = new System.Drawing.Size(412, 201);
            this.RTBInputOutput3.TabIndex = 2;
            this.RTBInputOutput3.Title = "";
            // 
            // RTBInputOutput2
            // 
            this.RTBInputOutput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTBInputOutput2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBInputOutput2.Location = new System.Drawing.Point(0, 0);
            this.RTBInputOutput2.Name = "RTBInputOutput2";
            this.RTBInputOutput2.Size = new System.Drawing.Size(435, 209);
            this.RTBInputOutput2.TabIndex = 2;
            this.RTBInputOutput2.Title = "";
            // 
            // RTBInputOutput4
            // 
            this.RTBInputOutput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTBInputOutput4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBInputOutput4.Location = new System.Drawing.Point(0, 0);
            this.RTBInputOutput4.Name = "RTBInputOutput4";
            this.RTBInputOutput4.Size = new System.Drawing.Size(435, 201);
            this.RTBInputOutput4.TabIndex = 2;
            this.RTBInputOutput4.Title = "";
            // 
            // InputOutputUserControl
            // 
            this.Controls.Add(this.SplitContainerInputOuput);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InputOutputUserControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(855, 621);
            this.SplitContainerInputOuput.Panel1.ResumeLayout(false);
            this.SplitContainerInputOuput.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerInputOuput)).EndInit();
            this.SplitContainerInputOuput.ResumeLayout(false);
            this.splitContainerLeft.Panel1.ResumeLayout(false);
            this.splitContainerLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLeft)).EndInit();
            this.splitContainerLeft.ResumeLayout(false);
            this.splitContainerRight.Panel1.ResumeLayout(false);
            this.splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerRight)).EndInit();
            this.splitContainerRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.SplitContainer SplitContainerInputOuput;
        private System.Windows.Forms.SplitContainer splitContainerLeft;
        private System.Windows.Forms.SplitContainer splitContainerRight;
        public InfoTextBox RTBInputOutput1;
        public InfoTextBox RTBInputOutput3;
        public InfoTextBox RTBInputOutput2;
        public InfoTextBox RTBInputOutput4;
    }
}
