﻿namespace WinformUI.Infrastructure.CustomControls
{
    partial class NewsCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsCard));
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblTitle = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(0, 0);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(250, 330);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            this.pcbImage.Click += new System.EventHandler(this.card_Click);
            this.pcbImage.MouseLeave += new System.EventHandler(this.card_MouseLeave);
            this.pcbImage.MouseHover += new System.EventHandler(this.card_MouseHover);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Location = new System.Drawing.Point(0, 282);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Opacity = 190;
            this.lblDescription.Size = new System.Drawing.Size(250, 48);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.TransparentBackColor = System.Drawing.Color.Black;
            this.lblDescription.Click += new System.EventHandler(this.card_Click);
            this.lblDescription.MouseLeave += new System.EventHandler(this.card_MouseLeave);
            this.lblDescription.MouseHover += new System.EventHandler(this.card_MouseHover);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(0, 235);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Opacity = 190;
            this.lblTitle.Size = new System.Drawing.Size(250, 47);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TransparentBackColor = System.Drawing.Color.Black;
            this.lblTitle.Click += new System.EventHandler(this.card_Click);
            this.lblTitle.MouseLeave += new System.EventHandler(this.card_MouseLeave);
            this.lblTitle.MouseHover += new System.EventHandler(this.card_MouseHover);
            // 
            // NewsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pcbImage);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(250, 330);
            this.Name = "NewsCard";
            this.Size = new System.Drawing.Size(250, 330);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbImage;
        private TransparentLabelNew lblDescription;
        private TransparentLabelNew lblTitle;
    }
}
