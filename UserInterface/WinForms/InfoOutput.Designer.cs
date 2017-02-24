namespace CommonLib.UserInterface.WinForms
{
    partial class InfoOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoOutput));
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelMiddle = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.PanelResize = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelError = new System.Windows.Forms.Panel();
            this.rtbError = new System.Windows.Forms.RichTextBox();
            this.panelHeader.SuspendLayout();
            this.PanelWS.SuspendLayout();
            this.FormPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.PanelMiddle.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelError.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Text = "Information Box";
            // 
            // FormPanel
            // 
            this.FormPanel.Size = new System.Drawing.Size(798, 590);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.PanelBottom);
            this.MainPanel.Size = new System.Drawing.Size(798, 558);
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.PanelMiddle);
            this.PanelBottom.Controls.Add(this.PanelResize);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 517);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(798, 41);
            this.PanelBottom.TabIndex = 2;
            // 
            // PanelMiddle
            // 
            this.PanelMiddle.Controls.Add(this.btnOK);
            this.PanelMiddle.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMiddle.Location = new System.Drawing.Point(264, 0);
            this.PanelMiddle.Name = "PanelMiddle";
            this.PanelMiddle.Size = new System.Drawing.Size(104, 41);
            this.PanelMiddle.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(6, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 34);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // PanelResize
            // 
            this.PanelResize.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelResize.Location = new System.Drawing.Point(0, 0);
            this.PanelResize.Name = "PanelResize";
            this.PanelResize.Size = new System.Drawing.Size(264, 41);
            this.PanelResize.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PanelError);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(798, 517);
            this.panel3.TabIndex = 3;
            // 
            // PanelError
            // 
            this.PanelError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelError.Controls.Add(this.rtbError);
            this.PanelError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelError.Location = new System.Drawing.Point(10, 10);
            this.PanelError.Margin = new System.Windows.Forms.Padding(10);
            this.PanelError.Name = "PanelError";
            this.PanelError.Padding = new System.Windows.Forms.Padding(10);
            this.PanelError.Size = new System.Drawing.Size(778, 497);
            this.PanelError.TabIndex = 2;
            // 
            // rtbError
            // 
            this.rtbError.BackColor = System.Drawing.Color.White;
            this.rtbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbError.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbError.Location = new System.Drawing.Point(10, 10);
            this.rtbError.Name = "rtbError";
            this.rtbError.ReadOnly = true;
            this.rtbError.Size = new System.Drawing.Size(756, 475);
            this.rtbError.TabIndex = 0;
            this.rtbError.Text = "";
            // 
            // InfoOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.DisplayIcon = global::CommonLib.Properties.Resources.MBInformation;
            this.DisplayText = "Information Box";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoOutput";
            this.Text = "ErrorOutput";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.PanelWS.ResumeLayout(false);
            this.FormPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelBottom.ResumeLayout(false);
            this.PanelMiddle.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.PanelError.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Panel PanelMiddle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelError;
        private System.Windows.Forms.RichTextBox rtbError;
        private System.Windows.Forms.Panel PanelResize;
    }
}