namespace CommonLib.UserInterface.WinForms
{
    partial class TextPanel
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
            this.rtbPlain = new System.Windows.Forms.RichTextBox();
            this.LabelInputInformation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPLAIN = new System.Windows.Forms.Button();
            this.btnHEX = new System.Windows.Forms.Button();
            this.rtbFormat = new System.Windows.Forms.RichTextBox();
            this.CBBase64 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbPlain
            // 
            this.rtbPlain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtbPlain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPlain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbPlain.Font = new System.Drawing.Font("Consolas", 8F);
            this.rtbPlain.Location = new System.Drawing.Point(0, 38);
            this.rtbPlain.Name = "rtbPlain";
            this.rtbPlain.Size = new System.Drawing.Size(299, 313);
            this.rtbPlain.TabIndex = 6;
            this.rtbPlain.Text = "";
            // 
            // LabelInputInformation
            // 
            this.LabelInputInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelInputInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelInputInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelInputInformation.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LabelInputInformation.Location = new System.Drawing.Point(0, 351);
            this.LabelInputInformation.Name = "LabelInputInformation";
            this.LabelInputInformation.Size = new System.Drawing.Size(630, 19);
            this.LabelInputInformation.TabIndex = 7;
            this.LabelInputInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBBase64);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 38);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPLAIN);
            this.panel2.Controls.Add(this.btnHEX);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(299, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 38);
            this.panel2.TabIndex = 30;
            // 
            // btnPLAIN
            // 
            this.btnPLAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPLAIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPLAIN.Location = new System.Drawing.Point(231, 9);
            this.btnPLAIN.Name = "btnPLAIN";
            this.btnPLAIN.Size = new System.Drawing.Size(86, 23);
            this.btnPLAIN.TabIndex = 27;
            this.btnPLAIN.Text = "PLAIN";
            this.btnPLAIN.UseVisualStyleBackColor = false;
            this.btnPLAIN.Click += new System.EventHandler(this.btnPLAIN_Click);
            // 
            // btnHEX
            // 
            this.btnHEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnHEX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHEX.Location = new System.Drawing.Point(139, 9);
            this.btnHEX.Name = "btnHEX";
            this.btnHEX.Size = new System.Drawing.Size(86, 23);
            this.btnHEX.TabIndex = 26;
            this.btnHEX.Text = "HEX";
            this.btnHEX.UseVisualStyleBackColor = false;
            this.btnHEX.Click += new System.EventHandler(this.btnHEX_Click);
            // 
            // rtbFormat
            // 
            this.rtbFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtbFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbFormat.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbFormat.Font = new System.Drawing.Font("Consolas", 8F);
            this.rtbFormat.Location = new System.Drawing.Point(299, 38);
            this.rtbFormat.Name = "rtbFormat";
            this.rtbFormat.ReadOnly = true;
            this.rtbFormat.Size = new System.Drawing.Size(331, 313);
            this.rtbFormat.TabIndex = 30;
            this.rtbFormat.Text = "";
            // 
            // CBBase64
            // 
            this.CBBase64.AutoSize = true;
            this.CBBase64.Checked = true;
            this.CBBase64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBBase64.Location = new System.Drawing.Point(14, 9);
            this.CBBase64.Name = "CBBase64";
            this.CBBase64.Size = new System.Drawing.Size(62, 17);
            this.CBBase64.TabIndex = 31;
            this.CBBase64.Text = "Base64";
            this.CBBase64.UseVisualStyleBackColor = true;
            // 
            // TextPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rtbPlain);
            this.Controls.Add(this.rtbFormat);
            this.Controls.Add(this.LabelInputInformation);
            this.Controls.Add(this.panel1);
            this.Name = "TextPanel";
            this.Size = new System.Drawing.Size(630, 370);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPlain;
        private System.Windows.Forms.Label LabelInputInformation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbFormat;
        private System.Windows.Forms.Button btnPLAIN;
        private System.Windows.Forms.Button btnHEX;
        private System.Windows.Forms.CheckBox CBBase64;
    }
}
