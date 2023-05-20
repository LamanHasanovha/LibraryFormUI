namespace WinformUI.Infrastructure.CustomControls
{
    partial class RatingControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingControl));
            this.panelMain = new WinformUI.Infrastructure.CustomControls.TransparentTableLayoutPanel();
            this.pcbStar5 = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.pcbStar4 = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.pcbStar3 = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.pcbStar2 = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.pcbStar1 = new WinformUI.Infrastructure.CustomControls.TransparentPictureBox();
            this.panelEmpty = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.panelRatingCount = new WinformUI.Infrastructure.CustomControls.TransparentPanel();
            this.lblRatingReport = new WinformUI.Infrastructure.CustomControls.TransparentLabel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar1)).BeginInit();
            this.panelRatingCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.ColumnCount = 7;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.panelMain.Controls.Add(this.pcbStar5, 5, 0);
            this.panelMain.Controls.Add(this.pcbStar4, 4, 0);
            this.panelMain.Controls.Add(this.pcbStar3, 3, 0);
            this.panelMain.Controls.Add(this.pcbStar2, 2, 0);
            this.panelMain.Controls.Add(this.pcbStar1, 1, 0);
            this.panelMain.Controls.Add(this.panelEmpty, 0, 0);
            this.panelMain.Controls.Add(this.panelRatingCount, 6, 0);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 1;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Size = new System.Drawing.Size(448, 99);
            this.panelMain.TabIndex = 0;
            // 
            // pcbStar5
            // 
            this.pcbStar5.BackColor = System.Drawing.Color.Transparent;
            this.pcbStar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStar5.Image = ((System.Drawing.Image)(resources.GetObject("pcbStar5.Image")));
            this.pcbStar5.Location = new System.Drawing.Point(307, 3);
            this.pcbStar5.Name = "pcbStar5";
            this.pcbStar5.Size = new System.Drawing.Size(65, 93);
            this.pcbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar5.TabIndex = 4;
            this.pcbStar5.TabStop = false;
            this.pcbStar5.Click += new System.EventHandler(this.pcbStar5_Click);
            // 
            // pcbStar4
            // 
            this.pcbStar4.BackColor = System.Drawing.Color.Transparent;
            this.pcbStar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStar4.Image = ((System.Drawing.Image)(resources.GetObject("pcbStar4.Image")));
            this.pcbStar4.Location = new System.Drawing.Point(236, 3);
            this.pcbStar4.Name = "pcbStar4";
            this.pcbStar4.Size = new System.Drawing.Size(65, 93);
            this.pcbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar4.TabIndex = 3;
            this.pcbStar4.TabStop = false;
            this.pcbStar4.Click += new System.EventHandler(this.pcbStar4_Click);
            // 
            // pcbStar3
            // 
            this.pcbStar3.BackColor = System.Drawing.Color.Transparent;
            this.pcbStar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStar3.Image = ((System.Drawing.Image)(resources.GetObject("pcbStar3.Image")));
            this.pcbStar3.Location = new System.Drawing.Point(165, 3);
            this.pcbStar3.Name = "pcbStar3";
            this.pcbStar3.Size = new System.Drawing.Size(65, 93);
            this.pcbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar3.TabIndex = 2;
            this.pcbStar3.TabStop = false;
            this.pcbStar3.Click += new System.EventHandler(this.pcbStar3_Click);
            // 
            // pcbStar2
            // 
            this.pcbStar2.BackColor = System.Drawing.Color.Transparent;
            this.pcbStar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStar2.Image = ((System.Drawing.Image)(resources.GetObject("pcbStar2.Image")));
            this.pcbStar2.Location = new System.Drawing.Point(94, 3);
            this.pcbStar2.Name = "pcbStar2";
            this.pcbStar2.Size = new System.Drawing.Size(65, 93);
            this.pcbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar2.TabIndex = 1;
            this.pcbStar2.TabStop = false;
            this.pcbStar2.Click += new System.EventHandler(this.pcbStar2_Click);
            // 
            // pcbStar1
            // 
            this.pcbStar1.BackColor = System.Drawing.Color.Transparent;
            this.pcbStar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbStar1.Image = ((System.Drawing.Image)(resources.GetObject("pcbStar1.Image")));
            this.pcbStar1.Location = new System.Drawing.Point(23, 3);
            this.pcbStar1.Name = "pcbStar1";
            this.pcbStar1.Size = new System.Drawing.Size(65, 93);
            this.pcbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStar1.TabIndex = 0;
            this.pcbStar1.TabStop = false;
            this.pcbStar1.Click += new System.EventHandler(this.pcbStar1_Click);
            // 
            // panelEmpty
            // 
            this.panelEmpty.BackColor = System.Drawing.Color.Transparent;
            this.panelEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmpty.Location = new System.Drawing.Point(3, 3);
            this.panelEmpty.Name = "panelEmpty";
            this.panelEmpty.Size = new System.Drawing.Size(14, 93);
            this.panelEmpty.TabIndex = 5;
            this.panelEmpty.Click += new System.EventHandler(this.panelEmpty_Click);
            // 
            // panelRatingCount
            // 
            this.panelRatingCount.BackColor = System.Drawing.Color.Transparent;
            this.panelRatingCount.Controls.Add(this.lblRatingReport);
            this.panelRatingCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRatingCount.Location = new System.Drawing.Point(378, 3);
            this.panelRatingCount.Name = "panelRatingCount";
            this.panelRatingCount.Size = new System.Drawing.Size(67, 93);
            this.panelRatingCount.TabIndex = 6;
            // 
            // lblRatingReport
            // 
            this.lblRatingReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRatingReport.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.lblRatingReport.Location = new System.Drawing.Point(0, 0);
            this.lblRatingReport.Name = "lblRatingReport";
            this.lblRatingReport.Size = new System.Drawing.Size(67, 93);
            this.lblRatingReport.TabIndex = 36;
            this.lblRatingReport.TabStop = false;
            this.lblRatingReport.Text = "5.6";
            this.lblRatingReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RatingControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(452, 103);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStar1)).EndInit();
            this.panelRatingCount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentTableLayoutPanel panelMain;
        private TransparentPictureBox pcbStar5;
        private TransparentPictureBox pcbStar4;
        private TransparentPictureBox pcbStar3;
        private TransparentPictureBox pcbStar2;
        private TransparentPictureBox pcbStar1;
        private TransparentPanel panelEmpty;
        private TransparentPanel panelRatingCount;
        private TransparentLabel lblRatingReport;
    }
}
