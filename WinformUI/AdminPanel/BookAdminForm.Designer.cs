namespace WinformUI.AdminPanel
{
    partial class BookAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAdminForm));
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.lblLanguage = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblGenre = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxPage = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblPage = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblAuthor = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxDescription = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblDescription = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.cmbLanguages = new Core.WinFormUI.CustomControls.DevComboBox();
            this.lblImage = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.tbxImageUrl = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.tbxPrice = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.cmbAuthors = new Core.WinFormUI.CustomControls.DevComboBox();
            this.slcGenres = new WinformUI.Infrastructure.CustomControls.MultiSelector();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Controls.Add(this.dgwBooks);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(18, 21);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.panelGrid.Size = new System.Drawing.Size(931, 935);
            this.panelGrid.TabIndex = 0;
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwBooks.Location = new System.Drawing.Point(9, 11);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.RowHeadersWidth = 51;
            this.dgwBooks.RowTemplate.Height = 24;
            this.dgwBooks.Size = new System.Drawing.Size(913, 841);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAccounts_CellClick);
            // 
            // lblLanguage
            // 
            this.lblLanguage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLanguage.Location = new System.Drawing.Point(971, 403);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(196, 45);
            this.lblLanguage.TabIndex = 11;
            this.lblLanguage.TabStop = false;
            this.lblLanguage.Text = "Language";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGenre.Location = new System.Drawing.Point(971, 342);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(196, 45);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.TabStop = false;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPage
            // 
            this.tbxPage.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPage.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxPage.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxPage.BorderRadius = 0;
            this.tbxPage.BorderSize = 1;
            this.tbxPage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPage.ForeColor = System.Drawing.Color.Black;
            this.tbxPage.Location = new System.Drawing.Point(1213, 283);
            this.tbxPage.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPage.Multiline = false;
            this.tbxPage.Name = "tbxPage";
            this.tbxPage.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxPage.PasswordChar = false;
            this.tbxPage.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPage.PlaceholderText = "";
            this.tbxPage.Size = new System.Drawing.Size(289, 38);
            this.tbxPage.TabIndex = 8;
            this.tbxPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPage.Texts = "";
            this.tbxPage.UnderlinedStyle = false;
            // 
            // lblPage
            // 
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPage.Location = new System.Drawing.Point(971, 276);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(196, 45);
            this.lblPage.TabIndex = 7;
            this.lblPage.TabStop = false;
            this.lblPage.Text = "Page";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAuthor.Location = new System.Drawing.Point(971, 210);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(196, 45);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.TabStop = false;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDescription
            // 
            this.tbxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tbxDescription.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxDescription.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxDescription.BorderRadius = 0;
            this.tbxDescription.BorderSize = 1;
            this.tbxDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.ForeColor = System.Drawing.Color.Black;
            this.tbxDescription.Location = new System.Drawing.Point(1213, 102);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxDescription.PasswordChar = false;
            this.tbxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxDescription.PlaceholderText = "";
            this.tbxDescription.Size = new System.Drawing.Size(289, 98);
            this.tbxDescription.TabIndex = 4;
            this.tbxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDescription.Texts = "";
            this.tbxDescription.UnderlinedStyle = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Location = new System.Drawing.Point(971, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(196, 45);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.TabStop = false;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.SystemColors.Window;
            this.tbxName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxName.BorderRadius = 0;
            this.tbxName.BorderSize = 1;
            this.tbxName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.ForeColor = System.Drawing.Color.Black;
            this.tbxName.Location = new System.Drawing.Point(1214, 47);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Multiline = false;
            this.tbxName.Name = "tbxName";
            this.tbxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxName.PasswordChar = false;
            this.tbxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxName.PlaceholderText = "";
            this.tbxName.Size = new System.Drawing.Size(289, 38);
            this.tbxName.TabIndex = 2;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxName.Texts = "";
            this.tbxName.UnderlinedStyle = true;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(971, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(196, 45);
            this.lblName.TabIndex = 1;
            this.lblName.TabStop = false;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAdd.Location = new System.Drawing.Point(971, 809);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 64);
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
            this.btnUpdate.Location = new System.Drawing.Point(1149, 809);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 64);
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
            this.btnDelete.Location = new System.Drawing.Point(1335, 809);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 64);
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
            this.btnReset.Location = new System.Drawing.Point(971, 892);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 64);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbLanguages.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbLanguages.BorderSize = 1;
            this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbLanguages.ForeColor = System.Drawing.Color.DimGray;
            this.cmbLanguages.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbLanguages.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbLanguages.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbLanguages.Location = new System.Drawing.Point(1213, 410);
            this.cmbLanguages.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbLanguages.Name = "cmbLanguages";
            this.cmbLanguages.Padding = new System.Windows.Forms.Padding(1);
            this.cmbLanguages.Size = new System.Drawing.Size(289, 38);
            this.cmbLanguages.TabIndex = 52;
            this.cmbLanguages.Texts = "";
            // 
            // lblImage
            // 
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblImage.Location = new System.Drawing.Point(971, 514);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(196, 45);
            this.lblImage.TabIndex = 53;
            this.lblImage.TabStop = false;
            this.lblImage.Text = "Image";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(1213, 573);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(289, 220);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 54;
            this.pcbImage.TabStop = false;
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
            this.tbxImageUrl.Location = new System.Drawing.Point(1213, 521);
            this.tbxImageUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbxImageUrl.Multiline = false;
            this.tbxImageUrl.Name = "tbxImageUrl";
            this.tbxImageUrl.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxImageUrl.PasswordChar = false;
            this.tbxImageUrl.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxImageUrl.PlaceholderText = "";
            this.tbxImageUrl.Size = new System.Drawing.Size(289, 38);
            this.tbxImageUrl.TabIndex = 55;
            this.tbxImageUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxImageUrl.Texts = "";
            this.tbxImageUrl.UnderlinedStyle = false;
            this.tbxImageUrl._TextChanged += new System.EventHandler(this.tbxImageUrl__TextChanged);
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPrice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxPrice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxPrice.BorderRadius = 0;
            this.tbxPrice.BorderSize = 1;
            this.tbxPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.ForeColor = System.Drawing.Color.Black;
            this.tbxPrice.Location = new System.Drawing.Point(1213, 466);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrice.Multiline = false;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxPrice.PasswordChar = false;
            this.tbxPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPrice.PlaceholderText = "";
            this.tbxPrice.Size = new System.Drawing.Size(289, 38);
            this.tbxPrice.TabIndex = 57;
            this.tbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPrice.Texts = "";
            this.tbxPrice.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrice.Location = new System.Drawing.Point(971, 459);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(196, 45);
            this.lblPrice.TabIndex = 56;
            this.lblPrice.TabStop = false;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbAuthors
            // 
            this.cmbAuthors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbAuthors.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbAuthors.BorderSize = 1;
            this.cmbAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbAuthors.ForeColor = System.Drawing.Color.DimGray;
            this.cmbAuthors.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbAuthors.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbAuthors.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbAuthors.Location = new System.Drawing.Point(1214, 217);
            this.cmbAuthors.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbAuthors.Name = "cmbAuthors";
            this.cmbAuthors.Padding = new System.Windows.Forms.Padding(1);
            this.cmbAuthors.Size = new System.Drawing.Size(289, 38);
            this.cmbAuthors.TabIndex = 58;
            this.cmbAuthors.Texts = "";
            // 
            // slcGenres
            // 
            this.slcGenres.BackColor = System.Drawing.Color.Transparent;
            this.slcGenres.Data = null;
            this.slcGenres.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slcGenres.Items = null;
            this.slcGenres.ItemsFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slcGenres.ItemsForeColor = System.Drawing.Color.Gainsboro;
            this.slcGenres.ItemsOpacity = 50;
            this.slcGenres.ItemsText = "No item selected";
            this.slcGenres.Location = new System.Drawing.Point(1213, 342);
            this.slcGenres.Name = "slcGenres";
            this.slcGenres.SearchButtonBackColor = System.Drawing.Color.Transparent;
            this.slcGenres.SearchButtonIconColor = System.Drawing.Color.Gainsboro;
            this.slcGenres.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("slcGenres.SelectedIndexes")));
            this.slcGenres.Size = new System.Drawing.Size(289, 45);
            this.slcGenres.TabIndex = 59;
            // 
            // BookAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 977);
            this.Controls.Add(this.slcGenres);
            this.Controls.Add(this.cmbAuthors);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxImageUrl);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.cmbLanguages);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.tbxPage);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookAdminForm";
            this.Padding = new System.Windows.Forms.Padding(18, 21, 18, 21);
            this.Text = "AccountAdminForm";
            this.Load += new System.EventHandler(this.AccountAdminForm_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgwBooks;
        private Infrastructure.CustomControls.TransparentLabel lblName;
        private Infrastructure.CustomControls.DevTextBox tbxName;
        private Infrastructure.CustomControls.TransparentLabel lblDescription;
        private Infrastructure.CustomControls.DevTextBox tbxDescription;
        private Infrastructure.CustomControls.TransparentLabel lblAuthor;
        private Infrastructure.CustomControls.DevTextBox tbxPage;
        private Infrastructure.CustomControls.TransparentLabel lblPage;
        private Infrastructure.CustomControls.TransparentLabel lblGenre;
        private Infrastructure.CustomControls.TransparentLabel lblLanguage;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReset;
        private Core.WinFormUI.CustomControls.DevComboBox cmbLanguages;
        private Infrastructure.CustomControls.TransparentLabel lblImage;
        private System.Windows.Forms.PictureBox pcbImage;
        private Infrastructure.CustomControls.DevTextBox tbxImageUrl;
        private Infrastructure.CustomControls.DevTextBox tbxPrice;
        private Infrastructure.CustomControls.TransparentLabel lblPrice;
        private Core.WinFormUI.CustomControls.DevComboBox cmbAuthors;
        private Infrastructure.CustomControls.MultiSelector slcGenres;
    }
}