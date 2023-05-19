namespace WinformUI.Infrastructure.CustomControls
{
    partial class MultiSelector
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
            this.panelMain = new WinformUI.Infrastructure.CustomControls.TransparentTableLayoutPanel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.lblSelectedItems = new WinformUI.Infrastructure.CustomControls.TransparentLabelNew();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.ColumnCount = 2;
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.panelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelMain.Controls.Add(this.btnSearch, 1, 0);
            this.panelMain.Controls.Add(this.lblSelectedItems, 0, 0);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.RowCount = 1;
            this.panelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMain.Size = new System.Drawing.Size(300, 49);
            this.panelMain.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 45;
            this.btnSearch.Location = new System.Drawing.Point(243, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(54, 43);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSelectedItems.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedItems.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSelectedItems.Location = new System.Drawing.Point(3, 0);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Opacity = 50;
            this.lblSelectedItems.Size = new System.Drawing.Size(234, 49);
            this.lblSelectedItems.TabIndex = 1;
            this.lblSelectedItems.Text = "No item selected";
            this.lblSelectedItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSelectedItems.TransparentBackColor = System.Drawing.Color.Black;
            // 
            // MultiSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MultiSelector";
            this.Size = new System.Drawing.Size(300, 49);
            this.Load += new System.EventHandler(this.MultiSelector_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TransparentTableLayoutPanel panelMain;
        private FontAwesome.Sharp.IconButton btnSearch;
        private TransparentLabelNew lblSelectedItems;
    }
}
