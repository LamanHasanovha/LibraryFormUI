namespace WinformUI.Content
{
    partial class AccountEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountEditForm));
            this.lblEmail = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblUsername = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblLastname = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblFirstname = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.transparentLabel1 = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.lblPassword = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxFirstName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.tbxLastName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.tbxUserName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.tbxPassword = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.btnPass = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.lblEmailValue = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.btnChangeEmail = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblEmail.Location = new System.Drawing.Point(348, 567);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(327, 71);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.TabStop = false;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblUsername.Location = new System.Drawing.Point(348, 480);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(327, 71);
            this.lblUsername.TabIndex = 45;
            this.lblUsername.TabStop = false;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastname.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblLastname.Location = new System.Drawing.Point(348, 393);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(327, 71);
            this.lblLastname.TabIndex = 43;
            this.lblLastname.TabStop = false;
            this.lblLastname.Text = "Lastname";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstname
            // 
            this.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirstname.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblFirstname.Location = new System.Drawing.Point(348, 306);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(327, 71);
            this.lblFirstname.TabIndex = 41;
            this.lblFirstname.TabStop = false;
            this.lblFirstname.Text = "Firstname";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.transparentLabel1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.transparentLabel1.Location = new System.Drawing.Point(555, 227);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(336, 71);
            this.transparentLabel1.TabIndex = 40;
            this.transparentLabel1.TabStop = false;
            this.transparentLabel1.Text = "Profile";
            this.transparentLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(555, 17);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(336, 203);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 39;
            this.pcbLogo.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 40;
            this.btnSave.Location = new System.Drawing.Point(644, 759);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPassword.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblPassword.Location = new System.Drawing.Point(348, 654);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(327, 71);
            this.lblPassword.TabIndex = 48;
            this.lblPassword.TabStop = false;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxFirstName.BorderColor = System.Drawing.Color.Blue;
            this.tbxFirstName.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxFirstName.BorderRadius = 0;
            this.tbxFirstName.BorderSize = 2;
            this.tbxFirstName.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxFirstName.Location = new System.Drawing.Point(752, 315);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstName.Multiline = false;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxFirstName.PasswordChar = false;
            this.tbxFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxFirstName.PlaceholderText = "";
            this.tbxFirstName.Readonly = false;
            this.tbxFirstName.Size = new System.Drawing.Size(379, 62);
            this.tbxFirstName.TabIndex = 49;
            this.tbxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxFirstName.Texts = "";
            this.tbxFirstName.UnderlinedStyle = false;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxLastName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxLastName.BorderColor = System.Drawing.Color.Blue;
            this.tbxLastName.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxLastName.BorderRadius = 0;
            this.tbxLastName.BorderSize = 2;
            this.tbxLastName.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxLastName.Location = new System.Drawing.Point(752, 402);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastName.Multiline = false;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxLastName.PasswordChar = false;
            this.tbxLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxLastName.PlaceholderText = "";
            this.tbxLastName.Readonly = false;
            this.tbxLastName.Size = new System.Drawing.Size(379, 62);
            this.tbxLastName.TabIndex = 50;
            this.tbxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxLastName.Texts = "";
            this.tbxLastName.UnderlinedStyle = false;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxUserName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxUserName.BorderColor = System.Drawing.Color.Blue;
            this.tbxUserName.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxUserName.BorderRadius = 0;
            this.tbxUserName.BorderSize = 2;
            this.tbxUserName.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxUserName.Location = new System.Drawing.Point(752, 489);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUserName.Multiline = false;
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxUserName.PasswordChar = false;
            this.tbxUserName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUserName.PlaceholderText = "";
            this.tbxUserName.Readonly = false;
            this.tbxUserName.Size = new System.Drawing.Size(379, 62);
            this.tbxUserName.TabIndex = 51;
            this.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxUserName.Texts = "";
            this.tbxUserName.UnderlinedStyle = false;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Control;
            this.tbxPassword.BorderColor = System.Drawing.Color.Blue;
            this.tbxPassword.BorderFocusColor = System.Drawing.Color.Crimson;
            this.tbxPassword.BorderRadius = 0;
            this.tbxPassword.BorderSize = 2;
            this.tbxPassword.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxPassword.Location = new System.Drawing.Point(752, 663);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxPassword.PasswordChar = true;
            this.tbxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPassword.PlaceholderText = "";
            this.tbxPassword.Readonly = false;
            this.tbxPassword.Size = new System.Drawing.Size(379, 62);
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
            this.btnPass.IconSize = 40;
            this.btnPass.Location = new System.Drawing.Point(1161, 670);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(51, 45);
            this.btnPass.TabIndex = 54;
            this.btnPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 35;
            this.btnBack.Location = new System.Drawing.Point(1297, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 45);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmailValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblEmailValue.Location = new System.Drawing.Point(752, 576);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(379, 62);
            this.lblEmailValue.TabIndex = 56;
            this.lblEmailValue.TabStop = false;
            this.lblEmailValue.Text = "Email";
            this.lblEmailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChangeEmail.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangeEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeEmail.FlatAppearance.BorderSize = 0;
            this.btnChangeEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangeEmail.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnChangeEmail.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnChangeEmail.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnChangeEmail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChangeEmail.IconSize = 40;
            this.btnChangeEmail.Location = new System.Drawing.Point(1161, 584);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(51, 45);
            this.btnChangeEmail.TabIndex = 57;
            this.btnChangeEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeEmail.UseVisualStyleBackColor = false;
            this.btnChangeEmail.Click += new System.EventHandler(this.btnChangeEmail_Click);
            // 
            // AccountEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 840);
            this.Controls.Add(this.btnChangeEmail);
            this.Controls.Add(this.lblEmailValue);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountEditForm";
            this.Text = "AccountEditForm";
            this.Load += new System.EventHandler(this.AccountEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infrastructure.CustomControls.TransparentLabel lblEmail;
        private Infrastructure.CustomControls.TransparentLabel lblUsername;
        private Infrastructure.CustomControls.TransparentLabel lblLastname;
        private Infrastructure.CustomControls.TransparentLabel lblFirstname;
        private Infrastructure.CustomControls.TransparentLabel transparentLabel1;
        private System.Windows.Forms.PictureBox pcbLogo;
        private FontAwesome.Sharp.IconButton btnSave;
        private Infrastructure.CustomControls.TransparentLabel lblPassword;
        private Infrastructure.CustomControls.DevTextBox tbxFirstName;
        private Infrastructure.CustomControls.DevTextBox tbxLastName;
        private Infrastructure.CustomControls.DevTextBox tbxUserName;
        private Infrastructure.CustomControls.DevTextBox tbxPassword;
        private FontAwesome.Sharp.IconButton btnPass;
        private FontAwesome.Sharp.IconButton btnBack;
        private Infrastructure.CustomControls.TransparentLabel lblEmailValue;
        private FontAwesome.Sharp.IconButton btnChangeEmail;
    }
}