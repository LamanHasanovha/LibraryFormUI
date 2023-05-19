namespace WinformUI.Content
{
    partial class AuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorForm));
            this.lblBirthDate = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblBorn = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxDescription = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.pcbImage = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.lblFullName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.basicSlider = new WinformUI.Infrastructure.CustomControls.BasicSlider();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBirthDate.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblBirthDate.Location = new System.Drawing.Point(718, 202);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(283, 68);
            this.lblBirthDate.TabIndex = 35;
            this.lblBirthDate.TabStop = false;
            this.lblBirthDate.Text = "BirthDate";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorn
            // 
            this.lblBorn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBorn.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblBorn.Location = new System.Drawing.Point(598, 202);
            this.lblBorn.Name = "lblBorn";
            this.lblBorn.Size = new System.Drawing.Size(114, 68);
            this.lblBorn.TabIndex = 34;
            this.lblBorn.TabStop = false;
            this.lblBorn.Text = "Born : ";
            this.lblBorn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderRadius = 0;
            this.tbxDescription.BorderSize = 2;
            this.tbxDescription.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxDescription.Location = new System.Drawing.Point(597, 288);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxDescription.PasswordChar = false;
            this.tbxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxDescription.PlaceholderText = "";
            this.tbxDescription.Size = new System.Drawing.Size(659, 346);
            this.tbxDescription.TabIndex = 33;
            this.tbxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDescription.Texts = resources.GetString("tbxDescription.Texts");
            this.tbxDescription.UnderlinedStyle = false;
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(149, 202);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(371, 432);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 32;
            this.pcbImage.TabStop = false;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFullName.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblFullName.Location = new System.Drawing.Point(105, 62);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(474, 134);
            this.lblFullName.TabIndex = 31;
            this.lblFullName.TabStop = false;
            this.lblFullName.Text = "Author Fullname";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // basicSlider
            // 
            this.basicSlider.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicSlider.Location = new System.Drawing.Point(105, 679);
            this.basicSlider.MinimumSize = new System.Drawing.Size(400, 300);
            this.basicSlider.Name = "basicSlider";
            this.basicSlider.Size = new System.Drawing.Size(1217, 346);
            this.basicSlider.TabIndex = 36;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1382, 1055);
            this.Controls.Add(this.basicSlider);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblBorn);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.lblFullName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorForm";
            this.Text = "DirectorForm";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infrastructure.CustomControls.TransparentLabel lblFullName;
        private Infrastructure.CustomControls.TransparentPictureBox pcbImage;
        private Infrastructure.CustomControls.DevTextBox tbxDescription;
        private Infrastructure.CustomControls.TransparentLabel lblBorn;
        private Infrastructure.CustomControls.TransparentLabel lblBirthDate;
        private Infrastructure.CustomControls.BasicSlider basicSlider;
    }
}