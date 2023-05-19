namespace WinformUI.Infrastructure.CustomControls
{
    partial class NewsPresenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsPresenter));
            this.pcbBackImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblTitle = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblShadowLayer = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBackImage
            // 
            this.pcbBackImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbBackImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbBackImage.Image")));
            this.pcbBackImage.Location = new System.Drawing.Point(0, 0);
            this.pcbBackImage.Name = "pcbBackImage";
            this.pcbBackImage.Size = new System.Drawing.Size(1100, 583);
            this.pcbBackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBackImage.TabIndex = 0;
            this.pcbBackImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Location = new System.Drawing.Point(97, 111);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Opacity = 50;
            this.lblDescription.Size = new System.Drawing.Size(906, 48);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(97, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Opacity = 50;
            this.lblTitle.Size = new System.Drawing.Size(906, 71);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblShadowLayer
            // 
            this.lblShadowLayer.BackColor = System.Drawing.Color.Transparent;
            this.lblShadowLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShadowLayer.Location = new System.Drawing.Point(0, 0);
            this.lblShadowLayer.Name = "lblShadowLayer";
            this.lblShadowLayer.Opacity = 190;
            this.lblShadowLayer.Padding = new System.Windows.Forms.Padding(50);
            this.lblShadowLayer.Size = new System.Drawing.Size(1100, 583);
            this.lblShadowLayer.TabIndex = 1;
            this.lblShadowLayer.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // NewsPresenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblShadowLayer);
            this.Controls.Add(this.pcbBackImage);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "NewsPresenter";
            this.Size = new System.Drawing.Size(1100, 583);
            this.Load += new System.EventHandler(this.NewsPresenter_Load);
            this.Resize += new System.EventHandler(this.card_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBackImage;
        private TransparentLabelNew lblShadowLayer;
        private TransparentLabelNew lblTitle;
        private TransparentLabelNew lblDescription;
    }
}
