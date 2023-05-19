namespace WinformUI.Infrastructure.CustomControls
{
    partial class ButtonComplex
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new WinformUI.Infrastructure.CustomControls.TransparentFlowLayoutPanel();
            this.btnBook = new FontAwesome.Sharp.IconButton();
            this.btnMovie = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(20, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(960, 585);
            this.panelMain.TabIndex = 0;
            // 
            // btnBook
            // 
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBook.IconSize = 40;
            this.btnBook.Location = new System.Drawing.Point(20, 9);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(180, 50);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnMovie
            // 
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnMovie.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnMovie.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovie.IconSize = 40;
            this.btnMovie.Location = new System.Drawing.Point(206, 9);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(180, 50);
            this.btnMovie.TabIndex = 2;
            this.btnMovie.Text = "Movie";
            this.btnMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // ButtonComplex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMovie);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "ButtonComplex";
            this.Padding = new System.Windows.Forms.Padding(20, 70, 20, 20);
            this.Size = new System.Drawing.Size(1000, 675);
            this.Load += new System.EventHandler(this.ButtonComplex_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentFlowLayoutPanel panelMain;
        private FontAwesome.Sharp.IconButton btnBook;
        private FontAwesome.Sharp.IconButton btnMovie;
    }
}
