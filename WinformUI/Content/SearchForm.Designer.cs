namespace WinformUI.Content
{
    partial class SearchForm
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblFullName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.sliderBook = new WinformUI.Infrastructure.CustomControls.Slider();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.slider1 = new WinformUI.Infrastructure.CustomControls.Slider();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblFullName);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(20, 20);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.panelTitle.Size = new System.Drawing.Size(1330, 133);
            this.panelTitle.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullName.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblFullName.Location = new System.Drawing.Point(50, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(1280, 133);
            this.lblFullName.TabIndex = 32;
            this.lblFullName.TabStop = false;
            this.lblFullName.Text = "Search results for";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sliderBook
            // 
            this.sliderBook.AddCart = null;
            this.sliderBook.AddFavourites = null;
            this.sliderBook.AddWishlist = null;
            this.sliderBook.BookClickEvent = null;
            this.sliderBook.ButtonColor = System.Drawing.SystemColors.Control;
            this.sliderBook.ButtonIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.sliderBook.DescriptionFont = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderBook.DescriptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.sliderBook.DescriptionText = "Tried to find out best for you                                                   " +
    "                               ";
            this.sliderBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.sliderBook.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderBook.LayoutType = WinformUI.Infrastructure.CustomControls.ObjectTypes.Details;
            this.sliderBook.Location = new System.Drawing.Point(20, 153);
            this.sliderBook.MinimumSize = new System.Drawing.Size(100, 675);
            this.sliderBook.MovieClickEvent = null;
            this.sliderBook.Name = "sliderBook";
            this.sliderBook.Size = new System.Drawing.Size(1330, 675);
            this.sliderBook.TabIndex = 1;
            this.sliderBook.TitleFont = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderBook.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.sliderBook.TitleText = "Books                                                              ";
            this.sliderBook.Type = WinformUI.Infrastructure.CustomControls.SliderType.Book;
            // 
            // panelDivider
            // 
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.panelDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDivider.Location = new System.Drawing.Point(20, 828);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(1330, 5);
            this.panelDivider.TabIndex = 73;
            // 
            // slider1
            // 
            this.slider1.AddCart = null;
            this.slider1.AddFavourites = null;
            this.slider1.AddWishlist = null;
            this.slider1.BookClickEvent = null;
            this.slider1.ButtonColor = System.Drawing.SystemColors.Control;
            this.slider1.ButtonIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.slider1.DescriptionFont = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider1.DescriptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.slider1.DescriptionText = "Explorer`s recommedation                                                         " +
    "                             ";
            this.slider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.slider1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider1.LayoutType = WinformUI.Infrastructure.CustomControls.ObjectTypes.Details;
            this.slider1.Location = new System.Drawing.Point(20, 833);
            this.slider1.MinimumSize = new System.Drawing.Size(100, 675);
            this.slider1.MovieClickEvent = null;
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(1330, 675);
            this.slider1.TabIndex = 74;
            this.slider1.TitleFont = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slider1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.slider1.TitleText = "Movies                                                            ";
            this.slider1.Type = WinformUI.Infrastructure.CustomControls.SliderType.Book;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1391, 1055);
            this.Controls.Add(this.slider1);
            this.Controls.Add(this.panelDivider);
            this.Controls.Add(this.sliderBook);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private Infrastructure.CustomControls.TransparentLabel lblFullName;
        private Infrastructure.CustomControls.Slider sliderBook;
        private System.Windows.Forms.Panel panelDivider;
        private Infrastructure.CustomControls.Slider slider1;
    }
}