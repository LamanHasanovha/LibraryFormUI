namespace WinformUI.Infrastructure.CustomControls
{
    partial class CartItem
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
            this.pcbImage = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.tbxName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.lblProductType = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbImage
            // 
            this.pcbImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.Location = new System.Drawing.Point(13, 15);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(155, 178);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 1;
            this.pcbImage.TabStop = false;
            // 
            // tbxName
            // 
            this.tbxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxName.BorderColor = System.Drawing.SystemColors.Control;
            this.tbxName.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.tbxName.BorderRadius = 0;
            this.tbxName.BorderSize = 2;
            this.tbxName.Font = new System.Drawing.Font("Comic Sans MS", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxName.Location = new System.Drawing.Point(191, 15);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxName.PasswordChar = false;
            this.tbxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxName.PlaceholderText = "";
            this.tbxName.Readonly = true;
            this.tbxName.Size = new System.Drawing.Size(284, 153);
            this.tbxName.TabIndex = 2;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxName.Texts = "Title";
            this.tbxName.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(655, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Opacity = 0;
            this.lblPrice.Size = new System.Drawing.Size(180, 51);
            this.lblPrice.TabIndex = 81;
            this.lblPrice.Text = "Price";
            this.lblPrice.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnRemove.IconColor = System.Drawing.Color.Black;
            this.btnRemove.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRemove.IconSize = 30;
            this.btnRemove.Location = new System.Drawing.Point(800, 15);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 28);
            this.btnRemove.TabIndex = 82;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblProductType
            // 
            this.lblProductType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductType.BackColor = System.Drawing.Color.Transparent;
            this.lblProductType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.Gray;
            this.lblProductType.Location = new System.Drawing.Point(655, 142);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Opacity = 0;
            this.lblProductType.Size = new System.Drawing.Size(180, 51);
            this.lblProductType.TabIndex = 83;
            this.lblProductType.Text = "Product type";
            this.lblProductType.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.pcbImage);
            this.MinimumSize = new System.Drawing.Size(850, 210);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(850, 210);
            this.Load += new System.EventHandler(this.CartItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPictureBox pcbImage;
        private DevTextBox tbxName;
        private TransparentLabelNew lblPrice;
        private FontAwesome.Sharp.IconButton btnRemove;
        private TransparentLabelNew lblProductType;
    }
}
