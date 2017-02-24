namespace CommonLib.UserInterface.WinForms
{
    partial class FixedMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixedMessageBox));
            this.MBPanelOKCancel = new System.Windows.Forms.Panel();
            this.btnOKCancelCancel = new CommonLib.UserInterface.WinForms.NoBorderActionButton();
            this.btnOKCancelOK = new CommonLib.UserInterface.WinForms.NoBorderActionButton();
            this.MBPanelYesNO = new System.Windows.Forms.Panel();
            this.btnYesNoNo = new CommonLib.UserInterface.WinForms.NoBorderActionButton();
            this.btnYesNoYes = new CommonLib.UserInterface.WinForms.NoBorderActionButton();
            this.MBPanelOK = new System.Windows.Forms.Panel();
            this.btnOK = new CommonLib.UserInterface.WinForms.NoBorderActionButton();
            this.PanelMessage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbMBIcon = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.MBPanelOKCancel.SuspendLayout();
            this.MBPanelYesNO.SuspendLayout();
            this.MBPanelOK.SuspendLayout();
            this.PanelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMBIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.PanelMessage);
            this.MainPanel.Controls.Add(this.MBPanelYesNO);
            this.MainPanel.Controls.Add(this.MBPanelOK);
            this.MainPanel.Controls.Add(this.MBPanelOKCancel);
            this.MainPanel.Size = new System.Drawing.Size(416, 126);
            // 
            // MBPanelOKCancel
            // 
            this.MBPanelOKCancel.Controls.Add(this.btnOKCancelCancel);
            this.MBPanelOKCancel.Controls.Add(this.btnOKCancelOK);
            this.MBPanelOKCancel.Location = new System.Drawing.Point(218, 86);
            this.MBPanelOKCancel.Name = "MBPanelOKCancel";
            this.MBPanelOKCancel.Size = new System.Drawing.Size(189, 33);
            this.MBPanelOKCancel.TabIndex = 2;
            // 
            // btnOKCancelCancel
            // 
            this.btnOKCancelCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(89)))));
            this.btnOKCancelCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOKCancelCancel.FlatAppearance.BorderSize = 0;
            this.btnOKCancelCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKCancelCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOKCancelCancel.ForeColor = System.Drawing.Color.White;
            this.btnOKCancelCancel.Location = new System.Drawing.Point(100, 4);
            this.btnOKCancelCancel.Name = "btnOKCancelCancel";
            this.btnOKCancelCancel.Size = new System.Drawing.Size(82, 26);
            this.btnOKCancelCancel.TabIndex = 3;
            this.btnOKCancelCancel.TabStop = false;
            this.btnOKCancelCancel.Text = "Cancel";
            this.btnOKCancelCancel.UseVisualStyleBackColor = false;
            this.btnOKCancelCancel.Click += new System.EventHandler(this.btnOKCancelCancel_Click);
            // 
            // btnOKCancelOK
            // 
            this.btnOKCancelOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(89)))));
            this.btnOKCancelOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOKCancelOK.FlatAppearance.BorderSize = 0;
            this.btnOKCancelOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKCancelOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOKCancelOK.ForeColor = System.Drawing.Color.White;
            this.btnOKCancelOK.Location = new System.Drawing.Point(3, 4);
            this.btnOKCancelOK.Name = "btnOKCancelOK";
            this.btnOKCancelOK.Size = new System.Drawing.Size(82, 26);
            this.btnOKCancelOK.TabIndex = 2;
            this.btnOKCancelOK.TabStop = false;
            this.btnOKCancelOK.Text = "Yes";
            this.btnOKCancelOK.UseVisualStyleBackColor = false;
            this.btnOKCancelOK.Click += new System.EventHandler(this.btnOKCancelYes_Click);
            // 
            // MBPanelYesNO
            // 
            this.MBPanelYesNO.Controls.Add(this.btnYesNoNo);
            this.MBPanelYesNO.Controls.Add(this.btnYesNoYes);
            this.MBPanelYesNO.Location = new System.Drawing.Point(218, 86);
            this.MBPanelYesNO.Name = "MBPanelYesNO";
            this.MBPanelYesNO.Size = new System.Drawing.Size(189, 33);
            this.MBPanelYesNO.TabIndex = 4;
            // 
            // btnYesNoNo
            // 
            this.btnYesNoNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(89)))));
            this.btnYesNoNo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnYesNoNo.FlatAppearance.BorderSize = 0;
            this.btnYesNoNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesNoNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYesNoNo.ForeColor = System.Drawing.Color.White;
            this.btnYesNoNo.Location = new System.Drawing.Point(100, 4);
            this.btnYesNoNo.Name = "btnYesNoNo";
            this.btnYesNoNo.Size = new System.Drawing.Size(82, 26);
            this.btnYesNoNo.TabIndex = 3;
            this.btnYesNoNo.TabStop = false;
            this.btnYesNoNo.Text = "No";
            this.btnYesNoNo.UseVisualStyleBackColor = false;
            this.btnYesNoNo.Click += new System.EventHandler(this.btnYesNoNo_Click);
            // 
            // btnYesNoYes
            // 
            this.btnYesNoYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(89)))));
            this.btnYesNoYes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnYesNoYes.FlatAppearance.BorderSize = 0;
            this.btnYesNoYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesNoYes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYesNoYes.ForeColor = System.Drawing.Color.White;
            this.btnYesNoYes.Location = new System.Drawing.Point(3, 4);
            this.btnYesNoYes.Name = "btnYesNoYes";
            this.btnYesNoYes.Size = new System.Drawing.Size(82, 26);
            this.btnYesNoYes.TabIndex = 2;
            this.btnYesNoYes.TabStop = false;
            this.btnYesNoYes.Text = "Yes";
            this.btnYesNoYes.UseVisualStyleBackColor = false;
            this.btnYesNoYes.Click += new System.EventHandler(this.btnYesNoYes_Click);
            // 
            // MBPanelOK
            // 
            this.MBPanelOK.Controls.Add(this.btnOK);
            this.MBPanelOK.Location = new System.Drawing.Point(314, 86);
            this.MBPanelOK.Name = "MBPanelOK";
            this.MBPanelOK.Size = new System.Drawing.Size(93, 33);
            this.MBPanelOK.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(89)))));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 26);
            this.btnOK.TabIndex = 2;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // PanelMessage
            // 
            this.PanelMessage.Controls.Add(this.lblMessage);
            this.PanelMessage.Controls.Add(this.pbMBIcon);
            this.PanelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMessage.Location = new System.Drawing.Point(0, 0);
            this.PanelMessage.Name = "PanelMessage";
            this.PanelMessage.Size = new System.Drawing.Size(416, 83);
            this.PanelMessage.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(81, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(325, 62);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "1";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbMBIcon
            // 
            this.pbMBIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbMBIcon.Location = new System.Drawing.Point(31, 24);
            this.pbMBIcon.Name = "pbMBIcon";
            this.pbMBIcon.Size = new System.Drawing.Size(34, 34);
            this.pbMBIcon.TabIndex = 0;
            this.pbMBIcon.TabStop = false;
            // 
            // FixedMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 160);
            this.DisplayIcon = global::CommonLib.Properties.Resource.CSharp;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FixedMessageBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "CustomMessageBox";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomMessageBox_Paint);
            this.MainPanel.ResumeLayout(false);
            this.MBPanelOKCancel.ResumeLayout(false);
            this.MBPanelYesNO.ResumeLayout(false);
            this.MBPanelOK.ResumeLayout(false);
            this.PanelMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMBIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMBIcon;
        private System.Windows.Forms.Panel MBPanelOKCancel;
        private System.Windows.Forms.Panel MBPanelOK;
        private NoBorderActionButton btnOK;
        private System.Windows.Forms.Panel MBPanelYesNO;
        private NoBorderActionButton btnYesNoNo;
        private NoBorderActionButton btnYesNoYes;
        private NoBorderActionButton btnOKCancelCancel;
        private NoBorderActionButton btnOKCancelOK;
        private System.Windows.Forms.Panel PanelMessage;
        private System.Windows.Forms.Label lblMessage;
    }
}