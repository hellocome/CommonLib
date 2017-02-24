namespace CommonLib.UserInterface.WinForms
{
    partial class NoBorderMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.titleIcon = new System.Windows.Forms.PictureBox();
            this.PanelWS = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.WSMinMaxClose = new CommonLib.UserInterface.WinForms.WindowStypeMinMaxClose();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).BeginInit();
            this.PanelWS.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelHeader.Controls.Add(this.titleIcon);
            this.panelHeader.Controls.Add(this.PanelWS);
            this.panelHeader.Controls.Add(this.LabelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(798, 32);
            this.panelHeader.TabIndex = 9;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // titleIcon
            // 
            this.titleIcon.Location = new System.Drawing.Point(5, 6);
            this.titleIcon.Name = "titleIcon";
            this.titleIcon.Size = new System.Drawing.Size(18, 18);
            this.titleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleIcon.TabIndex = 6;
            this.titleIcon.TabStop = false;
            // 
            // PanelWS
            // 
            this.PanelWS.Controls.Add(this.WSMinMaxClose);
            this.PanelWS.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelWS.Location = new System.Drawing.Point(700, 0);
            this.PanelWS.Name = "PanelWS";
            this.PanelWS.Size = new System.Drawing.Size(98, 32);
            this.PanelWS.TabIndex = 3;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LabelTitle.ForeColor = System.Drawing.Color.Black;
            this.LabelTitle.Location = new System.Drawing.Point(28, 5);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(116, 20);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "No Border Form";
            // 
            // FormPanel
            // 
            this.FormPanel.Controls.Add(this.MainPanel);
            this.FormPanel.Controls.Add(this.panelHeader);
            this.FormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPanel.Location = new System.Drawing.Point(1, 1);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(798, 498);
            this.FormPanel.TabIndex = 10;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 32);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(798, 466);
            this.MainPanel.TabIndex = 10;
            // 
            // WSMinMaxClose
            // 
            this.WSMinMaxClose.BackColor = System.Drawing.Color.Transparent;
            this.WSMinMaxClose.Location = new System.Drawing.Point(11, 3);
            this.WSMinMaxClose.MaximumSize = new System.Drawing.Size(84, 26);
            this.WSMinMaxClose.MinimumSize = new System.Drawing.Size(84, 26);
            this.WSMinMaxClose.Name = "WSMinMaxClose";
            this.WSMinMaxClose.Size = new System.Drawing.Size(84, 26);
            this.WSMinMaxClose.TabIndex = 0;
            // 
            // NoBorderMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.FormPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "NoBorderMainForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titleIcon)).EndInit();
            this.PanelWS.ResumeLayout(false);
            this.FormPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelHeader;
        public System.Windows.Forms.Panel PanelWS;
        public WindowStypeMinMaxClose WSMinMaxClose;
        public System.Windows.Forms.Label LabelTitle;
        public System.Windows.Forms.Panel FormPanel;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox titleIcon;
    }
}