namespace WinformUI.AdminPanel
{
    partial class MovieAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieAdminForm));
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgwMovies = new System.Windows.Forms.DataGridView();
            this.lblImdb = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblGenre = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblReleaseDate = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblDirector = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxDescription = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblDescription = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.lblImage = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.tbxImdb = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblStars = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxHour = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblTime = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblHour = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblMinutes = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxMinutes = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.tbxImageUrl = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.tbxPrice = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.cmbDirectors = new Core.WinFormUI.CustomControls.DevComboBox();
            this.slcGenres = new WinformUI.Infrastructure.CustomControls.MultiSelector();
            this.slcActors = new WinformUI.Infrastructure.CustomControls.MultiSelector();
            this.dtpReleaseDate = new Core.WinFormUI.CustomControls.DevDateTimePicker();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelGrid.Controls.Add(this.dgwMovies);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGrid.Location = new System.Drawing.Point(18, 21);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.panelGrid.Size = new System.Drawing.Size(931, 957);
            this.panelGrid.TabIndex = 0;
            // 
            // dgwMovies
            // 
            this.dgwMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgwMovies.Location = new System.Drawing.Point(9, 11);
            this.dgwMovies.Name = "dgwMovies";
            this.dgwMovies.RowHeadersWidth = 51;
            this.dgwMovies.RowTemplate.Height = 24;
            this.dgwMovies.Size = new System.Drawing.Size(913, 848);
            this.dgwMovies.TabIndex = 0;
            this.dgwMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAccounts_CellClick);
            // 
            // lblImdb
            // 
            this.lblImdb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImdb.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblImdb.Location = new System.Drawing.Point(971, 388);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(196, 45);
            this.lblImdb.TabIndex = 11;
            this.lblImdb.TabStop = false;
            this.lblImdb.Text = "Imdb";
            this.lblImdb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenre
            // 
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGenre.Location = new System.Drawing.Point(971, 322);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(196, 45);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.TabStop = false;
            this.lblGenre.Text = "Genre";
            this.lblGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReleaseDate.Location = new System.Drawing.Point(971, 256);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(196, 45);
            this.lblReleaseDate.TabIndex = 7;
            this.lblReleaseDate.TabStop = false;
            this.lblReleaseDate.Text = "Release date";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirector
            // 
            this.lblDirector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDirector.Location = new System.Drawing.Point(971, 190);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(196, 45);
            this.lblDirector.TabIndex = 5;
            this.lblDirector.TabStop = false;
            this.lblDirector.Text = "Director";
            this.lblDirector.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tbxDescription.Location = new System.Drawing.Point(1213, 82);
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
            this.lblDescription.Location = new System.Drawing.Point(971, 89);
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
            this.tbxName.Location = new System.Drawing.Point(1214, 27);
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
            this.lblName.Location = new System.Drawing.Point(971, 17);
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
            this.btnAdd.Location = new System.Drawing.Point(971, 844);
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
            this.btnUpdate.Location = new System.Drawing.Point(1149, 844);
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
            this.btnDelete.Location = new System.Drawing.Point(1335, 844);
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
            this.btnReset.Location = new System.Drawing.Point(971, 922);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 64);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblImage
            // 
            this.lblImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblImage.Location = new System.Drawing.Point(971, 606);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(196, 45);
            this.lblImage.TabIndex = 53;
            this.lblImage.TabStop = false;
            this.lblImage.Text = "Image";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbImage
            // 
            this.pcbImage.Location = new System.Drawing.Point(1213, 665);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(289, 161);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 54;
            this.pcbImage.TabStop = false;
            // 
            // tbxImdb
            // 
            this.tbxImdb.BackColor = System.Drawing.SystemColors.Window;
            this.tbxImdb.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxImdb.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxImdb.BorderRadius = 0;
            this.tbxImdb.BorderSize = 1;
            this.tbxImdb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxImdb.ForeColor = System.Drawing.Color.Black;
            this.tbxImdb.Location = new System.Drawing.Point(1213, 395);
            this.tbxImdb.Margin = new System.Windows.Forms.Padding(4);
            this.tbxImdb.Multiline = false;
            this.tbxImdb.Name = "tbxImdb";
            this.tbxImdb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxImdb.PasswordChar = false;
            this.tbxImdb.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxImdb.PlaceholderText = "";
            this.tbxImdb.Size = new System.Drawing.Size(289, 38);
            this.tbxImdb.TabIndex = 55;
            this.tbxImdb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxImdb.Texts = "";
            this.tbxImdb.UnderlinedStyle = false;
            // 
            // lblStars
            // 
            this.lblStars.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStars.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStars.Location = new System.Drawing.Point(971, 452);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(196, 45);
            this.lblStars.TabIndex = 56;
            this.lblStars.TabStop = false;
            this.lblStars.Text = "Stars";
            this.lblStars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxHour
            // 
            this.tbxHour.BackColor = System.Drawing.SystemColors.Window;
            this.tbxHour.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxHour.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxHour.BorderRadius = 0;
            this.tbxHour.BorderSize = 1;
            this.tbxHour.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHour.ForeColor = System.Drawing.Color.Black;
            this.tbxHour.Location = new System.Drawing.Point(1213, 514);
            this.tbxHour.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHour.Multiline = false;
            this.tbxHour.Name = "tbxHour";
            this.tbxHour.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxHour.PasswordChar = false;
            this.tbxHour.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxHour.PlaceholderText = "";
            this.tbxHour.Size = new System.Drawing.Size(77, 38);
            this.tbxHour.TabIndex = 59;
            this.tbxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxHour.Texts = "";
            this.tbxHour.UnderlinedStyle = false;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(971, 507);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(196, 45);
            this.lblTime.TabIndex = 58;
            this.lblTime.TabStop = false;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHour
            // 
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHour.Location = new System.Drawing.Point(1302, 514);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(45, 38);
            this.lblHour.TabIndex = 60;
            this.lblHour.TabStop = false;
            this.lblHour.Text = "h";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMinutes.Location = new System.Drawing.Point(1457, 514);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(45, 38);
            this.lblMinutes.TabIndex = 62;
            this.lblMinutes.TabStop = false;
            this.lblMinutes.Text = "m";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxMinutes
            // 
            this.tbxMinutes.BackColor = System.Drawing.SystemColors.Window;
            this.tbxMinutes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxMinutes.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxMinutes.BorderRadius = 0;
            this.tbxMinutes.BorderSize = 1;
            this.tbxMinutes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMinutes.ForeColor = System.Drawing.Color.Black;
            this.tbxMinutes.Location = new System.Drawing.Point(1368, 514);
            this.tbxMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMinutes.Multiline = false;
            this.tbxMinutes.Name = "tbxMinutes";
            this.tbxMinutes.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxMinutes.PasswordChar = false;
            this.tbxMinutes.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxMinutes.PlaceholderText = "";
            this.tbxMinutes.Size = new System.Drawing.Size(77, 38);
            this.tbxMinutes.TabIndex = 61;
            this.tbxMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxMinutes.Texts = "";
            this.tbxMinutes.UnderlinedStyle = false;
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
            this.tbxImageUrl.Location = new System.Drawing.Point(1213, 613);
            this.tbxImageUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbxImageUrl.Multiline = false;
            this.tbxImageUrl.Name = "tbxImageUrl";
            this.tbxImageUrl.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxImageUrl.PasswordChar = false;
            this.tbxImageUrl.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxImageUrl.PlaceholderText = "";
            this.tbxImageUrl.Size = new System.Drawing.Size(289, 38);
            this.tbxImageUrl.TabIndex = 63;
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
            this.tbxPrice.Location = new System.Drawing.Point(1213, 565);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPrice.Multiline = false;
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxPrice.PasswordChar = false;
            this.tbxPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPrice.PlaceholderText = "";
            this.tbxPrice.Size = new System.Drawing.Size(289, 38);
            this.tbxPrice.TabIndex = 65;
            this.tbxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPrice.Texts = "";
            this.tbxPrice.UnderlinedStyle = false;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrice.Location = new System.Drawing.Point(971, 558);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(196, 45);
            this.lblPrice.TabIndex = 64;
            this.lblPrice.TabStop = false;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDirectors
            // 
            this.cmbDirectors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDirectors.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDirectors.BorderSize = 1;
            this.cmbDirectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbDirectors.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDirectors.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbDirectors.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbDirectors.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbDirectors.Location = new System.Drawing.Point(1213, 197);
            this.cmbDirectors.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbDirectors.Name = "cmbDirectors";
            this.cmbDirectors.Padding = new System.Windows.Forms.Padding(1);
            this.cmbDirectors.Size = new System.Drawing.Size(289, 38);
            this.cmbDirectors.TabIndex = 66;
            this.cmbDirectors.Texts = "";
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
            this.slcGenres.Location = new System.Drawing.Point(1213, 329);
            this.slcGenres.Name = "slcGenres";
            this.slcGenres.SearchButtonBackColor = System.Drawing.Color.Transparent;
            this.slcGenres.SearchButtonIconColor = System.Drawing.Color.Gainsboro;
            this.slcGenres.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("slcGenres.SelectedIndexes")));
            this.slcGenres.Size = new System.Drawing.Size(289, 38);
            this.slcGenres.TabIndex = 67;
            // 
            // slcActors
            // 
            this.slcActors.BackColor = System.Drawing.Color.Transparent;
            this.slcActors.Data = null;
            this.slcActors.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slcActors.Items = null;
            this.slcActors.ItemsFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slcActors.ItemsForeColor = System.Drawing.Color.Gainsboro;
            this.slcActors.ItemsOpacity = 50;
            this.slcActors.ItemsText = "No item selected";
            this.slcActors.Location = new System.Drawing.Point(1213, 459);
            this.slcActors.Name = "slcActors";
            this.slcActors.SearchButtonBackColor = System.Drawing.Color.Transparent;
            this.slcActors.SearchButtonIconColor = System.Drawing.Color.Gainsboro;
            this.slcActors.SelectedIndexes = ((System.Collections.Generic.List<int>)(resources.GetObject("slcActors.SelectedIndexes")));
            this.slcActors.Size = new System.Drawing.Size(289, 38);
            this.slcActors.TabIndex = 68;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpReleaseDate.BorderSize = 0;
            this.dtpReleaseDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReleaseDate.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReleaseDate.Location = new System.Drawing.Point(1213, 266);
            this.dtpReleaseDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(289, 35);
            this.dtpReleaseDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.dtpReleaseDate.TabIndex = 1;
            this.dtpReleaseDate.TextColor = System.Drawing.Color.Gainsboro;
            // 
            // MovieAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 999);
            this.Controls.Add(this.dtpReleaseDate);
            this.Controls.Add(this.slcActors);
            this.Controls.Add(this.slcGenres);
            this.Controls.Add(this.cmbDirectors);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.tbxImageUrl);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.tbxMinutes);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.tbxHour);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblStars);
            this.Controls.Add(this.tbxImdb);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblImdb);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblReleaseDate);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panelGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieAdminForm";
            this.Padding = new System.Windows.Forms.Padding(18, 21, 18, 21);
            this.Text = "AccountAdminForm";
            this.Load += new System.EventHandler(this.AccountAdminForm_Load);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgwMovies;
        private Infrastructure.CustomControls.TransparentLabel lblName;
        private Infrastructure.CustomControls.DevTextBox tbxName;
        private Infrastructure.CustomControls.TransparentLabel lblDescription;
        private Infrastructure.CustomControls.DevTextBox tbxDescription;
        private Infrastructure.CustomControls.TransparentLabel lblDirector;
        private Infrastructure.CustomControls.TransparentLabel lblReleaseDate;
        private Infrastructure.CustomControls.TransparentLabel lblGenre;
        private Infrastructure.CustomControls.TransparentLabel lblImdb;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnReset;
        private Infrastructure.CustomControls.TransparentLabel lblImage;
        private System.Windows.Forms.PictureBox pcbImage;
        private Infrastructure.CustomControls.DevTextBox tbxImdb;
        private Infrastructure.CustomControls.TransparentLabel lblStars;
        private Infrastructure.CustomControls.DevTextBox tbxHour;
        private Infrastructure.CustomControls.TransparentLabel lblTime;
        private Infrastructure.CustomControls.TransparentLabel lblHour;
        private Infrastructure.CustomControls.TransparentLabel lblMinutes;
        private Infrastructure.CustomControls.DevTextBox tbxMinutes;
        private Infrastructure.CustomControls.DevTextBox tbxImageUrl;
        private Infrastructure.CustomControls.DevTextBox tbxPrice;
        private Infrastructure.CustomControls.TransparentLabel lblPrice;
        private Core.WinFormUI.CustomControls.DevComboBox cmbDirectors;
        private Infrastructure.CustomControls.MultiSelector slcGenres;
        private Infrastructure.CustomControls.MultiSelector slcActors;
        private Core.WinFormUI.CustomControls.DevDateTimePicker dtpReleaseDate;
    }
}