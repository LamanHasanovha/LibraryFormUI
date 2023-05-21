namespace WinformUI.Content
{
    partial class SignUpConfirmForm
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tbxCode = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblTimer = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.btnChange = new FontAwesome.Sharp.IconButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(465, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tbxCode
            // 
            this.tbxCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxCode.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCode.BorderColor = System.Drawing.SystemColors.Control;
            this.tbxCode.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxCode.BorderRadius = 0;
            this.tbxCode.BorderSize = 2;
            this.tbxCode.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxCode.Location = new System.Drawing.Point(63, 76);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCode.Multiline = false;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxCode.PasswordChar = true;
            this.tbxCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxCode.PlaceholderText = "Enter code sent to email";
            this.tbxCode.Readonly = false;
            this.tbxCode.Size = new System.Drawing.Size(361, 49);
            this.tbxCode.TabIndex = 58;
            this.tbxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCode.Texts = "";
            this.tbxCode.UnderlinedStyle = false;
            this.tbxCode.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblTimer.Location = new System.Drawing.Point(189, 174);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(154, 45);
            this.lblTimer.TabIndex = 60;
            this.lblTimer.TabStop = false;
            this.lblTimer.Text = "Time";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Visible = false;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChange.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnChange.IconColor = System.Drawing.Color.Gainsboro;
            this.btnChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChange.IconSize = 40;
            this.btnChange.Location = new System.Drawing.Point(349, 174);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 45);
            this.btnChange.TabIndex = 59;
            this.btnChange.Text = "Submit";
            this.btnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // SignUpConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 250);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpConfirmForm";
            this.Load += new System.EventHandler(this.SignUpConfirmForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private Infrastructure.CustomControls.DevTextBox tbxCode;
        private Infrastructure.CustomControls.TransparentLabel lblTimer;
        private FontAwesome.Sharp.IconButton btnChange;
        private System.Windows.Forms.Timer timer;
    }
}