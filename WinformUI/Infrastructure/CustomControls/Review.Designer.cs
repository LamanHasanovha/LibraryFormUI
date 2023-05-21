namespace WinformUI.Infrastructure.CustomControls
{
    partial class ReviewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewItem));
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelReview = new System.Windows.Forms.Panel();
            this.lblDate = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblUsername = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.pcbImage = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.lblReview = new WinformUI.Infrastructure.CustomControls.GrowLabel();
            this.panelMain.SuspendLayout();
            this.panelReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.ColumnCount = 2;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Controls.Add(this.pcbImage, 0, 0);
            this.panelMain.Controls.Add(this.panelReview, 1, 0);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 1;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Size = new System.Drawing.Size(400, 85);
            this.panelMain.TabIndex = 0;
            // 
            // panelReview
            // 
            this.panelReview.Controls.Add(this.lblReview);
            this.panelReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReview.Location = new System.Drawing.Point(103, 3);
            this.panelReview.Name = "panelReview";
            this.panelReview.Size = new System.Drawing.Size(294, 79);
            this.panelReview.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(311, 95);
            this.lblDate.Name = "lblDate";
            this.lblDate.Opacity = 0;
            this.lblDate.Size = new System.Drawing.Size(87, 20);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "20.09.2023";
            this.lblDate.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblUsername.Location = new System.Drawing.Point(3, 91);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Opacity = 0;
            this.lblUsername.Size = new System.Drawing.Size(99, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(3, 3);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(94, 74);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 1;
            this.pcbImage.TabStop = false;
            // 
            // lblReview
            // 
            this.lblReview.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblReview.Location = new System.Drawing.Point(0, 0);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(294, 26);
            this.lblReview.TabIndex = 3;
            this.lblReview.Text = "User review";
            // 
            // ReviewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(400, 110);
            this.Name = "ReviewItem";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 30);
            this.Size = new System.Drawing.Size(400, 120);
            this.panelMain.ResumeLayout(false);
            this.panelReview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMain;
        private TransparentPictureBox pcbImage;
        private System.Windows.Forms.Panel panelReview;
        private GrowLabel lblReview;
        private TransparentLabelNew lblUsername;
        private TransparentLabelNew lblDate;
    }
}
