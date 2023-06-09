﻿namespace WinformUI.Infrastructure.CustomControls
{
    partial class SearchDropDownForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelPrice = new System.Windows.Forms.Panel();
            this.nudMaxValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMinValue = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelActors = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton9 = new FontAwesome.Sharp.IconButton();
            this.iconButton10 = new FontAwesome.Sharp.IconButton();
            this.lblActors = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelDirectors = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.lblDirectors = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelAuthors = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.lblAuthors = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelMovieGenres = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.lblMovieGenres = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelBookGenres = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblBookGenres = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelProductTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMovie = new FontAwesome.Sharp.IconButton();
            this.btnBook = new FontAwesome.Sharp.IconButton();
            this.lblProductType = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.btnApply = new FontAwesome.Sharp.IconButton();
            this.panelContainer.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).BeginInit();
            this.panelActors.SuspendLayout();
            this.panelDirectors.SuspendLayout();
            this.panelAuthors.SuspendLayout();
            this.panelMovieGenres.SuspendLayout();
            this.panelBookGenres.SuspendLayout();
            this.panelProductTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.panelContainer.Controls.Add(this.btnClose);
            this.panelContainer.Controls.Add(this.panelMain);
            this.panelContainer.Controls.Add(this.btnApply);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(3, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(18, 60, 18, 20);
            this.panelContainer.Size = new System.Drawing.Size(634, 634);
            this.panelContainer.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 30;
            this.btnClose.Location = new System.Drawing.Point(596, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelPrice);
            this.panelMain.Controls.Add(this.lblPrice);
            this.panelMain.Controls.Add(this.panelActors);
            this.panelMain.Controls.Add(this.lblActors);
            this.panelMain.Controls.Add(this.panelDirectors);
            this.panelMain.Controls.Add(this.lblDirectors);
            this.panelMain.Controls.Add(this.panelAuthors);
            this.panelMain.Controls.Add(this.lblAuthors);
            this.panelMain.Controls.Add(this.panelMovieGenres);
            this.panelMain.Controls.Add(this.lblMovieGenres);
            this.panelMain.Controls.Add(this.panelBookGenres);
            this.panelMain.Controls.Add(this.lblBookGenres);
            this.panelMain.Controls.Add(this.panelProductTypes);
            this.panelMain.Controls.Add(this.lblProductType);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(18, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(598, 554);
            this.panelMain.TabIndex = 4;
            // 
            // panelPrice
            // 
            this.panelPrice.BackColor = System.Drawing.Color.Transparent;
            this.panelPrice.Controls.Add(this.nudMaxValue);
            this.panelPrice.Controls.Add(this.label1);
            this.panelPrice.Controls.Add(this.nudMinValue);
            this.panelPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrice.Location = new System.Drawing.Point(0, 850);
            this.panelPrice.Name = "panelPrice";
            this.panelPrice.Size = new System.Drawing.Size(577, 50);
            this.panelPrice.TabIndex = 14;
            // 
            // nudMaxValue
            // 
            this.nudMaxValue.BackColor = System.Drawing.Color.Gainsboro;
            this.nudMaxValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMaxValue.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMaxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.nudMaxValue.Location = new System.Drawing.Point(123, 6);
            this.nudMaxValue.Name = "nudMaxValue";
            this.nudMaxValue.Size = new System.Drawing.Size(84, 38);
            this.nudMaxValue.TabIndex = 2;
            this.nudMaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaxValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMaxValue.ValueChanged += new System.EventHandler(this.nudMaxValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.label1.Location = new System.Drawing.Point(95, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "-";
            // 
            // nudMinValue
            // 
            this.nudMinValue.BackColor = System.Drawing.Color.Gainsboro;
            this.nudMinValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nudMinValue.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.nudMinValue.Location = new System.Drawing.Point(5, 6);
            this.nudMinValue.Name = "nudMinValue";
            this.nudMinValue.Size = new System.Drawing.Size(84, 38);
            this.nudMinValue.TabIndex = 0;
            this.nudMinValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMinValue.ValueChanged += new System.EventHandler(this.nudMinValue_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblPrice.Location = new System.Drawing.Point(0, 808);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Opacity = 0;
            this.lblPrice.Size = new System.Drawing.Size(577, 42);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price                                                        ";
            this.lblPrice.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // panelActors
            // 
            this.panelActors.BackColor = System.Drawing.Color.Transparent;
            this.panelActors.Controls.Add(this.iconButton9);
            this.panelActors.Controls.Add(this.iconButton10);
            this.panelActors.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActors.Location = new System.Drawing.Point(0, 708);
            this.panelActors.Name = "panelActors";
            this.panelActors.Size = new System.Drawing.Size(577, 100);
            this.panelActors.TabIndex = 12;
            // 
            // iconButton9
            // 
            this.iconButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton9.FlatAppearance.BorderSize = 0;
            this.iconButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton9.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton9.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton9.IconSize = 40;
            this.iconButton9.Location = new System.Drawing.Point(3, 3);
            this.iconButton9.Name = "iconButton9";
            this.iconButton9.Size = new System.Drawing.Size(195, 50);
            this.iconButton9.TabIndex = 4;
            this.iconButton9.Text = "R. Gosling";
            this.iconButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton9.UseVisualStyleBackColor = true;
            this.iconButton9.Click += new System.EventHandler(this.Button_Click);
            // 
            // iconButton10
            // 
            this.iconButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton10.FlatAppearance.BorderSize = 0;
            this.iconButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton10.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton10.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton10.IconSize = 40;
            this.iconButton10.Location = new System.Drawing.Point(204, 3);
            this.iconButton10.Name = "iconButton10";
            this.iconButton10.Size = new System.Drawing.Size(195, 50);
            this.iconButton10.TabIndex = 5;
            this.iconButton10.Text = "A. Adams";
            this.iconButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton10.UseVisualStyleBackColor = true;
            this.iconButton10.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblActors
            // 
            this.lblActors.BackColor = System.Drawing.Color.Transparent;
            this.lblActors.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActors.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblActors.Location = new System.Drawing.Point(0, 666);
            this.lblActors.Name = "lblActors";
            this.lblActors.Opacity = 0;
            this.lblActors.Size = new System.Drawing.Size(577, 42);
            this.lblActors.TabIndex = 11;
            this.lblActors.Text = "Actors                                                       ";
            this.lblActors.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // panelDirectors
            // 
            this.panelDirectors.BackColor = System.Drawing.Color.Transparent;
            this.panelDirectors.Controls.Add(this.iconButton7);
            this.panelDirectors.Controls.Add(this.iconButton8);
            this.panelDirectors.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDirectors.Location = new System.Drawing.Point(0, 566);
            this.panelDirectors.Name = "panelDirectors";
            this.panelDirectors.Size = new System.Drawing.Size(577, 100);
            this.panelDirectors.TabIndex = 10;
            // 
            // iconButton7
            // 
            this.iconButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 40;
            this.iconButton7.Location = new System.Drawing.Point(3, 3);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(195, 50);
            this.iconButton7.TabIndex = 4;
            this.iconButton7.Text = "R. Curtis";
            this.iconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton7.UseVisualStyleBackColor = true;
            this.iconButton7.Click += new System.EventHandler(this.Button_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 40;
            this.iconButton8.Location = new System.Drawing.Point(204, 3);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(195, 50);
            this.iconButton8.TabIndex = 5;
            this.iconButton8.Text = "P. Weir";
            this.iconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton8.UseVisualStyleBackColor = true;
            this.iconButton8.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblDirectors
            // 
            this.lblDirectors.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectors.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDirectors.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblDirectors.Location = new System.Drawing.Point(0, 524);
            this.lblDirectors.Name = "lblDirectors";
            this.lblDirectors.Opacity = 0;
            this.lblDirectors.Size = new System.Drawing.Size(577, 42);
            this.lblDirectors.TabIndex = 9;
            this.lblDirectors.Text = "Directors                                                     ";
            this.lblDirectors.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // panelAuthors
            // 
            this.panelAuthors.BackColor = System.Drawing.Color.Transparent;
            this.panelAuthors.Controls.Add(this.iconButton5);
            this.panelAuthors.Controls.Add(this.iconButton6);
            this.panelAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAuthors.Location = new System.Drawing.Point(0, 424);
            this.panelAuthors.Name = "panelAuthors";
            this.panelAuthors.Size = new System.Drawing.Size(577, 100);
            this.panelAuthors.TabIndex = 8;
            // 
            // iconButton5
            // 
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 40;
            this.iconButton5.Location = new System.Drawing.Point(3, 3);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(195, 50);
            this.iconButton5.TabIndex = 4;
            this.iconButton5.Text = "A. Cristie";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.Button_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 40;
            this.iconButton6.Location = new System.Drawing.Point(204, 3);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(195, 50);
            this.iconButton6.TabIndex = 5;
            this.iconButton6.Text = "H. Wales";
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblAuthors
            // 
            this.lblAuthors.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthors.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAuthors.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblAuthors.Location = new System.Drawing.Point(0, 382);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Opacity = 0;
            this.lblAuthors.Size = new System.Drawing.Size(577, 42);
            this.lblAuthors.TabIndex = 7;
            this.lblAuthors.Text = "Authors                                                       ";
            this.lblAuthors.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // panelMovieGenres
            // 
            this.panelMovieGenres.BackColor = System.Drawing.Color.Transparent;
            this.panelMovieGenres.Controls.Add(this.iconButton3);
            this.panelMovieGenres.Controls.Add(this.iconButton4);
            this.panelMovieGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMovieGenres.Location = new System.Drawing.Point(0, 282);
            this.panelMovieGenres.Name = "panelMovieGenres";
            this.panelMovieGenres.Size = new System.Drawing.Size(577, 100);
            this.panelMovieGenres.TabIndex = 6;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 40;
            this.iconButton3.Location = new System.Drawing.Point(3, 3);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(195, 50);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Sci Fi";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.Button_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 40;
            this.iconButton4.Location = new System.Drawing.Point(204, 3);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(195, 50);
            this.iconButton4.TabIndex = 5;
            this.iconButton4.Text = "Adventure";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblMovieGenres
            // 
            this.lblMovieGenres.BackColor = System.Drawing.Color.Transparent;
            this.lblMovieGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMovieGenres.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblMovieGenres.Location = new System.Drawing.Point(0, 240);
            this.lblMovieGenres.Name = "lblMovieGenres";
            this.lblMovieGenres.Opacity = 0;
            this.lblMovieGenres.Size = new System.Drawing.Size(577, 42);
            this.lblMovieGenres.TabIndex = 5;
            this.lblMovieGenres.Text = "Movie genres                                                 ";
            this.lblMovieGenres.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // panelBookGenres
            // 
            this.panelBookGenres.BackColor = System.Drawing.Color.Transparent;
            this.panelBookGenres.Controls.Add(this.iconButton1);
            this.panelBookGenres.Controls.Add(this.iconButton2);
            this.panelBookGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookGenres.Location = new System.Drawing.Point(0, 140);
            this.panelBookGenres.Name = "panelBookGenres";
            this.panelBookGenres.Size = new System.Drawing.Size(577, 100);
            this.panelBookGenres.TabIndex = 4;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(195, 50);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.Text = "Action";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.Button_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(204, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(195, 50);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.Text = "Detective";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblBookGenres
            // 
            this.lblBookGenres.BackColor = System.Drawing.Color.Transparent;
            this.lblBookGenres.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookGenres.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblBookGenres.Location = new System.Drawing.Point(0, 98);
            this.lblBookGenres.Name = "lblBookGenres";
            this.lblBookGenres.Opacity = 0;
            this.lblBookGenres.Size = new System.Drawing.Size(577, 42);
            this.lblBookGenres.TabIndex = 3;
            this.lblBookGenres.Text = "Book genres                                                 ";
            this.lblBookGenres.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // panelProductTypes
            // 
            this.panelProductTypes.BackColor = System.Drawing.Color.Transparent;
            this.panelProductTypes.Controls.Add(this.btnMovie);
            this.panelProductTypes.Controls.Add(this.btnBook);
            this.panelProductTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductTypes.Location = new System.Drawing.Point(0, 42);
            this.panelProductTypes.Name = "panelProductTypes";
            this.panelProductTypes.Size = new System.Drawing.Size(577, 56);
            this.panelProductTypes.TabIndex = 1;
            // 
            // btnMovie
            // 
            this.btnMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovie.FlatAppearance.BorderSize = 0;
            this.btnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovie.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnMovie.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnMovie.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovie.IconSize = 40;
            this.btnMovie.Location = new System.Drawing.Point(3, 3);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(195, 50);
            this.btnMovie.TabIndex = 2;
            this.btnMovie.Tag = "1 Movie";
            this.btnMovie.Text = "Movie";
            this.btnMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.Click += new System.EventHandler(this.Button_Click);
            // 
            // btnBook
            // 
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnBook.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBook.IconSize = 40;
            this.btnBook.Location = new System.Drawing.Point(204, 3);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(195, 50);
            this.btnBook.TabIndex = 3;
            this.btnBook.Tag = "2 Book";
            this.btnBook.Text = "Book";
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.Button_Click);
            // 
            // lblProductType
            // 
            this.lblProductType.BackColor = System.Drawing.Color.Transparent;
            this.lblProductType.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductType.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblProductType.Location = new System.Drawing.Point(0, 0);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Opacity = 0;
            this.lblProductType.Size = new System.Drawing.Size(577, 42);
            this.lblProductType.TabIndex = 0;
            this.lblProductType.Text = "Product type                                                ";
            this.lblProductType.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // btnApply
            // 
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.btnApply.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnApply.IconColor = System.Drawing.Color.Black;
            this.btnApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApply.Location = new System.Drawing.Point(4, 6);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(89, 39);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // SearchDropDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchDropDownForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchDropDownForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SearchDropDownForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelPrice.ResumeLayout(false);
            this.panelPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinValue)).EndInit();
            this.panelActors.ResumeLayout(false);
            this.panelDirectors.ResumeLayout(false);
            this.panelAuthors.ResumeLayout(false);
            this.panelMovieGenres.ResumeLayout(false);
            this.panelBookGenres.ResumeLayout(false);
            this.panelProductTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelPrice;
        private System.Windows.Forms.NumericUpDown nudMaxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMinValue;
        private TransparentLabelNew lblPrice;
        private System.Windows.Forms.FlowLayoutPanel panelActors;
        private FontAwesome.Sharp.IconButton iconButton9;
        private FontAwesome.Sharp.IconButton iconButton10;
        private TransparentLabelNew lblActors;
        private System.Windows.Forms.FlowLayoutPanel panelDirectors;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private TransparentLabelNew lblDirectors;
        private System.Windows.Forms.FlowLayoutPanel panelAuthors;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private TransparentLabelNew lblAuthors;
        private System.Windows.Forms.FlowLayoutPanel panelMovieGenres;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TransparentLabelNew lblMovieGenres;
        private System.Windows.Forms.FlowLayoutPanel panelBookGenres;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private TransparentLabelNew lblBookGenres;
        private System.Windows.Forms.FlowLayoutPanel panelProductTypes;
        private FontAwesome.Sharp.IconButton btnMovie;
        private FontAwesome.Sharp.IconButton btnBook;
        private TransparentLabelNew lblProductType;
        private FontAwesome.Sharp.IconButton btnApply;
    }
}