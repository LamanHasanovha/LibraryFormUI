using WinformUI.Infrastructure.CustomControls;

namespace WinformUI.Infrastructure.Forms
{
    partial class Test
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchDropdownPanel1 = new WinformUI.Infrastructure.CustomControls.SearchDropdownPanel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchDropdownPanel1
            // 
            this.searchDropdownPanel1.BackColor = System.Drawing.Color.Transparent;
            this.searchDropdownPanel1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchDropdownPanel1.Location = new System.Drawing.Point(249, 54);
            this.searchDropdownPanel1.Name = "searchDropdownPanel1";
            this.searchDropdownPanel1.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.searchDropdownPanel1.Size = new System.Drawing.Size(673, 590);
            this.searchDropdownPanel1.TabIndex = 0;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1260, 735);
            this.Controls.Add(this.searchDropdownPanel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SupriseMe supriseMe1;
        private System.Windows.Forms.Timer timer1;
        private SearchDropdownPanel searchDropdownPanel1;
    }
}