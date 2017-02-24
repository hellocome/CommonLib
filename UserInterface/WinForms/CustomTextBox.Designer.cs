namespace CommonLib.UserInterface.WinForms
{
    partial class CustomTextBox
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
            this.PBIcon = new System.Windows.Forms.PictureBox();
            this.PanelTextBox = new System.Windows.Forms.Panel();
            this.InnerTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).BeginInit();
            this.PanelTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBIcon
            // 
            this.PBIcon.BackColor = System.Drawing.Color.White;
            this.PBIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PBIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PBIcon.Location = new System.Drawing.Point(1, 1);
            this.PBIcon.Name = "PBIcon";
            this.PBIcon.Size = new System.Drawing.Size(48, 49);
            this.PBIcon.TabIndex = 1;
            this.PBIcon.TabStop = false;
            // 
            // PanelTextBox
            // 
            this.PanelTextBox.BackColor = System.Drawing.Color.White;
            this.PanelTextBox.Controls.Add(this.InnerTextBox);
            this.PanelTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTextBox.Location = new System.Drawing.Point(49, 1);
            this.PanelTextBox.Name = "PanelTextBox";
            this.PanelTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.PanelTextBox.Size = new System.Drawing.Size(331, 49);
            this.PanelTextBox.TabIndex = 2;
            // 
            // InnerTextBox
            // 
            this.InnerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InnerTextBox.BackColor = System.Drawing.Color.White;
            this.InnerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InnerTextBox.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.InnerTextBox.ForeColor = System.Drawing.Color.Gray;
            this.InnerTextBox.Location = new System.Drawing.Point(35, 8);
            this.InnerTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.InnerTextBox.MaxLength = 500;
            this.InnerTextBox.Name = "InnerTextBox";
            this.InnerTextBox.Size = new System.Drawing.Size(247, 32);
            this.InnerTextBox.TabIndex = 1;
            this.InnerTextBox.WordWrap = false;
            // 
            // CustomTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTextBox);
            this.Controls.Add(this.PBIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CustomTextBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(381, 51);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UserControl_Paint);
            this.Resize += new System.EventHandler(this.UserControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PBIcon)).EndInit();
            this.PanelTextBox.ResumeLayout(false);
            this.PanelTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PBIcon;
        private System.Windows.Forms.Panel PanelTextBox;
        private System.Windows.Forms.TextBox InnerTextBox;
    }
}
