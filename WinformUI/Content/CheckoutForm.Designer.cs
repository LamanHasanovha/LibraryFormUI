namespace WinformUI.Content
{
    partial class CheckoutForm
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
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelCardDetails = new System.Windows.Forms.Panel();
            this.panelOrderSummary = new System.Windows.Forms.Panel();
            this.tbxCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbxExpDate = new System.Windows.Forms.MaskedTextBox();
            this.tbxCVV = new System.Windows.Forms.MaskedTextBox();
            this.panelDivider1 = new System.Windows.Forms.Panel();
            this.panelOrders = new System.Windows.Forms.Panel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.btnCard = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnPay = new FontAwesome.Sharp.IconButton();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblTotal = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblYourOrder = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblNote = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblCVV = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblExpDate = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblCardNumber = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblCardDetails = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelMain.SuspendLayout();
            this.panelCardDetails.SuspendLayout();
            this.panelOrderSummary.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.ColumnCount = 2;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.67949F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.32051F));
            this.panelMain.Controls.Add(this.panelOrderSummary, 1, 0);
            this.panelMain.Controls.Add(this.panelCardDetails, 0, 0);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 1;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 704F));
            this.panelMain.Size = new System.Drawing.Size(936, 704);
            this.panelMain.TabIndex = 6;
            // 
            // panelCardDetails
            // 
            this.panelCardDetails.Controls.Add(this.btnPay);
            this.panelCardDetails.Controls.Add(this.lblNote);
            this.panelCardDetails.Controls.Add(this.tbxCVV);
            this.panelCardDetails.Controls.Add(this.tbxExpDate);
            this.panelCardDetails.Controls.Add(this.lblCVV);
            this.panelCardDetails.Controls.Add(this.lblExpDate);
            this.panelCardDetails.Controls.Add(this.tbxCardNumber);
            this.panelCardDetails.Controls.Add(this.lblCardNumber);
            this.panelCardDetails.Controls.Add(this.btnCard);
            this.panelCardDetails.Controls.Add(this.lblCardDetails);
            this.panelCardDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardDetails.Location = new System.Drawing.Point(3, 3);
            this.panelCardDetails.Name = "panelCardDetails";
            this.panelCardDetails.Size = new System.Drawing.Size(459, 698);
            this.panelCardDetails.TabIndex = 0;
            this.panelCardDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            // 
            // panelOrderSummary
            // 
            this.panelOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(26)))));
            this.panelOrderSummary.Controls.Add(this.btnClose);
            this.panelOrderSummary.Controls.Add(this.panelTotal);
            this.panelOrderSummary.Controls.Add(this.panelOrders);
            this.panelOrderSummary.Controls.Add(this.panelDivider1);
            this.panelOrderSummary.Controls.Add(this.lblYourOrder);
            this.panelOrderSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrderSummary.Location = new System.Drawing.Point(468, 3);
            this.panelOrderSummary.Name = "panelOrderSummary";
            this.panelOrderSummary.Size = new System.Drawing.Size(465, 698);
            this.panelOrderSummary.TabIndex = 1;
            // 
            // tbxCardNumber
            // 
            this.tbxCardNumber.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCardNumber.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCardNumber.ForeColor = System.Drawing.Color.Gray;
            this.tbxCardNumber.Location = new System.Drawing.Point(49, 239);
            this.tbxCardNumber.Mask = "0000 0000 0000 0000";
            this.tbxCardNumber.Name = "tbxCardNumber";
            this.tbxCardNumber.PromptChar = '-';
            this.tbxCardNumber.Size = new System.Drawing.Size(305, 35);
            this.tbxCardNumber.TabIndex = 9;
            this.tbxCardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxExpDate
            // 
            this.tbxExpDate.BackColor = System.Drawing.SystemColors.Control;
            this.tbxExpDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxExpDate.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExpDate.ForeColor = System.Drawing.Color.Gray;
            this.tbxExpDate.Location = new System.Drawing.Point(49, 335);
            this.tbxExpDate.Mask = "00/00";
            this.tbxExpDate.Name = "tbxExpDate";
            this.tbxExpDate.PromptChar = '-';
            this.tbxExpDate.Size = new System.Drawing.Size(121, 35);
            this.tbxExpDate.TabIndex = 12;
            this.tbxExpDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxExpDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbxCVV
            // 
            this.tbxCVV.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCVV.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCVV.ForeColor = System.Drawing.Color.Gray;
            this.tbxCVV.Location = new System.Drawing.Point(239, 335);
            this.tbxCVV.Mask = "000";
            this.tbxCVV.Name = "tbxCVV";
            this.tbxCVV.PromptChar = '-';
            this.tbxCVV.Size = new System.Drawing.Size(128, 35);
            this.tbxCVV.TabIndex = 13;
            this.tbxCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCVV.ValidatingType = typeof(int);
            // 
            // panelDivider1
            // 
            this.panelDivider1.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDivider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDivider1.Location = new System.Drawing.Point(0, 133);
            this.panelDivider1.Name = "panelDivider1";
            this.panelDivider1.Size = new System.Drawing.Size(465, 3);
            this.panelDivider1.TabIndex = 8;
            // 
            // panelOrders
            // 
            this.panelOrders.AutoScroll = true;
            this.panelOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrders.Location = new System.Drawing.Point(0, 136);
            this.panelOrders.Name = "panelOrders";
            this.panelOrders.Size = new System.Drawing.Size(465, 562);
            this.panelOrders.TabIndex = 9;
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.lblPrice);
            this.panelTotal.Controls.Add(this.lblTotal);
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTotal.Location = new System.Drawing.Point(0, 575);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(465, 123);
            this.panelTotal.TabIndex = 10;
            // 
            // btnCard
            // 
            this.btnCard.FlatAppearance.BorderSize = 0;
            this.btnCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCard.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btnCard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCard.IconSize = 65;
            this.btnCard.Location = new System.Drawing.Point(49, 82);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(66, 51);
            this.btnCard.TabIndex = 7;
            this.btnCard.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(414, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 40);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPay.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.btnPay.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPay.IconSize = 45;
            this.btnPay.Location = new System.Drawing.Point(48, 438);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(169, 65);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Pay now";
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrice.Location = new System.Drawing.Point(330, 38);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Opacity = 0;
            this.lblPrice.Size = new System.Drawing.Size(85, 40);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            this.lblPrice.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Comic Sans MS", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(34, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Opacity = 0;
            this.lblTotal.Size = new System.Drawing.Size(89, 40);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            this.lblTotal.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblYourOrder
            // 
            this.lblYourOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblYourOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYourOrder.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblYourOrder.Location = new System.Drawing.Point(0, 0);
            this.lblYourOrder.Name = "lblYourOrder";
            this.lblYourOrder.Opacity = 0;
            this.lblYourOrder.Size = new System.Drawing.Size(465, 133);
            this.lblYourOrder.TabIndex = 7;
            this.lblYourOrder.Text = "Your order         ";
            this.lblYourOrder.TransparentBackColor = System.Drawing.Color.Black;
            this.lblYourOrder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblNote.Location = new System.Drawing.Point(9, 601);
            this.lblNote.Name = "lblNote";
            this.lblNote.Opacity = 0;
            this.lblNote.Size = new System.Drawing.Size(401, 60);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "We don\'t store your card information\r\ndue to terms of use.";
            this.lblNote.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.BackColor = System.Drawing.Color.Transparent;
            this.lblCVV.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblCVV.Location = new System.Drawing.Point(261, 290);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Opacity = 0;
            this.lblCVV.Size = new System.Drawing.Size(54, 30);
            this.lblCVV.TabIndex = 11;
            this.lblCVV.Text = "CVV";
            this.lblCVV.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.BackColor = System.Drawing.Color.Transparent;
            this.lblExpDate.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblExpDate.Location = new System.Drawing.Point(43, 290);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Opacity = 0;
            this.lblExpDate.Size = new System.Drawing.Size(122, 30);
            this.lblExpDate.TabIndex = 10;
            this.lblExpDate.Text = "EXP DATE";
            this.lblExpDate.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblCardNumber.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblCardNumber.Location = new System.Drawing.Point(43, 201);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Opacity = 0;
            this.lblCardNumber.Size = new System.Drawing.Size(174, 30);
            this.lblCardNumber.TabIndex = 8;
            this.lblCardNumber.Text = "CARD NUMBER";
            this.lblCardNumber.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblCardDetails
            // 
            this.lblCardDetails.AutoSize = true;
            this.lblCardDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblCardDetails.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblCardDetails.Location = new System.Drawing.Point(113, 82);
            this.lblCardDetails.Name = "lblCardDetails";
            this.lblCardDetails.Opacity = 0;
            this.lblCardDetails.Size = new System.Drawing.Size(241, 51);
            this.lblCardDetails.TabIndex = 6;
            this.lblCardDetails.Text = "Card details";
            this.lblCardDetails.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 704);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelCardDetails.ResumeLayout(false);
            this.panelCardDetails.PerformLayout();
            this.panelOrderSummary.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.Panel panelOrderSummary;
        private System.Windows.Forms.Panel panelCardDetails;
        private System.Windows.Forms.MaskedTextBox tbxCVV;
        private System.Windows.Forms.MaskedTextBox tbxExpDate;
        private Infrastructure.CustomControls.TransparentLabelNew lblCVV;
        private Infrastructure.CustomControls.TransparentLabelNew lblExpDate;
        private System.Windows.Forms.MaskedTextBox tbxCardNumber;
        private Infrastructure.CustomControls.TransparentLabelNew lblCardNumber;
        private FontAwesome.Sharp.IconButton btnCard;
        private Infrastructure.CustomControls.TransparentLabelNew lblCardDetails;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelOrders;
        private System.Windows.Forms.Panel panelDivider1;
        private Infrastructure.CustomControls.TransparentLabelNew lblYourOrder;
        private Infrastructure.CustomControls.TransparentLabelNew lblPrice;
        private Infrastructure.CustomControls.TransparentLabelNew lblTotal;
        private Infrastructure.CustomControls.TransparentLabelNew lblNote;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnPay;
    }
}