namespace WinformUI.Infrastructure.CustomControls
{
    partial class WishListItem
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
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnAddToCart = new FontAwesome.Sharp.IconButton();
            this.tbxDescription = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.tbxName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.pcbImage = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
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
            this.btnRemove.Location = new System.Drawing.Point(796, 16);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(35, 28);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddToCart.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAddToCart.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddToCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddToCart.IconSize = 33;
            this.btnAddToCart.Location = new System.Drawing.Point(601, 128);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(230, 52);
            this.btnAddToCart.TabIndex = 79;
            this.btnAddToCart.Text = "Remove from cart";
            this.btnAddToCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderRadius = 0;
            this.tbxDescription.BorderSize = 2;
            this.tbxDescription.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.ForeColor = System.Drawing.Color.Gray;
            this.tbxDescription.Location = new System.Drawing.Point(209, 99);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxDescription.PasswordChar = false;
            this.tbxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxDescription.PlaceholderText = "";
            this.tbxDescription.Readonly = true;
            this.tbxDescription.Size = new System.Drawing.Size(363, 96);
            this.tbxDescription.TabIndex = 2;
            this.tbxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDescription.Texts = "Description";
            this.tbxDescription.UnderlinedStyle = false;
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
            this.tbxName.Location = new System.Drawing.Point(209, 31);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Multiline = false;
            this.tbxName.Name = "tbxName";
            this.tbxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxName.PasswordChar = false;
            this.tbxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxName.PlaceholderText = "";
            this.tbxName.Readonly = true;
            this.tbxName.Size = new System.Drawing.Size(363, 60);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxName.Texts = "Title";
            this.tbxName.UnderlinedStyle = false;
            // 
            // pcbImage
            // 
            this.pcbImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.Location = new System.Drawing.Point(15, 16);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(155, 178);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(630, 62);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Opacity = 0;
            this.lblPrice.Size = new System.Drawing.Size(201, 51);
            this.lblPrice.TabIndex = 80;
            this.lblPrice.Text = "Price";
            this.lblPrice.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // WishListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.pcbImage);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.MinimumSize = new System.Drawing.Size(850, 210);
            this.Name = "WishListItem";
            this.Size = new System.Drawing.Size(850, 210);
            this.Load += new System.EventHandler(this.WishListItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentPictureBox pcbImage;
        private DevTextBox tbxName;
        private DevTextBox tbxDescription;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnAddToCart;
        private TransparentLabelNew lblPrice;
    }
}
