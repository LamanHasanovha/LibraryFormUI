namespace WinformUI.Infrastructure.CustomControls
{
    partial class SpecialSlider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialSlider));
            this.timerLeft = new System.Windows.Forms.Timer(this.components);
            this.timerRight = new System.Windows.Forms.Timer(this.components);
            this.panelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelSidebar = new System.Windows.Forms.TableLayoutPanel();
            this.pcbImage = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.panelButton = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.btnShowAll = new FontAwesome.Sharp.IconButton();
            this.lblDescription = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelContent = new System.Windows.Forms.TableLayoutPanel();
            this.panelArrows = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.btnLeft = new FontAwesome.Sharp.IconButton();
            this.btnRight = new FontAwesome.Sharp.IconButton();
            this.panelHelper = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.panelSlider = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.panelMain.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.panelButton.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelArrows.SuspendLayout();
            this.panelHelper.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerLeft
            // 
            this.timerLeft.Interval = 1;
            this.timerLeft.Tick += new System.EventHandler(this.timerLeft_Tick);
            // 
            // timerRight
            // 
            this.timerRight.Interval = 1;
            this.timerRight.Tick += new System.EventHandler(this.timerRight_Tick);
            // 
            // panelMain
            // 
            this.panelMain.ColumnCount = 2;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panelMain.Controls.Add(this.panelSidebar, 0, 0);
            this.panelMain.Controls.Add(this.panelContent, 1, 0);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(30, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 1;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Size = new System.Drawing.Size(940, 615);
            this.panelMain.TabIndex = 0;
            // 
            // panelSidebar
            // 
            this.panelSidebar.ColumnCount = 1;
            this.panelSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelSidebar.Controls.Add(this.pcbImage, 0, 0);
            this.panelSidebar.Controls.Add(this.panelButton, 0, 2);
            this.panelSidebar.Controls.Add(this.lblDescription, 0, 1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.Location = new System.Drawing.Point(3, 3);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.RowCount = 3;
            this.panelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.panelSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelSidebar.Size = new System.Drawing.Size(276, 609);
            this.panelSidebar.TabIndex = 0;
            // 
            // pcbImage
            // 
            this.pcbImage.BackColor = System.Drawing.Color.Transparent;
            this.pcbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbImage.Image = ((System.Drawing.Image)(resources.GetObject("pcbImage.Image")));
            this.pcbImage.Location = new System.Drawing.Point(3, 3);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(270, 237);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 0;
            this.pcbImage.TabStop = false;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.btnShowAll);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButton.Location = new System.Drawing.Point(3, 489);
            this.panelButton.Name = "panelButton";
            this.panelButton.Padding = new System.Windows.Forms.Padding(30);
            this.panelButton.Size = new System.Drawing.Size(270, 117);
            this.panelButton.TabIndex = 1;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAll.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowAll.IconChar = FontAwesome.Sharp.IconChar.NfcSymbol;
            this.btnShowAll.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShowAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShowAll.Location = new System.Drawing.Point(30, 30);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(210, 57);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "SEE ALL";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAll.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescription.Location = new System.Drawing.Point(3, 243);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Opacity = 0;
            this.lblDescription.Size = new System.Drawing.Size(270, 243);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            this.lblDescription.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // panelContent
            // 
            this.panelContent.ColumnCount = 1;
            this.panelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelContent.Controls.Add(this.panelArrows, 0, 0);
            this.panelContent.Controls.Add(this.panelHelper, 0, 1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(285, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.RowCount = 2;
            this.panelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.panelContent.Size = new System.Drawing.Size(652, 609);
            this.panelContent.TabIndex = 1;
            // 
            // panelArrows
            // 
            this.panelArrows.BackColor = System.Drawing.Color.Transparent;
            this.panelArrows.Controls.Add(this.btnLeft);
            this.panelArrows.Controls.Add(this.btnRight);
            this.panelArrows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArrows.Location = new System.Drawing.Point(3, 3);
            this.panelArrows.Name = "panelArrows";
            this.panelArrows.Size = new System.Drawing.Size(646, 54);
            this.panelArrows.TabIndex = 4;
            // 
            // btnLeft
            // 
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeft.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLeft.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnLeft.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeft.IconSize = 40;
            this.btnLeft.Location = new System.Drawing.Point(486, 0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(80, 54);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRight.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRight.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnRight.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRight.IconSize = 40;
            this.btnRight.Location = new System.Drawing.Point(566, 0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 54);
            this.btnRight.TabIndex = 3;
            this.btnRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseUp);
            // 
            // panelHelper
            // 
            this.panelHelper.BackColor = System.Drawing.Color.Transparent;
            this.panelHelper.Controls.Add(this.panelSlider);
            this.panelHelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHelper.Location = new System.Drawing.Point(3, 63);
            this.panelHelper.Name = "panelHelper";
            this.panelHelper.Padding = new System.Windows.Forms.Padding(50, 40, 0, 0);
            this.panelHelper.Size = new System.Drawing.Size(646, 543);
            this.panelHelper.TabIndex = 5;
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.Transparent;
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSlider.Location = new System.Drawing.Point(50, 40);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(596, 503);
            this.panelSlider.TabIndex = 5;
            // 
            // SpecialSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(100, 675);
            this.Name = "SpecialSlider";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Size = new System.Drawing.Size(1000, 675);
            this.Load += new System.EventHandler(this.SpecialSlider_Load);
            this.panelMain.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelArrows.ResumeLayout(false);
            this.panelHelper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerLeft;
        private System.Windows.Forms.Timer timerRight;
        private System.Windows.Forms.TableLayoutPanel panelMain;
        private System.Windows.Forms.TableLayoutPanel panelSidebar;
        private TransparentPictureBox pcbImage;
        private TransparentPanel panelButton;
        private FontAwesome.Sharp.IconButton btnShowAll;
        private TransparentLabelNew lblDescription;
        private System.Windows.Forms.TableLayoutPanel panelContent;
        private TransparentPanel panelArrows;
        private FontAwesome.Sharp.IconButton btnLeft;
        private FontAwesome.Sharp.IconButton btnRight;
        private TransparentPanel panelSlider;
        private TransparentPanel panelHelper;
    }
}
