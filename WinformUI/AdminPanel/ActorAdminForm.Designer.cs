namespace WinformUI.AdminPanel
{
    partial class ActorAdminForm
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
            this.dgwActors = new System.Windows.Forms.DataGridView();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.tbxFirstName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblFirstName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxLastName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblLastName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxDescription = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblDescription = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.cmbGenders = new Core.WinFormUI.CustomControls.DevComboBox();
            this.lblGender = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblBirthDate = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.dtpBirthDate = new Core.WinFormUI.CustomControls.DevDateTimePicker();
            this.tbxImageUrl = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.lblImage = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwActors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Controls.Add(this.dgwActors);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(0, 0);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.panelGrid.Size = new System.Drawing.Size(931, 976);
            this.panelGrid.TabIndex = 1;
            // 
            // dgwActors
            // 
            this.dgwActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwActors.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwActors.Location = new System.Drawing.Point(9, 11);
            this.dgwActors.Name = "dgwActors";
            this.dgwActors.RowHeadersWidth = 51;
            this.dgwActors.RowTemplate.Height = 24;
            this.dgwActors.Size = new System.Drawing.Size(913, 841);
            this.dgwActors.TabIndex = 0;
            this.dgwActors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwActors_CellClick);
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
            this.btnReset.Location = new System.Drawing.Point(962, 896);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 64);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(1326, 813);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 64);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(1140, 813);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 64);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(962, 813);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 64);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxFirstName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxFirstName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxFirstName.BorderRadius = 0;
            this.tbxFirstName.BorderSize = 1;
            this.tbxFirstName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.Black;
            this.tbxFirstName.Location = new System.Drawing.Point(1204, 42);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFirstName.Multiline = false;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxFirstName.PasswordChar = false;
            this.tbxFirstName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxFirstName.PlaceholderText = "";
            this.tbxFirstName.Size = new System.Drawing.Size(289, 39);
            this.tbxFirstName.TabIndex = 22;
            this.tbxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxFirstName.Texts = "";
            this.tbxFirstName.UnderlinedStyle = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFirstName.Location = new System.Drawing.Point(962, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(196, 45);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.TabStop = false;
            this.lblFirstName.Text = "First name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxLastName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxLastName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxLastName.BorderRadius = 0;
            this.tbxLastName.BorderSize = 1;
            this.tbxLastName.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastName.ForeColor = System.Drawing.Color.Black;
            this.tbxLastName.Location = new System.Drawing.Point(1204, 106);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastName.Multiline = false;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxLastName.PasswordChar = false;
            this.tbxLastName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxLastName.PlaceholderText = "";
            this.tbxLastName.Size = new System.Drawing.Size(289, 39);
            this.tbxLastName.TabIndex = 24;
            this.tbxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxLastName.Texts = "";
            this.tbxLastName.UnderlinedStyle = false;
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLastName.Location = new System.Drawing.Point(962, 99);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(196, 45);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.TabStop = false;
            this.lblLastName.Text = "Last name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tbxDescription.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxDescription.BorderRadius = 0;
            this.tbxDescription.BorderSize = 1;
            this.tbxDescription.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.ForeColor = System.Drawing.Color.Black;
            this.tbxDescription.Location = new System.Drawing.Point(1204, 169);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxDescription.PasswordChar = false;
            this.tbxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxDescription.PlaceholderText = "";
            this.tbxDescription.Size = new System.Drawing.Size(289, 98);
            this.tbxDescription.TabIndex = 26;
            this.tbxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDescription.Texts = "";
            this.tbxDescription.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Location = new System.Drawing.Point(962, 176);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(196, 45);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.TabStop = false;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbGenders
            // 
            this.cmbGenders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGenders.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbGenders.BorderSize = 1;
            this.cmbGenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGenders.ForeColor = System.Drawing.Color.DimGray;
            this.cmbGenders.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbGenders.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGenders.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbGenders.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbGenders.Location = new System.Drawing.Point(1205, 291);
            this.cmbGenders.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbGenders.Name = "cmbGenders";
            this.cmbGenders.Padding = new System.Windows.Forms.Padding(1);
            this.cmbGenders.Size = new System.Drawing.Size(289, 38);
            this.cmbGenders.TabIndex = 60;
            this.cmbGenders.Texts = "";
            // 
            // lblGender
            // 
            this.lblGender.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGender.Location = new System.Drawing.Point(962, 284);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(196, 45);
            this.lblGender.TabIndex = 59;
            this.lblGender.TabStop = false;
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBirthDate.Location = new System.Drawing.Point(962, 349);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(196, 45);
            this.lblBirthDate.TabIndex = 61;
            this.lblBirthDate.TabStop = false;
            this.lblBirthDate.Text = "Birth date";
            this.lblBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpBirthDate.BorderSize = 0;
            this.dtpBirthDate.CustomFormat = "dd.MM.yyyy";
            this.dtpBirthDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Location = new System.Drawing.Point(1205, 359);
            this.dtpBirthDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(289, 35);
            this.dtpBirthDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.dtpBirthDate.TabIndex = 62;
            this.dtpBirthDate.TextColor = System.Drawing.Color.Gainsboro;
            // 
            // tbxImageUrl
            // 
            this.tbxImageUrl.BackColor = System.Drawing.SystemColors.Window;
            this.tbxImageUrl.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxImageUrl.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxImageUrl.BorderRadius = 0;
            this.tbxImageUrl.BorderSize = 1;
            this.tbxImageUrl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxImageUrl.ForeColor = System.Drawing.Color.Black;
            this.tbxImageUrl.Location = new System.Drawing.Point(1204, 426);
            this.tbxImageUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbxImageUrl.Multiline = false;
            this.tbxImageUrl.Name = "tbxImageUrl";
            this.tbxImageUrl.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxImageUrl.PasswordChar = false;
            this.tbxImageUrl.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxImageUrl.PlaceholderText = "";
            this.tbxImageUrl.Size = new System.Drawing.Size(289, 38);
            this.tbxImageUrl.TabIndex = 65;
            this.tbxImageUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxImageUrl.Texts = "";
            this.tbxImageUrl.UnderlinedStyle = false;
            this.tbxImageUrl._TextChanged += new System.EventHandler(this.tbxImageUrl__TextChanged);
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(1204, 478);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(289, 220);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 64;
            this.pcbImage.TabStop = false;
            // 
            // lblImage
            // 
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblImage.Location = new System.Drawing.Point(962, 419);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(196, 45);
            this.lblImage.TabIndex = 63;
            this.lblImage.TabStop = false;
            this.lblImage.Text = "Image";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActorAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 976);
            this.Controls.Add(this.tbxImageUrl);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.cmbGenders);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelGrid);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActorAdminForm";
            this.Text = "DirectorAdminForm";
            this.Load += new System.EventHandler(this.DirectorAdminForm_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwActors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgwActors;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private Infrastructure.CustomControls.DevTextBox tbxFirstName;
        private Infrastructure.CustomControls.TransparentLabel lblFirstName;
        private Infrastructure.CustomControls.DevTextBox tbxLastName;
        private Infrastructure.CustomControls.TransparentLabel lblLastName;
        private Infrastructure.CustomControls.DevTextBox tbxDescription;
        private Infrastructure.CustomControls.TransparentLabel lblDescription;
        private Core.WinFormUI.CustomControls.DevComboBox cmbGenders;
        private Infrastructure.CustomControls.TransparentLabel lblGender;
        private Infrastructure.CustomControls.TransparentLabel lblBirthDate;
        private Core.WinFormUI.CustomControls.DevDateTimePicker dtpBirthDate;
        private Infrastructure.CustomControls.DevTextBox tbxImageUrl;
        private System.Windows.Forms.PictureBox pcbImage;
        private Infrastructure.CustomControls.TransparentLabel lblImage;
    }
}