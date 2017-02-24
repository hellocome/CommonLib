namespace CommonLib.UserInterface.WinForms
{
    partial class WindowStypeMinClose
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
            this.ButtonMinimize = new NoBorderButton();
            this.ButtonClose = new NoBorderButton();
            this.SuspendLayout();
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMinimize.BackgroundImage = global::CommonLib.Properties.Resource.MinimizeWhite;
            this.ButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Location = new System.Drawing.Point(1, 1);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(24, 24);
            this.ButtonMinimize.TabIndex = 1;
            this.ButtonMinimize.TabStop = false;
            this.ButtonMinimize.UseVisualStyleBackColor = false;
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ButtonClose.BackgroundImage = global::CommonLib.Properties.Resource.CloseWhite;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Location = new System.Drawing.Point(31, 1);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(24, 24);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.UseVisualStyleBackColor = false;
            // 
            // WindowStypeMinClose
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ButtonMinimize);
            this.Controls.Add(this.ButtonClose);
            this.MaximumSize = new System.Drawing.Size(58, 26);
            this.MinimumSize = new System.Drawing.Size(58, 26);
            this.Name = "WindowStypeMinClose";
            this.Size = new System.Drawing.Size(58, 26);
            this.ResumeLayout(false);

        }

        #endregion

        public NoBorderButton ButtonClose;
        public NoBorderButton ButtonMinimize;
    }
}
