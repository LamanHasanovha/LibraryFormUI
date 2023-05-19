namespace WinformUI.Infrastructure.CustomControls
{
    partial class ButtonItem
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
            this.lblTitle = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.btnIcon = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(13, 98);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Opacity = 0;
            this.lblTitle.Size = new System.Drawing.Size(49, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            this.lblTitle.TransparentBackColor = System.Drawing.Color.Black;
            this.lblTitle.Click += new System.EventHandler(this.Item_Click);
            // 
            // btnIcon
            // 
            this.btnIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIcon.BackColor = System.Drawing.SystemColors.Control;
            this.btnIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIcon.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.btnIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.btnIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIcon.IconSize = 80;
            this.btnIcon.Location = new System.Drawing.Point(148, 3);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(99, 86);
            this.btnIcon.TabIndex = 2;
            this.btnIcon.TabStop = false;
            this.btnIcon.Click += new System.EventHandler(this.Item_Click);
            // 
            // ButtonItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(250, 150);
            this.MinimumSize = new System.Drawing.Size(250, 150);
            this.Name = "ButtonItem";
            this.Size = new System.Drawing.Size(250, 150);
            this.Load += new System.EventHandler(this.ButtonItem_Load);
            this.Click += new System.EventHandler(this.Item_Click);
            ((System.ComponentModel.ISupportInitialize)(this.btnIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TransparentLabelNew lblTitle;
        private FontAwesome.Sharp.IconPictureBox btnIcon;
    }
}
