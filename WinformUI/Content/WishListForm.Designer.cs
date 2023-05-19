namespace WinformUI.Content
{
    partial class WishListForm
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
            this.components = new System.ComponentModel.Container();
            this.btnBook = new FontAwesome.Sharp.IconButton();
            this.panelMain = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.btnMovie = new FontAwesome.Sharp.IconButton();
            this.timerBook = new System.Windows.Forms.Timer(this.components);
            this.panelHighlight = new System.Windows.Forms.Panel();
            this.timerMovie = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBook.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBook.Location = new System.Drawing.Point(10, 12);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(220, 66);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = " Book";
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(10, 110);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1371, 716);
            this.panelMain.TabIndex = 1;
            // 
            // btnMovie
            // 
            this.btnMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovie.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnMovie.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnMovie.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovie.Location = new System.Drawing.Point(262, 12);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(220, 66);
            this.btnMovie.TabIndex = 2;
            this.btnMovie.Text = " Movie";
            this.btnMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // timerBook
            // 
            this.timerBook.Interval = 1;
            this.timerBook.Tick += new System.EventHandler(this.timerBook_Tick);
            // 
            // panelHighlight
            // 
            this.panelHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.panelHighlight.Location = new System.Drawing.Point(20, 84);
            this.panelHighlight.Name = "panelHighlight";
            this.panelHighlight.Size = new System.Drawing.Size(200, 9);
            this.panelHighlight.TabIndex = 3;
            // 
            // timerMovie
            // 
            this.timerMovie.Interval = 1;
            this.timerMovie.Tick += new System.EventHandler(this.timerMovie_Tick);
            // 
            // WishListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 836);
            this.Controls.Add(this.panelHighlight);
            this.Controls.Add(this.btnMovie);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.btnBook);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WishListForm";
            this.Padding = new System.Windows.Forms.Padding(10, 110, 10, 10);
            this.Text = "WishListForm";
            this.Load += new System.EventHandler(this.WishListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBook;
        private Infrastructure.CustomControls.TransparentPanel panelMain;
        private FontAwesome.Sharp.IconButton btnMovie;
        private System.Windows.Forms.Timer timerBook;
        private System.Windows.Forms.Panel panelHighlight;
        private System.Windows.Forms.Timer timerMovie;
    }
}