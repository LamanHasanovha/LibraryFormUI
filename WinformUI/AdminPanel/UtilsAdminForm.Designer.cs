namespace WinformUI.AdminPanel
{
    partial class UtilsAdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgwLanguages = new System.Windows.Forms.DataGridView();
            this.dgwMovieGenres = new System.Windows.Forms.DataGridView();
            this.dgwBookGenres = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBookGenres = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblMovieGenres = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblLanguages = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxName = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLanguages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookGenres)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(18, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 903);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgwLanguages, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgwMovieGenres, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgwBookGenres, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 903);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgwLanguages
            // 
            this.dgwLanguages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLanguages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwLanguages.Location = new System.Drawing.Point(3, 607);
            this.dgwLanguages.Name = "dgwLanguages";
            this.dgwLanguages.RowHeadersWidth = 51;
            this.dgwLanguages.RowTemplate.Height = 24;
            this.dgwLanguages.Size = new System.Drawing.Size(723, 293);
            this.dgwLanguages.TabIndex = 2;
            this.dgwLanguages.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwLanguages_CellClick);
            // 
            // dgwMovieGenres
            // 
            this.dgwMovieGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMovieGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMovieGenres.Location = new System.Drawing.Point(3, 300);
            this.dgwMovieGenres.Name = "dgwMovieGenres";
            this.dgwMovieGenres.RowHeadersWidth = 51;
            this.dgwMovieGenres.RowTemplate.Height = 24;
            this.dgwMovieGenres.Size = new System.Drawing.Size(723, 301);
            this.dgwMovieGenres.TabIndex = 1;
            this.dgwMovieGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMovieGenres_CellClick);
            // 
            // dgwBookGenres
            // 
            this.dgwBookGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBookGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwBookGenres.Location = new System.Drawing.Point(3, 3);
            this.dgwBookGenres.Name = "dgwBookGenres";
            this.dgwBookGenres.RowHeadersWidth = 51;
            this.dgwBookGenres.RowTemplate.Height = 24;
            this.dgwBookGenres.Size = new System.Drawing.Size(723, 291);
            this.dgwBookGenres.TabIndex = 0;
            this.dgwBookGenres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookGenres_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblBookGenres);
            this.panel2.Controls.Add(this.lblMovieGenres);
            this.panel2.Controls.Add(this.lblLanguages);
            this.panel2.Controls.Add(this.tbxName);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(747, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 903);
            this.panel2.TabIndex = 1;
            // 
            // lblBookGenres
            // 
            this.lblBookGenres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookGenres.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBookGenres.Location = new System.Drawing.Point(5, 109);
            this.lblBookGenres.Name = "lblBookGenres";
            this.lblBookGenres.Size = new System.Drawing.Size(146, 45);
            this.lblBookGenres.TabIndex = 25;
            this.lblBookGenres.TabStop = false;
            this.lblBookGenres.Text = "Book genres";
            this.lblBookGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookGenres.Click += new System.EventHandler(this.lblBookGenres_Click);
            // 
            // lblMovieGenres
            // 
            this.lblMovieGenres.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenres.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMovieGenres.Location = new System.Drawing.Point(5, 451);
            this.lblMovieGenres.Name = "lblMovieGenres";
            this.lblMovieGenres.Size = new System.Drawing.Size(146, 45);
            this.lblMovieGenres.TabIndex = 24;
            this.lblMovieGenres.TabStop = false;
            this.lblMovieGenres.Text = "Movie genres";
            this.lblMovieGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMovieGenres.Click += new System.EventHandler(this.lblMovieGenres_Click);
            // 
            // lblLanguages
            // 
            this.lblLanguages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguages.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLanguages.Location = new System.Drawing.Point(5, 731);
            this.lblLanguages.Name = "lblLanguages";
            this.lblLanguages.Size = new System.Drawing.Size(146, 45);
            this.lblLanguages.TabIndex = 23;
            this.lblLanguages.TabStop = false;
            this.lblLanguages.Text = "Languages";
            this.lblLanguages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLanguages.Click += new System.EventHandler(this.lblLanguages_Click);
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
            this.tbxName.Location = new System.Drawing.Point(454, 318);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Multiline = false;
            this.tbxName.Name = "tbxName";
            this.tbxName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxName.PasswordChar = false;
            this.tbxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxName.PlaceholderText = "";
            this.tbxName.Size = new System.Drawing.Size(289, 38);
            this.tbxName.TabIndex = 22;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxName.Texts = "";
            this.tbxName.UnderlinedStyle = false;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblName.Location = new System.Drawing.Point(211, 308);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(196, 45);
            this.lblName.TabIndex = 21;
            this.lblName.TabStop = false;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnReset.Location = new System.Drawing.Point(238, 692);
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
            this.btnDelete.Location = new System.Drawing.Point(602, 602);
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
            this.btnUpdate.Location = new System.Drawing.Point(416, 602);
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
            this.btnAdd.Location = new System.Drawing.Point(238, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(168, 64);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UtilsAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 945);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UtilsAdminForm";
            this.Padding = new System.Windows.Forms.Padding(18, 21, 18, 21);
            this.Text = "UtilsAdminForm";
            this.Load += new System.EventHandler(this.UtilsAdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwLanguages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMovieGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookGenres)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnReset;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgwLanguages;
        private System.Windows.Forms.DataGridView dgwMovieGenres;
        private System.Windows.Forms.DataGridView dgwBookGenres;
        private Infrastructure.CustomControls.TransparentLabel lblBookGenres;
        private Infrastructure.CustomControls.TransparentLabel lblMovieGenres;
        private Infrastructure.CustomControls.TransparentLabel lblLanguages;
        private Infrastructure.CustomControls.DevTextBox tbxName;
        private Infrastructure.CustomControls.TransparentLabel lblName;
    }
}