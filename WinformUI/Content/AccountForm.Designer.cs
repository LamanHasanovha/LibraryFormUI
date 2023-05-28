namespace WinformUI.Content
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.transparentLabel1 = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblFirstname = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblFirstnameValue = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblLastnameValue = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblLastname = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblUsernameValue = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblUsername = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblEmailValue = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblEmail = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEdit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 40;
            this.btnEdit.Location = new System.Drawing.Point(636, 735);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 45);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(547, 12);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(336, 203);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogo.TabIndex = 28;
            this.pcbLogo.TabStop = false;
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.transparentLabel1.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.transparentLabel1.Location = new System.Drawing.Point(547, 221);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(336, 71);
            this.transparentLabel1.TabIndex = 29;
            this.transparentLabel1.TabStop = false;
            this.transparentLabel1.Text = "Profile";
            this.transparentLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstname
            // 
            this.lblFirstname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirstname.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblFirstname.Location = new System.Drawing.Point(340, 328);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(327, 71);
            this.lblFirstname.TabIndex = 30;
            this.lblFirstname.TabStop = false;
            this.lblFirstname.Text = "Firstname";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstnameValue
            // 
            this.lblFirstnameValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFirstnameValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstnameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblFirstnameValue.Location = new System.Drawing.Point(723, 328);
            this.lblFirstnameValue.Name = "lblFirstnameValue";
            this.lblFirstnameValue.Size = new System.Drawing.Size(473, 71);
            this.lblFirstnameValue.TabIndex = 31;
            this.lblFirstnameValue.TabStop = false;
            this.lblFirstnameValue.Text = "Firstname value";
            this.lblFirstnameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastnameValue
            // 
            this.lblLastnameValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastnameValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastnameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblLastnameValue.Location = new System.Drawing.Point(723, 415);
            this.lblLastnameValue.Name = "lblLastnameValue";
            this.lblLastnameValue.Size = new System.Drawing.Size(473, 71);
            this.lblLastnameValue.TabIndex = 33;
            this.lblLastnameValue.TabStop = false;
            this.lblLastnameValue.Text = "Lastname value";
            this.lblLastnameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastname
            // 
            this.lblLastname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastname.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblLastname.Location = new System.Drawing.Point(340, 415);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(327, 71);
            this.lblLastname.TabIndex = 32;
            this.lblLastname.TabStop = false;
            this.lblLastname.Text = "Lastname";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsernameValue
            // 
            this.lblUsernameValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsernameValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblUsernameValue.Location = new System.Drawing.Point(723, 512);
            this.lblUsernameValue.Name = "lblUsernameValue";
            this.lblUsernameValue.Size = new System.Drawing.Size(473, 71);
            this.lblUsernameValue.TabIndex = 35;
            this.lblUsernameValue.TabStop = false;
            this.lblUsernameValue.Text = "Username value";
            this.lblUsernameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblUsername.Location = new System.Drawing.Point(340, 512);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(327, 71);
            this.lblUsername.TabIndex = 34;
            this.lblUsername.TabStop = false;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmailValue.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblEmailValue.Location = new System.Drawing.Point(723, 601);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(473, 71);
            this.lblEmailValue.TabIndex = 37;
            this.lblEmailValue.TabStop = false;
            this.lblEmailValue.Text = "Email";
            this.lblEmailValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblEmail.Location = new System.Drawing.Point(340, 601);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(327, 71);
            this.lblEmail.TabIndex = 36;
            this.lblEmail.TabStop = false;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1394, 845);
            this.Controls.Add(this.lblEmailValue);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsernameValue);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLastnameValue);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblFirstnameValue);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.btnEdit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.PictureBox pcbLogo;
        private Infrastructure.CustomControls.TransparentLabel transparentLabel1;
        private Infrastructure.CustomControls.TransparentLabel lblFirstname;
        private Infrastructure.CustomControls.TransparentLabel lblFirstnameValue;
        private Infrastructure.CustomControls.TransparentLabel lblLastnameValue;
        private Infrastructure.CustomControls.TransparentLabel lblLastname;
        private Infrastructure.CustomControls.TransparentLabel lblUsernameValue;
        private Infrastructure.CustomControls.TransparentLabel lblUsername;
        private Infrastructure.CustomControls.TransparentLabel lblEmailValue;
        private Infrastructure.CustomControls.TransparentLabel lblEmail;
    }
}