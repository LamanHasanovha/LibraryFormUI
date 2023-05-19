namespace WinformUI.AdminPanel
{
    partial class AccountAdminForm
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
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgwAccounts = new System.Windows.Forms.DataGridView();
            this.lblStatus = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxPassword = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblPassword = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxUsername = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblUsername = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxEmail = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblEmail = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxLastname = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblLastname = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxFirstname = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.transparentLabel1 = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Controls.Add(this.dgwAccounts);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(21, 22);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.panelGrid.Size = new System.Drawing.Size(983, 834);
            this.panelGrid.TabIndex = 0;
            // 
            // dgwAccounts
            // 
            this.dgwAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwAccounts.Location = new System.Drawing.Point(10, 12);
            this.dgwAccounts.Name = "dgwAccounts";
            this.dgwAccounts.RowHeadersWidth = 51;
            this.dgwAccounts.RowTemplate.Height = 24;
            this.dgwAccounts.Size = new System.Drawing.Size(963, 790);
            this.dgwAccounts.TabIndex = 0;
            this.dgwAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAccounts_CellClick);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStatus.Location = new System.Drawing.Point(1026, 501);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(224, 48);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.TabStop = false;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxPassword.BorderRadius = 0;
            this.tbxPassword.BorderSize = 1;
            this.tbxPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.Color.Black;
            this.tbxPassword.Location = new System.Drawing.Point(1304, 417);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxPassword.Multiline = false;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxPassword.PasswordChar = false;
            this.tbxPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPassword.PlaceholderText = "";
            this.tbxPassword.Size = new System.Drawing.Size(330, 38);
            this.tbxPassword.TabIndex = 10;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPassword.Texts = "";
            this.tbxPassword.UnderlinedStyle = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(1026, 407);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(224, 48);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.TabStop = false;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.tbxUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxUsername.BorderRadius = 0;
            this.tbxUsername.BorderSize = 1;
            this.tbxUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsername.ForeColor = System.Drawing.Color.Black;
            this.tbxUsername.Location = new System.Drawing.Point(1304, 330);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxUsername.Multiline = false;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxUsername.PasswordChar = false;
            this.tbxUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxUsername.PlaceholderText = "";
            this.tbxUsername.Size = new System.Drawing.Size(330, 38);
            this.tbxUsername.TabIndex = 8;
            this.tbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxUsername.Texts = "";
            this.tbxUsername.UnderlinedStyle = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(1026, 320);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(224, 48);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.TabStop = false;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbxEmail.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxEmail.BorderRadius = 0;
            this.tbxEmail.BorderSize = 1;
            this.tbxEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.ForeColor = System.Drawing.Color.Black;
            this.tbxEmail.Location = new System.Drawing.Point(1304, 239);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxEmail.Multiline = false;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxEmail.PasswordChar = false;
            this.tbxEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxEmail.PlaceholderText = "";
            this.tbxEmail.Size = new System.Drawing.Size(330, 38);
            this.tbxEmail.TabIndex = 6;
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxEmail.Texts = "";
            this.tbxEmail.UnderlinedStyle = false;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(1026, 229);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(224, 48);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.TabStop = false;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxLastname
            // 
            this.tbxLastname.BackColor = System.Drawing.SystemColors.Window;
            this.tbxLastname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxLastname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxLastname.BorderRadius = 0;
            this.tbxLastname.BorderSize = 1;
            this.tbxLastname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastname.ForeColor = System.Drawing.Color.Black;
            this.tbxLastname.Location = new System.Drawing.Point(1304, 147);
            this.tbxLastname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxLastname.Multiline = false;
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxLastname.PasswordChar = false;
            this.tbxLastname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxLastname.PlaceholderText = "";
            this.tbxLastname.Size = new System.Drawing.Size(330, 38);
            this.tbxLastname.TabIndex = 4;
            this.tbxLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxLastname.Texts = "";
            this.tbxLastname.UnderlinedStyle = false;
            // 
            // lblLastname
            // 
            this.lblLastname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLastname.Location = new System.Drawing.Point(1026, 142);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(224, 48);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.TabStop = false;
            this.lblLastname.Text = "Lastname";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFirstname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxFirstname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxFirstname.BorderRadius = 0;
            this.tbxFirstname.BorderSize = 1;
            this.tbxFirstname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstname.ForeColor = System.Drawing.Color.Black;
            this.tbxFirstname.Location = new System.Drawing.Point(1304, 66);
            this.tbxFirstname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxFirstname.Multiline = false;
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.tbxFirstname.PasswordChar = false;
            this.tbxFirstname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxFirstname.PlaceholderText = "";
            this.tbxFirstname.Size = new System.Drawing.Size(330, 38);
            this.tbxFirstname.TabIndex = 2;
            this.tbxFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxFirstname.Texts = "";
            this.tbxFirstname.UnderlinedStyle = true;
            // 
            // transparentLabel1
            // 
            this.transparentLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.transparentLabel1.Location = new System.Drawing.Point(1026, 55);
            this.transparentLabel1.Name = "transparentLabel1";
            this.transparentLabel1.Size = new System.Drawing.Size(224, 48);
            this.transparentLabel1.TabIndex = 1;
            this.transparentLabel1.TabStop = false;
            this.transparentLabel1.Text = "Firstname";
            this.transparentLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStatus.Location = new System.Drawing.Point(1304, 519);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(18, 17);
            this.chkStatus.TabIndex = 12;
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAdd.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 32;
            this.btnAdd.Location = new System.Drawing.Point(1026, 635);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 68);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnUpdate.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 32;
            this.btnUpdate.Location = new System.Drawing.Point(1230, 635);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 68);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.btnDelete.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 32;
            this.btnDelete.Location = new System.Drawing.Point(1442, 635);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 68);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
            this.btnReset.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 32;
            this.btnReset.Location = new System.Drawing.Point(1026, 731);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(192, 68);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // AccountAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 878);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.tbxFirstname);
            this.Controls.Add(this.transparentLabel1);
            this.Controls.Add(this.panelGrid);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountAdminForm";
            this.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.Text = "AccountAdminForm";
            this.Load += new System.EventHandler(this.AccountAdminForm_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgwAccounts;
        private Infrastructure.CustomControls.TransparentLabel transparentLabel1;
        private Infrastructure.CustomControls.DevTextBox tbxFirstname;
        private Infrastructure.CustomControls.TransparentLabel lblLastname;
        private Infrastructure.CustomControls.DevTextBox tbxLastname;
        private Infrastructure.CustomControls.TransparentLabel lblEmail;
        private Infrastructure.CustomControls.DevTextBox tbxEmail;
        private Infrastructure.CustomControls.DevTextBox tbxUsername;
        private Infrastructure.CustomControls.TransparentLabel lblUsername;
        private Infrastructure.CustomControls.DevTextBox tbxPassword;
        private Infrastructure.CustomControls.TransparentLabel lblPassword;
        private Infrastructure.CustomControls.TransparentLabel lblStatus;
        private System.Windows.Forms.CheckBox chkStatus;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReset;
    }
}