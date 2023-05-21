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
            this.reviewItem4 = new WinformUI.Infrastructure.CustomControls.ReviewItem();
            this.reviewItem5 = new WinformUI.Infrastructure.CustomControls.ReviewItem();
            this.reviewItem6 = new WinformUI.Infrastructure.CustomControls.ReviewItem();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reviewItem4
            // 
            this.reviewItem4.BackColor = System.Drawing.SystemColors.Control;
            this.reviewItem4.DateColor = System.Drawing.Color.Black;
            this.reviewItem4.DateFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem4.DateText = "20.09.2023";
            this.reviewItem4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem4.Location = new System.Drawing.Point(12, 240);
            this.reviewItem4.MinimumSize = new System.Drawing.Size(400, 110);
            this.reviewItem4.Name = "reviewItem4";
            this.reviewItem4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 30);
            this.reviewItem4.ReviewColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.reviewItem4.ReviewFont = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem4.ReviewText = "User review";
            this.reviewItem4.Size = new System.Drawing.Size(400, 110);
            this.reviewItem4.TabIndex = 3;
            this.reviewItem4.UsernameColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.reviewItem4.UsernameFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem4.UsernameText = "Username";
            // 
            // reviewItem5
            // 
            this.reviewItem5.BackColor = System.Drawing.SystemColors.Control;
            this.reviewItem5.DateColor = System.Drawing.Color.Black;
            this.reviewItem5.DateFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem5.DateText = "20.09.2023";
            this.reviewItem5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem5.Location = new System.Drawing.Point(431, 240);
            this.reviewItem5.MinimumSize = new System.Drawing.Size(400, 110);
            this.reviewItem5.Name = "reviewItem5";
            this.reviewItem5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 30);
            this.reviewItem5.ReviewColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.reviewItem5.ReviewFont = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem5.ReviewText = "User review";
            this.reviewItem5.Size = new System.Drawing.Size(400, 110);
            this.reviewItem5.TabIndex = 4;
            this.reviewItem5.UsernameColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.reviewItem5.UsernameFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem5.UsernameText = "Username";
            // 
            // reviewItem6
            // 
            this.reviewItem6.BackColor = System.Drawing.SystemColors.Control;
            this.reviewItem6.DateColor = System.Drawing.Color.Black;
            this.reviewItem6.DateFont = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem6.DateText = "20.09.2023";
            this.reviewItem6.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem6.Location = new System.Drawing.Point(857, 240);
            this.reviewItem6.MinimumSize = new System.Drawing.Size(400, 110);
            this.reviewItem6.Name = "reviewItem6";
            this.reviewItem6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 30);
            this.reviewItem6.ReviewColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.reviewItem6.ReviewFont = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem6.ReviewText = "User review";
            this.reviewItem6.Size = new System.Drawing.Size(400, 110);
            this.reviewItem6.TabIndex = 5;
            this.reviewItem6.UsernameColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(132)))), ((int)(((byte)(188)))));
            this.reviewItem6.UsernameFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewItem6.UsernameText = "Username";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1260, 735);
            this.Controls.Add(this.reviewItem6);
            this.Controls.Add(this.reviewItem5);
            this.Controls.Add(this.reviewItem4);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SupriseMe supriseMe1;
        private System.Windows.Forms.Timer timer1;
        private ReviewItem reviewItem4;
        private ReviewItem reviewItem5;
        private ReviewItem reviewItem6;
    }
}