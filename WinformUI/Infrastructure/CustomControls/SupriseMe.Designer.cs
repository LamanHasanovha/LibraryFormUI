namespace WinformUI.Infrastructure.CustomControls
{
    partial class SupriseMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupriseMe));
            this.lblQuestion = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.btnSupriseMe = new WinformUI.Infrastructure.CustomControls.DevButton();
            this.pcbImage = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.panelContent = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.btnShow = new WinformUI.Infrastructure.CustomControls.DevButton();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblGenres = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblTitle = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.pcbContentImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Comic Sans MS", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(320, 342);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Opacity = 10;
            this.lblQuestion.Size = new System.Drawing.Size(490, 70);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "What will you explore next?";
            this.lblQuestion.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // btnSupriseMe
            // 
            this.btnSupriseMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSupriseMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(152)))), ((int)(((byte)(199)))));
            this.btnSupriseMe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(152)))), ((int)(((byte)(199)))));
            this.btnSupriseMe.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnSupriseMe.BorderRadius = 10;
            this.btnSupriseMe.BorderSize = 0;
            this.btnSupriseMe.FlatAppearance.BorderSize = 0;
            this.btnSupriseMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupriseMe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupriseMe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSupriseMe.Location = new System.Drawing.Point(430, 425);
            this.btnSupriseMe.Name = "btnSupriseMe";
            this.btnSupriseMe.Size = new System.Drawing.Size(270, 60);
            this.btnSupriseMe.TabIndex = 1;
            this.btnSupriseMe.Text = "SUPRISE ME";
            this.btnSupriseMe.TextColor = System.Drawing.Color.Gainsboro;
            this.btnSupriseMe.UseVisualStyleBackColor = false;
            this.btnSupriseMe.Click += new System.EventHandler(this.btnSupriseMe_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(340, 6);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(450, 315);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 2;
            this.pcbImage.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.btnShow);
            this.panelContent.Controls.Add(this.lblPrice);
            this.panelContent.Controls.Add(this.lblGenres);
            this.panelContent.Controls.Add(this.lblTitle);
            this.panelContent.Controls.Add(this.pcbContentImage);
            this.panelContent.Location = new System.Drawing.Point(201, 6);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(760, 350);
            this.panelContent.TabIndex = 3;
            this.panelContent.Visible = false;
            // 
            // btnShow
            // 
            this.btnShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.BackgroundColor = System.Drawing.Color.White;
            this.btnShow.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnShow.BorderRadius = 10;
            this.btnShow.BorderSize = 0;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(152)))), ((int)(((byte)(199)))));
            this.btnShow.Location = new System.Drawing.Point(611, 214);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(123, 97);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(152)))), ((int)(((byte)(199)))));
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPrice.Location = new System.Drawing.Point(311, 215);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Opacity = 0;
            this.lblPrice.Size = new System.Drawing.Size(188, 121);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "10";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.TransparentBackColor = System.Drawing.Color.Black;
            this.lblPrice.UseMnemonic = false;
            // 
            // lblGenres
            // 
            this.lblGenres.BackColor = System.Drawing.Color.Transparent;
            this.lblGenres.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGenres.Location = new System.Drawing.Point(245, 140);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Opacity = 40;
            this.lblGenres.Size = new System.Drawing.Size(512, 50);
            this.lblGenres.TabIndex = 3;
            this.lblGenres.Text = "Genres";
            this.lblGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGenres.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(245, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Opacity = 40;
            this.lblTitle.Size = new System.Drawing.Size(512, 105);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // pcbContentImage
            // 
            this.pcbContentImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbContentImage.Image")));
            this.pcbContentImage.Location = new System.Drawing.Point(11, 8);
            this.pcbContentImage.Name = "pcbContentImage";
            this.pcbContentImage.Size = new System.Drawing.Size(225, 330);
            this.pcbContentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbContentImage.TabIndex = 1;
            this.pcbContentImage.TabStop = false;
            // 
            // SupriseMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.btnSupriseMe);
            this.Controls.Add(this.lblQuestion);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(2000, 520);
            this.MinimumSize = new System.Drawing.Size(490, 520);
            this.Name = "SupriseMe";
            this.Size = new System.Drawing.Size(1130, 520);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SupriseMe_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbContentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentLabelNew lblQuestion;
        private DevButton btnSupriseMe;
        private TransparentPictureBox pcbImage;
        private TransparentPanel panelContent;
        private System.Windows.Forms.PictureBox pcbContentImage;
        private TransparentLabelNew lblTitle;
        private DevButton btnShow;
        private TransparentLabelNew lblPrice;
        private TransparentLabelNew lblGenres;
    }
}
