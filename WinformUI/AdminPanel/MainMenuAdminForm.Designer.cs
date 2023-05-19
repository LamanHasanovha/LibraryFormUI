namespace WinformUI.AdminPanel
{
    partial class MainMenuAdminForm
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
            this.panelObjectCrud = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.btnFastPeekObject = new FontAwesome.Sharp.IconButton();
            this.btnPreviewAllObject = new FontAwesome.Sharp.IconButton();
            this.btnPreviewObject = new FontAwesome.Sharp.IconButton();
            this.cmbRecords = new Core.WinFormUI.CustomControls.DevComboBox();
            this.lblRecords = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.cmbProductTypes = new Core.WinFormUI.CustomControls.DevComboBox();
            this.lblProductType = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.cmbContents = new Core.WinFormUI.CustomControls.DevComboBox();
            this.lblContents = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxDescriptionObject = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblDescriptionObject = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxTitleObject = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblTitleObject = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.btnResetObject = new FontAwesome.Sharp.IconButton();
            this.btnDeleteObject = new FontAwesome.Sharp.IconButton();
            this.btnUpdateObject = new FontAwesome.Sharp.IconButton();
            this.btnAddObject = new FontAwesome.Sharp.IconButton();
            this.panelContentGrid = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.dgwContents = new System.Windows.Forms.DataGridView();
            this.panelContentsGrid = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.dgwObjects = new System.Windows.Forms.DataGridView();
            this.panelContentCrud = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.btnFastPeekContent = new FontAwesome.Sharp.IconButton();
            this.btnPreviewAllContent = new FontAwesome.Sharp.IconButton();
            this.btnPreviewContent = new FontAwesome.Sharp.IconButton();
            this.tbxPriority = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblPriority = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxDescriptionContent = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.cmbContentTypes = new Core.WinFormUI.CustomControls.DevComboBox();
            this.lblContentType = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblDescriptionContent = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxTitleContent = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblTitleContent = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.btnResetContent = new FontAwesome.Sharp.IconButton();
            this.btnDeleteContent = new FontAwesome.Sharp.IconButton();
            this.btnUpdateContent = new FontAwesome.Sharp.IconButton();
            this.btnAddContent = new FontAwesome.Sharp.IconButton();
            this.panelMain.SuspendLayout();
            this.panelObjectCrud.SuspendLayout();
            this.panelContentGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwContents)).BeginInit();
            this.panelContentsGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwObjects)).BeginInit();
            this.panelContentCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.ColumnCount = 2;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMain.Controls.Add(this.panelObjectCrud, 1, 1);
            this.panelMain.Controls.Add(this.panelContentGrid, 0, 0);
            this.panelMain.Controls.Add(this.panelContentsGrid, 1, 0);
            this.panelMain.Controls.Add(this.panelContentCrud, 0, 1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(10, 10);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 2;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelMain.Size = new System.Drawing.Size(1510, 957);
            this.panelMain.TabIndex = 1;
            // 
            // panelObjectCrud
            // 
            this.panelObjectCrud.BackColor = System.Drawing.Color.Transparent;
            this.panelObjectCrud.Controls.Add(this.btnFastPeekObject);
            this.panelObjectCrud.Controls.Add(this.btnPreviewAllObject);
            this.panelObjectCrud.Controls.Add(this.btnPreviewObject);
            this.panelObjectCrud.Controls.Add(this.cmbRecords);
            this.panelObjectCrud.Controls.Add(this.lblRecords);
            this.panelObjectCrud.Controls.Add(this.cmbProductTypes);
            this.panelObjectCrud.Controls.Add(this.lblProductType);
            this.panelObjectCrud.Controls.Add(this.cmbContents);
            this.panelObjectCrud.Controls.Add(this.lblContents);
            this.panelObjectCrud.Controls.Add(this.tbxDescriptionObject);
            this.panelObjectCrud.Controls.Add(this.lblDescriptionObject);
            this.panelObjectCrud.Controls.Add(this.tbxTitleObject);
            this.panelObjectCrud.Controls.Add(this.lblTitleObject);
            this.panelObjectCrud.Controls.Add(this.btnResetObject);
            this.panelObjectCrud.Controls.Add(this.btnDeleteObject);
            this.panelObjectCrud.Controls.Add(this.btnUpdateObject);
            this.panelObjectCrud.Controls.Add(this.btnAddObject);
            this.panelObjectCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelObjectCrud.Location = new System.Drawing.Point(758, 481);
            this.panelObjectCrud.Name = "panelObjectCrud";
            this.panelObjectCrud.Size = new System.Drawing.Size(749, 473);
            this.panelObjectCrud.TabIndex = 4;
            // 
            // btnFastPeekObject
            // 
            this.btnFastPeekObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnFastPeekObject.FlatAppearance.BorderSize = 0;
            this.btnFastPeekObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFastPeekObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastPeekObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFastPeekObject.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.btnFastPeekObject.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFastPeekObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFastPeekObject.IconSize = 32;
            this.btnFastPeekObject.Location = new System.Drawing.Point(611, 131);
            this.btnFastPeekObject.Name = "btnFastPeekObject";
            this.btnFastPeekObject.Size = new System.Drawing.Size(40, 38);
            this.btnFastPeekObject.TabIndex = 78;
            this.btnFastPeekObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFastPeekObject.UseVisualStyleBackColor = false;
            this.btnFastPeekObject.Click += new System.EventHandler(this.btnFastPeekObject_Click);
            // 
            // btnPreviewAllObject
            // 
            this.btnPreviewAllObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnPreviewAllObject.FlatAppearance.BorderSize = 0;
            this.btnPreviewAllObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewAllObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewAllObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreviewAllObject.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            this.btnPreviewAllObject.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPreviewAllObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreviewAllObject.IconSize = 32;
            this.btnPreviewAllObject.Location = new System.Drawing.Point(381, 396);
            this.btnPreviewAllObject.Name = "btnPreviewAllObject";
            this.btnPreviewAllObject.Size = new System.Drawing.Size(168, 64);
            this.btnPreviewAllObject.TabIndex = 77;
            this.btnPreviewAllObject.Text = "Preview all";
            this.btnPreviewAllObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviewAllObject.UseVisualStyleBackColor = false;
            this.btnPreviewAllObject.Click += new System.EventHandler(this.btnPreviewAllObject_Click);
            // 
            // btnPreviewObject
            // 
            this.btnPreviewObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnPreviewObject.FlatAppearance.BorderSize = 0;
            this.btnPreviewObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreviewObject.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnPreviewObject.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPreviewObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreviewObject.IconSize = 32;
            this.btnPreviewObject.Location = new System.Drawing.Point(200, 396);
            this.btnPreviewObject.Name = "btnPreviewObject";
            this.btnPreviewObject.Size = new System.Drawing.Size(168, 64);
            this.btnPreviewObject.TabIndex = 76;
            this.btnPreviewObject.Text = "Preview";
            this.btnPreviewObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviewObject.UseVisualStyleBackColor = false;
            this.btnPreviewObject.Click += new System.EventHandler(this.btnPreviewObject_Click);
            // 
            // cmbRecords
            // 
            this.cmbRecords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRecords.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbRecords.BorderSize = 1;
            this.cmbRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbRecords.ForeColor = System.Drawing.Color.DimGray;
            this.cmbRecords.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbRecords.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbRecords.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbRecords.Location = new System.Drawing.Point(315, 252);
            this.cmbRecords.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbRecords.Name = "cmbRecords";
            this.cmbRecords.Padding = new System.Windows.Forms.Padding(1);
            this.cmbRecords.Size = new System.Drawing.Size(289, 38);
            this.cmbRecords.TabIndex = 75;
            this.cmbRecords.Texts = "";
            // 
            // lblRecords
            // 
            this.lblRecords.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRecords.Location = new System.Drawing.Point(73, 245);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(196, 45);
            this.lblRecords.TabIndex = 74;
            this.lblRecords.TabStop = false;
            this.lblRecords.Text = "Record";
            this.lblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProductTypes
            // 
            this.cmbProductTypes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbProductTypes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbProductTypes.BorderSize = 1;
            this.cmbProductTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbProductTypes.ForeColor = System.Drawing.Color.DimGray;
            this.cmbProductTypes.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbProductTypes.Items.AddRange(new object[] {
            "Book",
            "Movie",
            "Other"});
            this.cmbProductTypes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbProductTypes.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbProductTypes.Location = new System.Drawing.Point(315, 193);
            this.cmbProductTypes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbProductTypes.Name = "cmbProductTypes";
            this.cmbProductTypes.Padding = new System.Windows.Forms.Padding(1);
            this.cmbProductTypes.Size = new System.Drawing.Size(289, 38);
            this.cmbProductTypes.TabIndex = 73;
            this.cmbProductTypes.Texts = "";
            this.cmbProductTypes.OnSelectedIndexChanged += new System.EventHandler(this.cmbProductTypes_OnSelectedIndexChanged);
            // 
            // lblProductType
            // 
            this.lblProductType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProductType.Location = new System.Drawing.Point(73, 186);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(196, 45);
            this.lblProductType.TabIndex = 72;
            this.lblProductType.TabStop = false;
            this.lblProductType.Text = "Product type";
            this.lblProductType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbContents
            // 
            this.cmbContents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbContents.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbContents.BorderSize = 1;
            this.cmbContents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbContents.ForeColor = System.Drawing.Color.DimGray;
            this.cmbContents.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbContents.Items.AddRange(new object[] {
            "Slider",
            "SpecialSlider",
            "News",
            "SupriseMe",
            "ButtonComplex"});
            this.cmbContents.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbContents.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbContents.Location = new System.Drawing.Point(316, 131);
            this.cmbContents.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbContents.Name = "cmbContents";
            this.cmbContents.Padding = new System.Windows.Forms.Padding(1);
            this.cmbContents.Size = new System.Drawing.Size(289, 38);
            this.cmbContents.TabIndex = 71;
            this.cmbContents.Texts = "";
            this.cmbContents.OnSelectedIndexChanged += new System.EventHandler(this.cmbContents_OnSelectedIndexChanged);
            // 
            // lblContents
            // 
            this.lblContents.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContents.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContents.Location = new System.Drawing.Point(73, 124);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(196, 45);
            this.lblContents.TabIndex = 70;
            this.lblContents.TabStop = false;
            this.lblContents.Text = "Content";
            this.lblContents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDescriptionObject
            // 
            this.tbxDescriptionObject.BackColor = System.Drawing.SystemColors.Window;
            this.tbxDescriptionObject.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxDescriptionObject.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxDescriptionObject.BorderRadius = 0;
            this.tbxDescriptionObject.BorderSize = 1;
            this.tbxDescriptionObject.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescriptionObject.ForeColor = System.Drawing.Color.Black;
            this.tbxDescriptionObject.Location = new System.Drawing.Point(316, 70);
            this.tbxDescriptionObject.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescriptionObject.Multiline = false;
            this.tbxDescriptionObject.Name = "tbxDescriptionObject";
            this.tbxDescriptionObject.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxDescriptionObject.PasswordChar = false;
            this.tbxDescriptionObject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxDescriptionObject.PlaceholderText = "";
            this.tbxDescriptionObject.Size = new System.Drawing.Size(289, 39);
            this.tbxDescriptionObject.TabIndex = 69;
            this.tbxDescriptionObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDescriptionObject.Texts = "";
            this.tbxDescriptionObject.UnderlinedStyle = false;
            // 
            // lblDescriptionObject
            // 
            this.lblDescriptionObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescriptionObject.Location = new System.Drawing.Point(73, 64);
            this.lblDescriptionObject.Name = "lblDescriptionObject";
            this.lblDescriptionObject.Size = new System.Drawing.Size(196, 45);
            this.lblDescriptionObject.TabIndex = 68;
            this.lblDescriptionObject.TabStop = false;
            this.lblDescriptionObject.Text = "Description";
            this.lblDescriptionObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxTitleObject
            // 
            this.tbxTitleObject.BackColor = System.Drawing.SystemColors.Window;
            this.tbxTitleObject.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxTitleObject.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxTitleObject.BorderRadius = 0;
            this.tbxTitleObject.BorderSize = 1;
            this.tbxTitleObject.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitleObject.ForeColor = System.Drawing.Color.Black;
            this.tbxTitleObject.Location = new System.Drawing.Point(315, 15);
            this.tbxTitleObject.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTitleObject.Multiline = false;
            this.tbxTitleObject.Name = "tbxTitleObject";
            this.tbxTitleObject.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxTitleObject.PasswordChar = false;
            this.tbxTitleObject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxTitleObject.PlaceholderText = "";
            this.tbxTitleObject.Size = new System.Drawing.Size(289, 39);
            this.tbxTitleObject.TabIndex = 67;
            this.tbxTitleObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxTitleObject.Texts = "";
            this.tbxTitleObject.UnderlinedStyle = false;
            // 
            // lblTitleObject
            // 
            this.lblTitleObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleObject.Location = new System.Drawing.Point(73, 8);
            this.lblTitleObject.Name = "lblTitleObject";
            this.lblTitleObject.Size = new System.Drawing.Size(196, 45);
            this.lblTitleObject.TabIndex = 66;
            this.lblTitleObject.TabStop = false;
            this.lblTitleObject.Text = "Title";
            this.lblTitleObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetObject
            // 
            this.btnResetObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnResetObject.FlatAppearance.BorderSize = 0;
            this.btnResetObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResetObject.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
            this.btnResetObject.IconColor = System.Drawing.Color.Gainsboro;
            this.btnResetObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetObject.IconSize = 32;
            this.btnResetObject.Location = new System.Drawing.Point(562, 313);
            this.btnResetObject.Name = "btnResetObject";
            this.btnResetObject.Size = new System.Drawing.Size(168, 64);
            this.btnResetObject.TabIndex = 24;
            this.btnResetObject.Text = "Reset";
            this.btnResetObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetObject.UseVisualStyleBackColor = false;
            this.btnResetObject.Click += new System.EventHandler(this.btnResetObject_Click);
            // 
            // btnDeleteObject
            // 
            this.btnDeleteObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnDeleteObject.FlatAppearance.BorderSize = 0;
            this.btnDeleteObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteObject.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.btnDeleteObject.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteObject.IconSize = 32;
            this.btnDeleteObject.Location = new System.Drawing.Point(381, 313);
            this.btnDeleteObject.Name = "btnDeleteObject";
            this.btnDeleteObject.Size = new System.Drawing.Size(168, 64);
            this.btnDeleteObject.TabIndex = 23;
            this.btnDeleteObject.Text = "Delete";
            this.btnDeleteObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteObject.UseVisualStyleBackColor = false;
            this.btnDeleteObject.Click += new System.EventHandler(this.btnDeleteObject_Click);
            // 
            // btnUpdateObject
            // 
            this.btnUpdateObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnUpdateObject.FlatAppearance.BorderSize = 0;
            this.btnUpdateObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateObject.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnUpdateObject.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateObject.IconSize = 32;
            this.btnUpdateObject.Location = new System.Drawing.Point(200, 313);
            this.btnUpdateObject.Name = "btnUpdateObject";
            this.btnUpdateObject.Size = new System.Drawing.Size(168, 64);
            this.btnUpdateObject.TabIndex = 22;
            this.btnUpdateObject.Text = "Update";
            this.btnUpdateObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateObject.UseVisualStyleBackColor = false;
            this.btnUpdateObject.Click += new System.EventHandler(this.btnUpdateObject_Click);
            // 
            // btnAddObject
            // 
            this.btnAddObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnAddObject.FlatAppearance.BorderSize = 0;
            this.btnAddObject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddObject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddObject.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddObject.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddObject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddObject.IconSize = 32;
            this.btnAddObject.Location = new System.Drawing.Point(19, 313);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(168, 64);
            this.btnAddObject.TabIndex = 21;
            this.btnAddObject.Text = "Add";
            this.btnAddObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddObject.UseVisualStyleBackColor = false;
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
            // 
            // panelContentGrid
            // 
            this.panelContentGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelContentGrid.Controls.Add(this.dgwContents);
            this.panelContentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentGrid.Location = new System.Drawing.Point(3, 3);
            this.panelContentGrid.Name = "panelContentGrid";
            this.panelContentGrid.Padding = new System.Windows.Forms.Padding(10);
            this.panelContentGrid.Size = new System.Drawing.Size(749, 472);
            this.panelContentGrid.TabIndex = 1;
            // 
            // dgwContents
            // 
            this.dgwContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwContents.Location = new System.Drawing.Point(10, 10);
            this.dgwContents.Name = "dgwContents";
            this.dgwContents.RowHeadersWidth = 51;
            this.dgwContents.RowTemplate.Height = 24;
            this.dgwContents.Size = new System.Drawing.Size(729, 452);
            this.dgwContents.TabIndex = 0;
            this.dgwContents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwContents_CellClick);
            // 
            // panelContentsGrid
            // 
            this.panelContentsGrid.BackColor = System.Drawing.Color.Transparent;
            this.panelContentsGrid.Controls.Add(this.dgwObjects);
            this.panelContentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentsGrid.Location = new System.Drawing.Point(758, 3);
            this.panelContentsGrid.Name = "panelContentsGrid";
            this.panelContentsGrid.Padding = new System.Windows.Forms.Padding(10);
            this.panelContentsGrid.Size = new System.Drawing.Size(749, 472);
            this.panelContentsGrid.TabIndex = 2;
            // 
            // dgwObjects
            // 
            this.dgwObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwObjects.Location = new System.Drawing.Point(10, 10);
            this.dgwObjects.Name = "dgwObjects";
            this.dgwObjects.RowHeadersWidth = 51;
            this.dgwObjects.RowTemplate.Height = 24;
            this.dgwObjects.Size = new System.Drawing.Size(729, 452);
            this.dgwObjects.TabIndex = 1;
            this.dgwObjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwObjects_CellClick);
            // 
            // panelContentCrud
            // 
            this.panelContentCrud.BackColor = System.Drawing.Color.Transparent;
            this.panelContentCrud.Controls.Add(this.btnFastPeekContent);
            this.panelContentCrud.Controls.Add(this.btnPreviewAllContent);
            this.panelContentCrud.Controls.Add(this.btnPreviewContent);
            this.panelContentCrud.Controls.Add(this.tbxPriority);
            this.panelContentCrud.Controls.Add(this.lblPriority);
            this.panelContentCrud.Controls.Add(this.tbxDescriptionContent);
            this.panelContentCrud.Controls.Add(this.cmbContentTypes);
            this.panelContentCrud.Controls.Add(this.lblContentType);
            this.panelContentCrud.Controls.Add(this.lblDescriptionContent);
            this.panelContentCrud.Controls.Add(this.tbxTitleContent);
            this.panelContentCrud.Controls.Add(this.lblTitleContent);
            this.panelContentCrud.Controls.Add(this.btnResetContent);
            this.panelContentCrud.Controls.Add(this.btnDeleteContent);
            this.panelContentCrud.Controls.Add(this.btnUpdateContent);
            this.panelContentCrud.Controls.Add(this.btnAddContent);
            this.panelContentCrud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentCrud.Location = new System.Drawing.Point(3, 481);
            this.panelContentCrud.Name = "panelContentCrud";
            this.panelContentCrud.Size = new System.Drawing.Size(749, 473);
            this.panelContentCrud.TabIndex = 3;
            // 
            // btnFastPeekContent
            // 
            this.btnFastPeekContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnFastPeekContent.FlatAppearance.BorderSize = 0;
            this.btnFastPeekContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFastPeekContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastPeekContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFastPeekContent.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassArrowRight;
            this.btnFastPeekContent.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFastPeekContent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFastPeekContent.IconSize = 32;
            this.btnFastPeekContent.Location = new System.Drawing.Point(575, 131);
            this.btnFastPeekContent.Name = "btnFastPeekContent";
            this.btnFastPeekContent.Size = new System.Drawing.Size(40, 38);
            this.btnFastPeekContent.TabIndex = 70;
            this.btnFastPeekContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFastPeekContent.UseVisualStyleBackColor = false;
            this.btnFastPeekContent.Click += new System.EventHandler(this.btnFastPeekContent_Click);
            // 
            // btnPreviewAllContent
            // 
            this.btnPreviewAllContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnPreviewAllContent.FlatAppearance.BorderSize = 0;
            this.btnPreviewAllContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewAllContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewAllContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreviewAllContent.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            this.btnPreviewAllContent.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPreviewAllContent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreviewAllContent.IconSize = 32;
            this.btnPreviewAllContent.Location = new System.Drawing.Point(382, 396);
            this.btnPreviewAllContent.Name = "btnPreviewAllContent";
            this.btnPreviewAllContent.Size = new System.Drawing.Size(168, 64);
            this.btnPreviewAllContent.TabIndex = 69;
            this.btnPreviewAllContent.Text = "Preview all";
            this.btnPreviewAllContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviewAllContent.UseVisualStyleBackColor = false;
            this.btnPreviewAllContent.Click += new System.EventHandler(this.btnPreviewAllContent_Click);
            // 
            // btnPreviewContent
            // 
            this.btnPreviewContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnPreviewContent.FlatAppearance.BorderSize = 0;
            this.btnPreviewContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreviewContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPreviewContent.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnPreviewContent.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPreviewContent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreviewContent.IconSize = 32;
            this.btnPreviewContent.Location = new System.Drawing.Point(201, 396);
            this.btnPreviewContent.Name = "btnPreviewContent";
            this.btnPreviewContent.Size = new System.Drawing.Size(168, 64);
            this.btnPreviewContent.TabIndex = 68;
            this.btnPreviewContent.Text = "Preview";
            this.btnPreviewContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviewContent.UseVisualStyleBackColor = false;
            this.btnPreviewContent.Click += new System.EventHandler(this.btnPreviewContent_Click);
            // 
            // tbxPriority
            // 
            this.tbxPriority.BackColor = System.Drawing.SystemColors.Window;
            this.tbxPriority.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxPriority.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxPriority.BorderRadius = 0;
            this.tbxPriority.BorderSize = 1;
            this.tbxPriority.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPriority.ForeColor = System.Drawing.Color.Black;
            this.tbxPriority.Location = new System.Drawing.Point(279, 192);
            this.tbxPriority.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPriority.Multiline = false;
            this.tbxPriority.Name = "tbxPriority";
            this.tbxPriority.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxPriority.PasswordChar = false;
            this.tbxPriority.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxPriority.PlaceholderText = "";
            this.tbxPriority.Size = new System.Drawing.Size(289, 39);
            this.tbxPriority.TabIndex = 67;
            this.tbxPriority.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxPriority.Texts = "";
            this.tbxPriority.UnderlinedStyle = false;
            // 
            // lblPriority
            // 
            this.lblPriority.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPriority.Location = new System.Drawing.Point(37, 186);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(196, 45);
            this.lblPriority.TabIndex = 66;
            this.lblPriority.TabStop = false;
            this.lblPriority.Text = "Priority";
            this.lblPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDescriptionContent
            // 
            this.tbxDescriptionContent.BackColor = System.Drawing.SystemColors.Window;
            this.tbxDescriptionContent.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxDescriptionContent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxDescriptionContent.BorderRadius = 0;
            this.tbxDescriptionContent.BorderSize = 1;
            this.tbxDescriptionContent.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescriptionContent.ForeColor = System.Drawing.Color.Black;
            this.tbxDescriptionContent.Location = new System.Drawing.Point(279, 70);
            this.tbxDescriptionContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescriptionContent.Multiline = false;
            this.tbxDescriptionContent.Name = "tbxDescriptionContent";
            this.tbxDescriptionContent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxDescriptionContent.PasswordChar = false;
            this.tbxDescriptionContent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxDescriptionContent.PlaceholderText = "";
            this.tbxDescriptionContent.Size = new System.Drawing.Size(289, 39);
            this.tbxDescriptionContent.TabIndex = 65;
            this.tbxDescriptionContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDescriptionContent.Texts = "";
            this.tbxDescriptionContent.UnderlinedStyle = false;
            // 
            // cmbContentTypes
            // 
            this.cmbContentTypes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbContentTypes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbContentTypes.BorderSize = 1;
            this.cmbContentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbContentTypes.ForeColor = System.Drawing.Color.DimGray;
            this.cmbContentTypes.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmbContentTypes.Items.AddRange(new object[] {
            "Slider",
            "SpecialSlider",
            "News",
            "SupriseMe",
            "ButtonComplex"});
            this.cmbContentTypes.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbContentTypes.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbContentTypes.Location = new System.Drawing.Point(280, 131);
            this.cmbContentTypes.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbContentTypes.Name = "cmbContentTypes";
            this.cmbContentTypes.Padding = new System.Windows.Forms.Padding(1);
            this.cmbContentTypes.Size = new System.Drawing.Size(289, 38);
            this.cmbContentTypes.TabIndex = 64;
            this.cmbContentTypes.Texts = "";
            // 
            // lblContentType
            // 
            this.lblContentType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContentType.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContentType.Location = new System.Drawing.Point(37, 124);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(196, 45);
            this.lblContentType.TabIndex = 63;
            this.lblContentType.TabStop = false;
            this.lblContentType.Text = "Content type";
            this.lblContentType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescriptionContent
            // 
            this.lblDescriptionContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptionContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescriptionContent.Location = new System.Drawing.Point(37, 64);
            this.lblDescriptionContent.Name = "lblDescriptionContent";
            this.lblDescriptionContent.Size = new System.Drawing.Size(196, 45);
            this.lblDescriptionContent.TabIndex = 61;
            this.lblDescriptionContent.TabStop = false;
            this.lblDescriptionContent.Text = "Description";
            this.lblDescriptionContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxTitleContent
            // 
            this.tbxTitleContent.BackColor = System.Drawing.SystemColors.Window;
            this.tbxTitleContent.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxTitleContent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxTitleContent.BorderRadius = 0;
            this.tbxTitleContent.BorderSize = 1;
            this.tbxTitleContent.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTitleContent.ForeColor = System.Drawing.Color.Black;
            this.tbxTitleContent.Location = new System.Drawing.Point(279, 15);
            this.tbxTitleContent.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTitleContent.Multiline = false;
            this.tbxTitleContent.Name = "tbxTitleContent";
            this.tbxTitleContent.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxTitleContent.PasswordChar = false;
            this.tbxTitleContent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxTitleContent.PlaceholderText = "";
            this.tbxTitleContent.Size = new System.Drawing.Size(289, 39);
            this.tbxTitleContent.TabIndex = 26;
            this.tbxTitleContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxTitleContent.Texts = "";
            this.tbxTitleContent.UnderlinedStyle = false;
            // 
            // lblTitleContent
            // 
            this.lblTitleContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleContent.Location = new System.Drawing.Point(37, 8);
            this.lblTitleContent.Name = "lblTitleContent";
            this.lblTitleContent.Size = new System.Drawing.Size(196, 45);
            this.lblTitleContent.TabIndex = 25;
            this.lblTitleContent.TabStop = false;
            this.lblTitleContent.Text = "Title";
            this.lblTitleContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetContent
            // 
            this.btnResetContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnResetContent.FlatAppearance.BorderSize = 0;
            this.btnResetContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnResetContent.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
            this.btnResetContent.IconColor = System.Drawing.Color.Gainsboro;
            this.btnResetContent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetContent.IconSize = 32;
            this.btnResetContent.Location = new System.Drawing.Point(563, 313);
            this.btnResetContent.Name = "btnResetContent";
            this.btnResetContent.Size = new System.Drawing.Size(168, 64);
            this.btnResetContent.TabIndex = 24;
            this.btnResetContent.Text = "Reset";
            this.btnResetContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetContent.UseVisualStyleBackColor = false;
            this.btnResetContent.Click += new System.EventHandler(this.btnResetContent_Click);
            // 
            // btnDeleteContent
            // 
            this.btnDeleteContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnDeleteContent.FlatAppearance.BorderSize = 0;
            this.btnDeleteContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteContent.IconChar = FontAwesome.Sharp.IconChar.TrashRestore;
            this.btnDeleteContent.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeleteContent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteContent.IconSize = 32;
            this.btnDeleteContent.Location = new System.Drawing.Point(382, 313);
            this.btnDeleteContent.Name = "btnDeleteContent";
            this.btnDeleteContent.Size = new System.Drawing.Size(168, 64);
            this.btnDeleteContent.TabIndex = 23;
            this.btnDeleteContent.Text = "Delete";
            this.btnDeleteContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteContent.UseVisualStyleBackColor = false;
            this.btnDeleteContent.Click += new System.EventHandler(this.btnDeleteContent_Click);
            // 
            // btnUpdateContent
            // 
            this.btnUpdateContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnUpdateContent.FlatAppearance.BorderSize = 0;
            this.btnUpdateContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateContent.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnUpdateContent.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateContent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateContent.IconSize = 32;
            this.btnUpdateContent.Location = new System.Drawing.Point(201, 313);
            this.btnUpdateContent.Name = "btnUpdateContent";
            this.btnUpdateContent.Size = new System.Drawing.Size(168, 64);
            this.btnUpdateContent.TabIndex = 22;
            this.btnUpdateContent.Text = "Update";
            this.btnUpdateContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateContent.UseVisualStyleBackColor = false;
            this.btnUpdateContent.Click += new System.EventHandler(this.btnUpdateContent_Click);
            // 
            // btnAddContent
            // 
            this.btnAddContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.btnAddContent.FlatAppearance.BorderSize = 0;
            this.btnAddContent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddContent.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddContent.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAddContent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddContent.IconSize = 32;
            this.btnAddContent.Location = new System.Drawing.Point(20, 313);
            this.btnAddContent.Name = "btnAddContent";
            this.btnAddContent.Size = new System.Drawing.Size(168, 64);
            this.btnAddContent.TabIndex = 21;
            this.btnAddContent.Text = "Add";
            this.btnAddContent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddContent.UseVisualStyleBackColor = false;
            this.btnAddContent.Click += new System.EventHandler(this.btnAddContent_Click);
            // 
            // MainMenuAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 977);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuAdminForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "MainMenuAdminForm";
            this.Load += new System.EventHandler(this.MainMenuAdminForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelObjectCrud.ResumeLayout(false);
            this.panelContentGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwContents)).EndInit();
            this.panelContentsGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwObjects)).EndInit();
            this.panelContentCrud.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Infrastructure.CustomControls.TransparentTableLayoutPanel panelMain;
        private Infrastructure.CustomControls.TransparentPanel panelObjectCrud;
        private Infrastructure.CustomControls.TransparentPanel panelContentGrid;
        private Infrastructure.CustomControls.TransparentPanel panelContentsGrid;
        private Infrastructure.CustomControls.TransparentPanel panelContentCrud;
        private FontAwesome.Sharp.IconButton btnResetObject;
        private FontAwesome.Sharp.IconButton btnDeleteObject;
        private FontAwesome.Sharp.IconButton btnUpdateObject;
        private FontAwesome.Sharp.IconButton btnAddObject;
        private FontAwesome.Sharp.IconButton btnResetContent;
        private FontAwesome.Sharp.IconButton btnDeleteContent;
        private FontAwesome.Sharp.IconButton btnUpdateContent;
        private FontAwesome.Sharp.IconButton btnAddContent;
        private Infrastructure.CustomControls.DevTextBox tbxTitleContent;
        private Infrastructure.CustomControls.TransparentLabel lblTitleContent;
        private Infrastructure.CustomControls.TransparentLabel lblDescriptionContent;
        private Core.WinFormUI.CustomControls.DevComboBox cmbContentTypes;
        private Infrastructure.CustomControls.TransparentLabel lblContentType;
        private Infrastructure.CustomControls.DevTextBox tbxDescriptionContent;
        private Infrastructure.CustomControls.DevTextBox tbxDescriptionObject;
        private Infrastructure.CustomControls.TransparentLabel lblDescriptionObject;
        private Infrastructure.CustomControls.DevTextBox tbxTitleObject;
        private Infrastructure.CustomControls.TransparentLabel lblTitleObject;
        private Infrastructure.CustomControls.DevTextBox tbxPriority;
        private Infrastructure.CustomControls.TransparentLabel lblPriority;
        private FontAwesome.Sharp.IconButton btnPreviewAllObject;
        private FontAwesome.Sharp.IconButton btnPreviewObject;
        private Core.WinFormUI.CustomControls.DevComboBox cmbRecords;
        private Infrastructure.CustomControls.TransparentLabel lblRecords;
        private Core.WinFormUI.CustomControls.DevComboBox cmbProductTypes;
        private Infrastructure.CustomControls.TransparentLabel lblProductType;
        private Core.WinFormUI.CustomControls.DevComboBox cmbContents;
        private Infrastructure.CustomControls.TransparentLabel lblContents;
        private FontAwesome.Sharp.IconButton btnPreviewAllContent;
        private FontAwesome.Sharp.IconButton btnPreviewContent;
        private System.Windows.Forms.DataGridView dgwContents;
        private System.Windows.Forms.DataGridView dgwObjects;
        private FontAwesome.Sharp.IconButton btnFastPeekObject;
        private FontAwesome.Sharp.IconButton btnFastPeekContent;
    }
}