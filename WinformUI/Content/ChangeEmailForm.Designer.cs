namespace WinformUI.Content
{
    partial class ChangeEmailForm
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
            this.tbxEmail = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.tbxPassword = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.btnPass = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnChange = new FontAwesome.Sharp.IconButton();
            this.tbxCode = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblTimer = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbxEmail
            // 
            this.tbxEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tbxEmail.BorderColor = System.Drawing.SystemColors.Control;
            this.tbxEmail.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxEmail.BorderRadius = 0;
            this.tbxEmail.BorderSize = 2;
            this.tbxEmail.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxEmail.Location = new System.Drawing.Point(39, 69);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmail.Multiline = false;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxEmail.PasswordChar = false;
            this.tbxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxEmail.PlaceholderText = "New email...";
            this.tbxEmail.Readonly = false;
            this.tbxEmail.Size = new System.Drawing.Size(502, 49);
            this.tbxEmail.TabIndex = 52;
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxEmail.Texts = "";
            this.tbxEmail.UnderlinedStyle = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPassword.BorderColor = System.Drawing.SystemColors.Control;
            this.tbxPassword.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxPassword.BorderRadius = 0;
            this.tbxPassword.BorderSize = 2;
            this.tbxPassword.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxPassword.Location = new System.Drawing.Point(39, 135);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxPassword.PasswordChar = true;
            this.tbxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPassword.PlaceholderText = "Your password";
            this.tbxPassword.Readonly = false;
            this.tbxPassword.Size = new System.Drawing.Size(502, 49);
            this.tbxPassword.TabIndex = 53;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.Texts = "";
            this.tbxPassword.UnderlinedStyle = false;
            // 
            // btnPass
            // 
            this.btnPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPass.BackColor = System.Drawing.SystemColors.Control;
            this.btnPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPass.FlatAppearance.BorderSize = 0;
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPass.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnPass.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnPass.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnPass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPass.IconSize = 35;
            this.btnPass.Location = new System.Drawing.Point(548, 143);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(51, 45);
            this.btnPass.TabIndex = 55;
            this.btnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
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
            this.btnClose.Location = new System.Drawing.Point(588, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnChange.Location = new System.Drawing.Point(473, 276);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 45);
            this.btnChange.TabIndex = 56;
            this.btnChange.Text = "Change";
            this.btnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
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
            this.tbxCode.Location = new System.Drawing.Point(39, 199);
            this.tbxCode.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCode.Multiline = false;
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxCode.PasswordChar = true;
            this.tbxCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxCode.PlaceholderText = "Enter code sent to email";
            this.tbxCode.Readonly = false;
            this.tbxCode.Size = new System.Drawing.Size(502, 49);
            this.tbxCode.TabIndex = 57;
            this.tbxCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCode.Texts = "";
            this.tbxCode.UnderlinedStyle = false;
            this.tbxCode.Visible = false;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimer.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblTimer.Location = new System.Drawing.Point(313, 276);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(154, 45);
            this.lblTimer.TabIndex = 58;
            this.lblTimer.TabStop = false;
            this.lblTimer.Text = "Time";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ChangeEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 333);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.tbxCode);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeEmailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeEmailForm";
            this.Load += new System.EventHandler(this.ChangeEmailForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnClose;
        private Infrastructure.CustomControls.DevTextBox tbxEmail;
        private Infrastructure.CustomControls.DevTextBox tbxPassword;
        private FontAwesome.Sharp.IconButton btnPass;
        private FontAwesome.Sharp.IconButton btnChange;
        private Infrastructure.CustomControls.DevTextBox tbxCode;
        private Infrastructure.CustomControls.TransparentLabel lblTimer;
        private System.Windows.Forms.Timer timer;
    }
}