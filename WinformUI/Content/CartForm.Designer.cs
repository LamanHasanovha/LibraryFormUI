namespace WinformUI.Content
{
    partial class CartForm
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
            this.panelMain = new WinformUI.Infrastructure.CustomControls.TransparentTableLayoutPanel();
            this.panelContents = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.panelTotal = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.lblCart = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblTotal = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.btnProceed = new FontAwesome.Sharp.IconButton();
            this.panelMain.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.ColumnCount = 2;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelMain.Controls.Add(this.panelContents, 0, 0);
            this.panelMain.Controls.Add(this.panelTotal, 1, 0);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(10, 110);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 1;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Size = new System.Drawing.Size(1406, 743);
            this.panelMain.TabIndex = 0;
            // 
            // panelContents
            // 
            this.panelContents.AutoScroll = true;
            this.panelContents.BackColor = System.Drawing.Color.Transparent;
            this.panelContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContents.Location = new System.Drawing.Point(3, 3);
            this.panelContents.Name = "panelContents";
            this.panelContents.Size = new System.Drawing.Size(978, 737);
            this.panelContents.TabIndex = 1;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.Transparent;
            this.panelTotal.Controls.Add(this.btnProceed);
            this.panelTotal.Controls.Add(this.lblPrice);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotal.Location = new System.Drawing.Point(987, 3);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(416, 737);
            this.panelTotal.TabIndex = 0;
            // 
            // lblCart
            // 
            this.lblCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCart.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblCart.Location = new System.Drawing.Point(21, 13);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(419, 69);
            this.lblCart.TabIndex = 32;
            this.lblCart.TabStop = false;
            this.lblCart.Text = "Your items :";
            this.lblCart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblTotal.Location = new System.Drawing.Point(12, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(166, 59);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.TabStop = false;
            this.lblTotal.Text = "Total :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(218, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Opacity = 0;
            this.lblPrice.Size = new System.Drawing.Size(178, 59);
            this.lblPrice.TabIndex = 81;
            this.lblPrice.Text = "Price";
            this.lblPrice.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // btnProceed
            // 
            this.btnProceed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProceed.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnProceed.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProceed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProceed.IconSize = 33;
            this.btnProceed.Location = new System.Drawing.Point(69, 148);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(271, 52);
            this.btnProceed.TabIndex = 82;
            this.btnProceed.Text = "Proceed to checkout";
            this.btnProceed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 863);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Padding = new System.Windows.Forms.Padding(10, 110, 10, 10);
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infrastructure.CustomControls.TransparentTableLayoutPanel panelMain;
        private Infrastructure.CustomControls.TransparentPanel panelContents;
        private Infrastructure.CustomControls.TransparentPanel panelTotal;
        private Infrastructure.CustomControls.TransparentLabel lblCart;
        private Infrastructure.CustomControls.TransparentLabel lblTotal;
        private Infrastructure.CustomControls.TransparentLabelNew lblPrice;
        private FontAwesome.Sharp.IconButton btnProceed;
    }
}