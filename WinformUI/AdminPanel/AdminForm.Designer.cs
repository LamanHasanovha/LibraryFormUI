namespace WinformUI.AdminPanel
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnMainMenu = new FontAwesome.Sharp.IconButton();
            this.btnActors = new FontAwesome.Sharp.IconButton();
            this.btnAuthors = new FontAwesome.Sharp.IconButton();
            this.btnDirectors = new FontAwesome.Sharp.IconButton();
            this.btnUtils = new FontAwesome.Sharp.IconButton();
            this.btnMovies = new FontAwesome.Sharp.IconButton();
            this.btnBooks = new FontAwesome.Sharp.IconButton();
            this.btnAccounts = new FontAwesome.Sharp.IconButton();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(29)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1365, 105);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 32;
            this.btnClose.Location = new System.Drawing.Point(1304, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 40);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.Transparent;
            this.panelSidebar.Controls.Add(this.btnMainMenu);
            this.panelSidebar.Controls.Add(this.btnActors);
            this.panelSidebar.Controls.Add(this.btnAuthors);
            this.panelSidebar.Controls.Add(this.btnDirectors);
            this.panelSidebar.Controls.Add(this.btnUtils);
            this.panelSidebar.Controls.Add(this.btnMovies);
            this.panelSidebar.Controls.Add(this.btnBooks);
            this.panelSidebar.Controls.Add(this.btnAccounts);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 105);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.panelSidebar.Size = new System.Drawing.Size(268, 698);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMainMenu.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.btnMainMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMainMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMainMenu.IconSize = 35;
            this.btnMainMenu.Location = new System.Drawing.Point(17, 576);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(234, 80);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Main menu";
            this.btnMainMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnActors
            // 
            this.btnActors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActors.FlatAppearance.BorderSize = 0;
            this.btnActors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnActors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnActors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnActors.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnActors.IconColor = System.Drawing.Color.Gainsboro;
            this.btnActors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActors.IconSize = 35;
            this.btnActors.Location = new System.Drawing.Point(17, 496);
            this.btnActors.Name = "btnActors";
            this.btnActors.Size = new System.Drawing.Size(234, 80);
            this.btnActors.TabIndex = 6;
            this.btnActors.Text = "Actors";
            this.btnActors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActors.UseVisualStyleBackColor = true;
            this.btnActors.Click += new System.EventHandler(this.btnActors_Click);
            // 
            // btnAuthors
            // 
            this.btnAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthors.FlatAppearance.BorderSize = 0;
            this.btnAuthors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAuthors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAuthors.IconChar = FontAwesome.Sharp.IconChar.At;
            this.btnAuthors.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAuthors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAuthors.IconSize = 35;
            this.btnAuthors.Location = new System.Drawing.Point(17, 416);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(234, 80);
            this.btnAuthors.TabIndex = 5;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAuthors.UseVisualStyleBackColor = true;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnDirectors
            // 
            this.btnDirectors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirectors.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDirectors.FlatAppearance.BorderSize = 0;
            this.btnDirectors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDirectors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDirectors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirectors.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDirectors.IconChar = FontAwesome.Sharp.IconChar.RecordVinyl;
            this.btnDirectors.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDirectors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDirectors.IconSize = 35;
            this.btnDirectors.Location = new System.Drawing.Point(17, 336);
            this.btnDirectors.Name = "btnDirectors";
            this.btnDirectors.Size = new System.Drawing.Size(234, 80);
            this.btnDirectors.TabIndex = 4;
            this.btnDirectors.Text = "Directors";
            this.btnDirectors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectors.UseVisualStyleBackColor = true;
            this.btnDirectors.Click += new System.EventHandler(this.btnDirectors_Click);
            // 
            // btnUtils
            // 
            this.btnUtils.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUtils.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUtils.FlatAppearance.BorderSize = 0;
            this.btnUtils.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUtils.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUtils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtils.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtils.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUtils.IconChar = FontAwesome.Sharp.IconChar.AlignCenter;
            this.btnUtils.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUtils.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUtils.IconSize = 35;
            this.btnUtils.Location = new System.Drawing.Point(17, 256);
            this.btnUtils.Name = "btnUtils";
            this.btnUtils.Size = new System.Drawing.Size(234, 80);
            this.btnUtils.TabIndex = 3;
            this.btnUtils.Text = "Utils";
            this.btnUtils.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUtils.UseVisualStyleBackColor = true;
            this.btnUtils.Click += new System.EventHandler(this.btnUtils_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMovies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMovies.IconChar = FontAwesome.Sharp.IconChar.CameraRetro;
            this.btnMovies.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMovies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovies.IconSize = 35;
            this.btnMovies.Location = new System.Drawing.Point(17, 176);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(234, 80);
            this.btnMovies.TabIndex = 2;
            this.btnMovies.Text = "Movies";
            this.btnMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBooks.IconChar = FontAwesome.Sharp.IconChar.BookDead;
            this.btnBooks.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBooks.IconSize = 35;
            this.btnBooks.Location = new System.Drawing.Point(17, 96);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(234, 80);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Books";
            this.btnBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAccounts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.IconChar = FontAwesome.Sharp.IconChar.UserAstronaut;
            this.btnAccounts.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccounts.IconSize = 35;
            this.btnAccounts.Location = new System.Drawing.Point(17, 16);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(234, 80);
            this.btnAccounts.TabIndex = 0;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BackColor = System.Drawing.Color.Transparent;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(268, 105);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1097, 698);
            this.panelContainer.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1365, 803);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminForm_Paint);
            this.Resize += new System.EventHandler(this.AdminForm_Resize);
            this.panelHeader.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSidebar;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnAccounts;
        private FontAwesome.Sharp.IconButton btnMovies;
        private FontAwesome.Sharp.IconButton btnBooks;
        private FontAwesome.Sharp.IconButton btnUtils;
        private FontAwesome.Sharp.IconButton btnActors;
        private FontAwesome.Sharp.IconButton btnAuthors;
        private FontAwesome.Sharp.IconButton btnDirectors;
        private FontAwesome.Sharp.IconButton btnMainMenu;
    }
}