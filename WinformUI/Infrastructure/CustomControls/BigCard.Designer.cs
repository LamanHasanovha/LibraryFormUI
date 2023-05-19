namespace WinformUI.Infrastructure.CustomControls
{
    partial class BigCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigCard));
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblDescription = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblDescription);
            this.panelMain.Controls.Add(this.pcbImage);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(550, 330);
            this.panelMain.TabIndex = 0;
            this.panelMain.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            this.panelMain.MouseHover += new System.EventHandler(this.Card_MouseHover);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(0, 237);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Opacity = 180;
            this.lblTitle.Size = new System.Drawing.Size(550, 56);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title";
            this.lblTitle.TransparentBackColor = System.Drawing.Color.Black;
            this.lblTitle.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            this.lblTitle.MouseHover += new System.EventHandler(this.Card_MouseHover);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Location = new System.Drawing.Point(0, 293);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Opacity = 180;
            this.lblDescription.Size = new System.Drawing.Size(550, 37);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            this.lblDescription.TransparentBackColor = System.Drawing.Color.Black;
            this.lblDescription.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            this.lblDescription.MouseHover += new System.EventHandler(this.Card_MouseHover);
            // 
            // pcbImage
            // 
            this.pcbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(0, 0);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(550, 330);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            this.pcbImage.Click += new System.EventHandler(this.card_Click);
            this.pcbImage.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            this.pcbImage.MouseHover += new System.EventHandler(this.Card_MouseHover);
            // 
            // BigCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MinimumSize = new System.Drawing.Size(550, 330);
            this.Name = "BigCard";
            this.Size = new System.Drawing.Size(550, 330);
            this.Click += new System.EventHandler(this.card_Click);
            this.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Card_MouseHover);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private TransparentLabelNew lblDescription;
        private System.Windows.Forms.PictureBox pcbImage;
        private TransparentLabelNew lblTitle;
    }
}
