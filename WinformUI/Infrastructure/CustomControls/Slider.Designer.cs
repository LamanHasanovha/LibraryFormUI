namespace WinformUI.Infrastructure.CustomControls
{
    partial class Slider
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
            this.components = new System.ComponentModel.Container();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHead = new System.Windows.Forms.TableLayoutPanel();
            this.panelTitleDesciption = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnRight = new FontAwesome.Sharp.IconButton();
            this.btnLeft = new FontAwesome.Sharp.IconButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.timerLeft = new System.Windows.Forms.Timer(this.components);
            this.timerRight = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.lblDescription = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelHeader.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.panelTitleDesciption.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelHead);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.panelHeader.Size = new System.Drawing.Size(1000, 135);
            this.panelHeader.TabIndex = 0;
            // 
            // panelHead
            // 
            this.panelHead.ColumnCount = 2;
            this.panelHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.panelHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.panelHead.Controls.Add(this.panelTitleDesciption, 0, 0);
            this.panelHead.Controls.Add(this.panelButtons, 1, 0);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHead.Location = new System.Drawing.Point(10, 11);
            this.panelHead.Name = "panelHead";
            this.panelHead.RowCount = 1;
            this.panelHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelHead.Size = new System.Drawing.Size(980, 113);
            this.panelHead.TabIndex = 0;
            // 
            // panelTitleDesciption
            // 
            this.panelTitleDesciption.ColumnCount = 1;
            this.panelTitleDesciption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelTitleDesciption.Controls.Add(this.lblDescription, 0, 1);
            this.panelTitleDesciption.Controls.Add(this.lblTitle, 0, 0);
            this.panelTitleDesciption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTitleDesciption.Location = new System.Drawing.Point(3, 3);
            this.panelTitleDesciption.Name = "panelTitleDesciption";
            this.panelTitleDesciption.RowCount = 2;
            this.panelTitleDesciption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panelTitleDesciption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelTitleDesciption.Size = new System.Drawing.Size(827, 107);
            this.panelTitleDesciption.TabIndex = 2;
            // 
            // panelButtons
            // 
            this.panelButtons.ColumnCount = 2;
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButtons.Controls.Add(this.btnRight, 1, 0);
            this.panelButtons.Controls.Add(this.btnLeft, 0, 0);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(836, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(15, 17, 15, 17);
            this.panelButtons.RowCount = 1;
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelButtons.Size = new System.Drawing.Size(141, 107);
            this.panelButtons.TabIndex = 3;
            // 
            // btnRight
            // 
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.FlatAppearance.BorderSize = 0;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnRight.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRight.IconSize = 40;
            this.btnRight.Location = new System.Drawing.Point(73, 20);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(50, 67);
            this.btnRight.TabIndex = 0;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.FlatAppearance.BorderSize = 0;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnLeft.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeft.IconSize = 40;
            this.btnLeft.Location = new System.Drawing.Point(18, 20);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(49, 67);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 135);
            this.panelMain.MinimumSize = new System.Drawing.Size(100, 540);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1000, 540);
            this.panelMain.TabIndex = 4;
            // 
            // timerLeft
            // 
            this.timerLeft.Interval = 5;
            this.timerLeft.Tick += new System.EventHandler(this.timerLeft_Tick);
            // 
            // timerRight
            // 
            this.timerRight.Interval = 5;
            this.timerRight.Tick += new System.EventHandler(this.timerRight_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Opacity = 0;
            this.lblTitle.Size = new System.Drawing.Size(821, 74);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 74);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Opacity = 0;
            this.lblDescription.Size = new System.Drawing.Size(821, 33);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDescription.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(100, 675);
            this.Name = "Slider";
            this.Size = new System.Drawing.Size(1000, 675);
            this.Load += new System.EventHandler(this.Slider_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelTitleDesciption.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnLeft;
        private FontAwesome.Sharp.IconButton btnRight;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Timer timerLeft;
        private System.Windows.Forms.Timer timerRight;
        private System.Windows.Forms.TableLayoutPanel panelHead;
        private System.Windows.Forms.TableLayoutPanel panelTitleDesciption;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
        private TransparentLabelNew lblTitle;
        private TransparentLabelNew lblDescription;
    }
}
