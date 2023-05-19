namespace WinformUI.Infrastructure.CustomControls
{
    partial class BookSliderObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookSliderObject));
            this.btnAddFavourites = new FontAwesome.Sharp.IconButton();
            this.btnAddWishlist = new FontAwesome.Sharp.IconButton();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblAuthor = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddChart = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddFavourites
            // 
            this.btnAddFavourites.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFavourites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFavourites.FlatAppearance.BorderSize = 0;
            this.btnAddFavourites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFavourites.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnAddFavourites.IconColor = System.Drawing.Color.Silver;
            this.btnAddFavourites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFavourites.IconSize = 35;
            this.btnAddFavourites.Location = new System.Drawing.Point(3, 3);
            this.btnAddFavourites.Name = "btnAddFavourites";
            this.btnAddFavourites.Size = new System.Drawing.Size(100, 42);
            this.btnAddFavourites.TabIndex = 0;
            this.btnAddFavourites.UseVisualStyleBackColor = false;
            this.btnAddFavourites.Click += new System.EventHandler(this.btnAddFavourites_Click);
            // 
            // btnAddWishlist
            // 
            this.btnAddWishlist.BackColor = System.Drawing.Color.Transparent;
            this.btnAddWishlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWishlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddWishlist.FlatAppearance.BorderSize = 0;
            this.btnAddWishlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWishlist.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btnAddWishlist.IconColor = System.Drawing.Color.Silver;
            this.btnAddWishlist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddWishlist.IconSize = 35;
            this.btnAddWishlist.Location = new System.Drawing.Point(219, 3);
            this.btnAddWishlist.Name = "btnAddWishlist";
            this.btnAddWishlist.Size = new System.Drawing.Size(102, 42);
            this.btnAddWishlist.TabIndex = 1;
            this.btnAddWishlist.UseVisualStyleBackColor = false;
            this.btnAddWishlist.Click += new System.EventHandler(this.btnAddWishlist_Click);
            // 
            // pcbImage
            // 
            this.pcbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(0, 0);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(330, 305);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 3;
            this.pcbImage.TabStop = false;
            this.pcbImage.Click += new System.EventHandler(this.bookSliderObject_Click);
            // 
            // panelMain
            // 
            this.panelMain.ColumnCount = 1;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Controls.Add(this.lblPrice, 0, 2);
            this.panelMain.Controls.Add(this.lblName, 0, 0);
            this.panelMain.Controls.Add(this.lblAuthor, 0, 1);
            this.panelMain.Controls.Add(this.panelButtons, 0, 3);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 4;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.13793F));
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.89655F));
            this.panelMain.Size = new System.Drawing.Size(330, 165);
            this.panelMain.TabIndex = 0;
            this.panelMain.Click += new System.EventHandler(this.bookSliderObject_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(3, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(324, 33);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.TabStop = false;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrice.Click += new System.EventHandler(this.bookSliderObject_Click);
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblName.Location = new System.Drawing.Point(3, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(324, 42);
            this.lblName.TabIndex = 1;
            this.lblName.TabStop = false;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.Click += new System.EventHandler(this.bookSliderObject_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAuthor.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblAuthor.Location = new System.Drawing.Point(3, 51);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(324, 18);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.TabStop = false;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuthor.Click += new System.EventHandler(this.bookSliderObject_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.ColumnCount = 3;
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.panelButtons.Controls.Add(this.btnAddChart, 1, 0);
            this.panelButtons.Controls.Add(this.btnAddWishlist, 2, 0);
            this.panelButtons.Controls.Add(this.btnAddFavourites, 0, 0);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(3, 114);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.RowCount = 1;
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelButtons.Size = new System.Drawing.Size(324, 48);
            this.panelButtons.TabIndex = 3;
            // 
            // btnAddChart
            // 
            this.btnAddChart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddChart.FlatAppearance.BorderSize = 0;
            this.btnAddChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnAddChart.IconColor = System.Drawing.Color.Silver;
            this.btnAddChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddChart.IconSize = 35;
            this.btnAddChart.Location = new System.Drawing.Point(109, 3);
            this.btnAddChart.Name = "btnAddChart";
            this.btnAddChart.Size = new System.Drawing.Size(104, 42);
            this.btnAddChart.TabIndex = 2;
            this.btnAddChart.UseVisualStyleBackColor = false;
            this.btnAddChart.Click += new System.EventHandler(this.btnAddChart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 165);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.bookSliderObject_Click);
            // 
            // BookSliderObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(330, 470);
            this.Name = "BookSliderObject";
            this.Size = new System.Drawing.Size(330, 470);
            this.Load += new System.EventHandler(this.SliderObject_Load);
            this.Click += new System.EventHandler(this.bookSliderObject_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddFavourites;
        private FontAwesome.Sharp.IconButton btnAddWishlist;
        private System.Windows.Forms.PictureBox pcbImage;
        private TransparentLabel lblAuthor;
        private TransparentLabel lblName;
        private TransparentLabel lblPrice;
        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
        private FontAwesome.Sharp.IconButton btnAddChart;
    }
}
