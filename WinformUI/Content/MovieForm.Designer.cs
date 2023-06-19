﻿namespace WinformUI.Content
{
    partial class MovieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieForm));
            this.panelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.rtcMovie = new WinformUI.Infrastructure.CustomControls.RatingControl();
            this.lblGenres = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblImdb = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.btnAddCart = new FontAwesome.Sharp.IconButton();
            this.btnAddWishList = new FontAwesome.Sharp.IconButton();
            this.btnAddFavourites = new FontAwesome.Sharp.IconButton();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblActors = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblReleaseDate = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblTime = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.lblDirectorName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.tbxDescription = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.lblMovieName = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.pcbImage = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.sliderSimilars = new WinformUI.Infrastructure.CustomControls.Slider();
            this.panelDivider2 = new System.Windows.Forms.Panel();
            this.panelReviews = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelReviewItems = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReviews = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.btnAddReview = new FontAwesome.Sharp.IconButton();
            this.tbxReview = new WinformUI.Infrastructure.CustomControls.DevTextBox();
            this.panelMain.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.panelReviews.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.SystemColors.Control;
            this.panelMain.Controls.Add(this.panelInfo);
            this.panelMain.Controls.Add(this.panelDivider);
            this.panelMain.Controls.Add(this.sliderSimilars);
            this.panelMain.Controls.Add(this.panelDivider2);
            this.panelMain.Controls.Add(this.panelReviews);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1383, 1055);
            this.panelMain.TabIndex = 76;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.rtcMovie);
            this.panelInfo.Controls.Add(this.lblGenres);
            this.panelInfo.Controls.Add(this.lblImdb);
            this.panelInfo.Controls.Add(this.btnAddCart);
            this.panelInfo.Controls.Add(this.btnAddWishList);
            this.panelInfo.Controls.Add(this.btnAddFavourites);
            this.panelInfo.Controls.Add(this.lblPrice);
            this.panelInfo.Controls.Add(this.lblActors);
            this.panelInfo.Controls.Add(this.lblReleaseDate);
            this.panelInfo.Controls.Add(this.lblTime);
            this.panelInfo.Controls.Add(this.lblDirectorName);
            this.panelInfo.Controls.Add(this.tbxDescription);
            this.panelInfo.Controls.Add(this.lblMovieName);
            this.panelInfo.Controls.Add(this.pcbImage);
            this.panelInfo.Location = new System.Drawing.Point(3, 3);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1538, 834);
            this.panelInfo.TabIndex = 73;
            // 
            // rtcMovie
            // 
            this.rtcMovie.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtcMovie.Location = new System.Drawing.Point(96, 631);
            this.rtcMovie.Name = "rtcMovie";
            this.rtcMovie.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.rtcMovie.RatingReport = "5.6";
            this.rtcMovie.ReloadRating = null;
            this.rtcMovie.SetRating = null;
            this.rtcMovie.Size = new System.Drawing.Size(414, 91);
            this.rtcMovie.TabIndex = 83;
            this.rtcMovie.Value = 0;
            // 
            // lblGenres
            // 
            this.lblGenres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGenres.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblGenres.Location = new System.Drawing.Point(892, 580);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(551, 68);
            this.lblGenres.TabIndex = 82;
            this.lblGenres.TabStop = false;
            this.lblGenres.Text = "Genres";
            this.lblGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblImdb
            // 
            this.lblImdb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImdb.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImdb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblImdb.Location = new System.Drawing.Point(552, 580);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(199, 68);
            this.lblImdb.TabIndex = 81;
            this.lblImdb.TabStop = false;
            this.lblImdb.Text = "Imdb";
            this.lblImdb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCart.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCart.FlatAppearance.BorderSize = 0;
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnAddCart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCart.IconSize = 50;
            this.btnAddCart.Location = new System.Drawing.Point(866, 739);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(99, 68);
            this.btnAddCart.TabIndex = 80;
            this.btnAddCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnAddWishList
            // 
            this.btnAddWishList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddWishList.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddWishList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddWishList.FlatAppearance.BorderSize = 0;
            this.btnAddWishList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWishList.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWishList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddWishList.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btnAddWishList.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddWishList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddWishList.IconSize = 40;
            this.btnAddWishList.Location = new System.Drawing.Point(709, 739);
            this.btnAddWishList.Name = "btnAddWishList";
            this.btnAddWishList.Size = new System.Drawing.Size(99, 68);
            this.btnAddWishList.TabIndex = 79;
            this.btnAddWishList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddWishList.UseVisualStyleBackColor = false;
            this.btnAddWishList.Click += new System.EventHandler(this.btnAddWishList_Click);
            // 
            // btnAddFavourites
            // 
            this.btnAddFavourites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddFavourites.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFavourites.FlatAppearance.BorderSize = 0;
            this.btnAddFavourites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFavourites.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFavourites.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddFavourites.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnAddFavourites.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddFavourites.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFavourites.IconSize = 60;
            this.btnAddFavourites.Location = new System.Drawing.Point(552, 739);
            this.btnAddFavourites.Name = "btnAddFavourites";
            this.btnAddFavourites.Size = new System.Drawing.Size(99, 68);
            this.btnAddFavourites.TabIndex = 78;
            this.btnAddFavourites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFavourites.UseVisualStyleBackColor = false;
            this.btnAddFavourites.Click += new System.EventHandler(this.btnAddFavourites_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(1264, 739);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(179, 68);
            this.lblPrice.TabIndex = 77;
            this.lblPrice.TabStop = false;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActors
            // 
            this.lblActors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblActors.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblActors.Location = new System.Drawing.Point(996, 654);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(447, 68);
            this.lblActors.TabIndex = 76;
            this.lblActors.TabStop = false;
            this.lblActors.Text = "Actors";
            this.lblActors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReleaseDate
            // 
            this.lblReleaseDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblReleaseDate.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblReleaseDate.Location = new System.Drawing.Point(757, 654);
            this.lblReleaseDate.Name = "lblReleaseDate";
            this.lblReleaseDate.Size = new System.Drawing.Size(220, 68);
            this.lblReleaseDate.TabIndex = 75;
            this.lblReleaseDate.TabStop = false;
            this.lblReleaseDate.Text = "Release date";
            this.lblReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTime.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblTime.Location = new System.Drawing.Point(552, 654);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(199, 68);
            this.lblTime.TabIndex = 74;
            this.lblTime.TabStop = false;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDirectorName
            // 
            this.lblDirectorName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDirectorName.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblDirectorName.Location = new System.Drawing.Point(552, 165);
            this.lblDirectorName.Name = "lblDirectorName";
            this.lblDirectorName.Size = new System.Drawing.Size(414, 68);
            this.lblDirectorName.TabIndex = 73;
            this.lblDirectorName.TabStop = false;
            this.lblDirectorName.Text = "Director name";
            this.lblDirectorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDescription
            // 
            this.tbxDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderFocusColor = System.Drawing.SystemColors.Control;
            this.tbxDescription.BorderRadius = 0;
            this.tbxDescription.BorderSize = 2;
            this.tbxDescription.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.tbxDescription.Location = new System.Drawing.Point(552, 263);
            this.tbxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxDescription.PasswordChar = false;
            this.tbxDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxDescription.PlaceholderText = "";
            this.tbxDescription.Readonly = true;
            this.tbxDescription.Size = new System.Drawing.Size(891, 310);
            this.tbxDescription.TabIndex = 72;
            this.tbxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxDescription.Texts = resources.GetString("tbxDescription.Texts");
            this.tbxDescription.UnderlinedStyle = false;
            // 
            // lblMovieName
            // 
            this.lblMovieName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMovieName.Font = new System.Drawing.Font("Comic Sans MS", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblMovieName.Location = new System.Drawing.Point(96, 25);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(1347, 133);
            this.lblMovieName.TabIndex = 71;
            this.lblMovieName.TabStop = false;
            this.lblMovieName.Text = "Movie name";
            this.lblMovieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbImage
            // 
            this.pcbImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(96, 165);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(414, 459);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbImage.TabIndex = 70;
            this.pcbImage.TabStop = false;
            // 
            // panelDivider
            // 
            this.panelDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.panelDivider.Location = new System.Drawing.Point(3, 843);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(1535, 5);
            this.panelDivider.TabIndex = 72;
            // 
            // sliderSimilars
            // 
            this.sliderSimilars.AddCart = null;
            this.sliderSimilars.AddFavourites = null;
            this.sliderSimilars.AddWishlist = null;
            this.sliderSimilars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderSimilars.BookClickEvent = null;
            this.sliderSimilars.ButtonColor = System.Drawing.Color.Transparent;
            this.sliderSimilars.ButtonIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.sliderSimilars.DescriptionFont = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderSimilars.DescriptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.sliderSimilars.DescriptionText = "Discover your next favourite book                                                " +
    "                                                                  ";
            this.sliderSimilars.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderSimilars.LayoutType = WinformUI.Infrastructure.CustomControls.ObjectTypes.Details;
            this.sliderSimilars.Location = new System.Drawing.Point(3, 854);
            this.sliderSimilars.MinimumSize = new System.Drawing.Size(100, 675);
            this.sliderSimilars.MovieClickEvent = null;
            this.sliderSimilars.Name = "sliderSimilars";
            this.sliderSimilars.Size = new System.Drawing.Size(1530, 675);
            this.sliderSimilars.TabIndex = 74;
            this.sliderSimilars.TitleFont = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderSimilars.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.sliderSimilars.TitleText = "People also like                                                                 " +
    "   ";
            this.sliderSimilars.Type = WinformUI.Infrastructure.CustomControls.SliderType.Book;
            // 
            // panelDivider2
            // 
            this.panelDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.panelDivider2.Location = new System.Drawing.Point(3, 1535);
            this.panelDivider2.Name = "panelDivider2";
            this.panelDivider2.Size = new System.Drawing.Size(1535, 5);
            this.panelDivider2.TabIndex = 76;
            // 
            // panelReviews
            // 
            this.panelReviews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelReviews.Controls.Add(this.tableLayoutPanel1);
            this.panelReviews.Location = new System.Drawing.Point(3, 1546);
            this.panelReviews.Name = "panelReviews";
            this.panelReviews.Size = new System.Drawing.Size(1530, 486);
            this.panelReviews.TabIndex = 77;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelReviewItems, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1530, 486);
            this.tableLayoutPanel1.TabIndex = 83;
            // 
            // panelReviewItems
            // 
            this.panelReviewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReviewItems.Location = new System.Drawing.Point(3, 124);
            this.panelReviewItems.Name = "panelReviewItems";
            this.panelReviewItems.Size = new System.Drawing.Size(1524, 359);
            this.panelReviewItems.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblReviews);
            this.panel1.Controls.Add(this.btnAddReview);
            this.panel1.Controls.Add(this.tbxReview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1524, 115);
            this.panel1.TabIndex = 0;
            // 
            // lblReviews
            // 
            this.lblReviews.BackColor = System.Drawing.Color.Transparent;
            this.lblReviews.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblReviews.Location = new System.Drawing.Point(3, 12);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Opacity = 0;
            this.lblReviews.Size = new System.Drawing.Size(602, 88);
            this.lblReviews.TabIndex = 0;
            this.lblReviews.Text = "Reviews :              ";
            this.lblReviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReviews.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // btnAddReview
            // 
            this.btnAddReview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddReview.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReview.FlatAppearance.BorderSize = 0;
            this.btnAddReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReview.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddReview.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddReview.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnAddReview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddReview.IconSize = 60;
            this.btnAddReview.Location = new System.Drawing.Point(1286, 21);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(219, 68);
            this.btnAddReview.TabIndex = 81;
            this.btnAddReview.Text = "Add review";
            this.btnAddReview.UseVisualStyleBackColor = false;
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // tbxReview
            // 
            this.tbxReview.BackColor = System.Drawing.SystemColors.Window;
            this.tbxReview.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxReview.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxReview.BorderRadius = 0;
            this.tbxReview.BorderSize = 2;
            this.tbxReview.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReview.ForeColor = System.Drawing.Color.DimGray;
            this.tbxReview.Location = new System.Drawing.Point(837, 13);
            this.tbxReview.Margin = new System.Windows.Forms.Padding(4);
            this.tbxReview.Multiline = true;
            this.tbxReview.Name = "tbxReview";
            this.tbxReview.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.tbxReview.PasswordChar = false;
            this.tbxReview.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.tbxReview.PlaceholderText = "";
            this.tbxReview.Readonly = false;
            this.tbxReview.Size = new System.Drawing.Size(428, 88);
            this.tbxReview.TabIndex = 82;
            this.tbxReview.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxReview.Texts = "";
            this.tbxReview.UnderlinedStyle = false;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 1055);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieForm";
            this.Text = "MovieForm";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.panelReviews.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelMain;
        private System.Windows.Forms.Panel panelInfo;
        private FontAwesome.Sharp.IconButton btnAddCart;
        private FontAwesome.Sharp.IconButton btnAddWishList;
        private FontAwesome.Sharp.IconButton btnAddFavourites;
        private Infrastructure.CustomControls.TransparentLabel lblPrice;
        private Infrastructure.CustomControls.TransparentLabel lblActors;
        private Infrastructure.CustomControls.TransparentLabel lblReleaseDate;
        private Infrastructure.CustomControls.TransparentLabel lblTime;
        private Infrastructure.CustomControls.TransparentLabel lblDirectorName;
        private Infrastructure.CustomControls.DevTextBox tbxDescription;
        private Infrastructure.CustomControls.TransparentLabel lblMovieName;
        private Infrastructure.CustomControls.TransparentPictureBox pcbImage;
        private System.Windows.Forms.Panel panelDivider;
        private Infrastructure.CustomControls.Slider sliderSimilars;
        private System.Windows.Forms.Panel panelDivider2;
        private System.Windows.Forms.Panel panelReviews;
        private Infrastructure.CustomControls.TransparentLabelNew lblReviews;
        private Infrastructure.CustomControls.TransparentLabel lblImdb;
        private Infrastructure.CustomControls.TransparentLabel lblGenres;
        private Infrastructure.CustomControls.RatingControl rtcMovie;
        private Infrastructure.CustomControls.DevTextBox tbxReview;
        private FontAwesome.Sharp.IconButton btnAddReview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelReviewItems;
    }
}