using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class ReviewItem : UserControl
    {
        private int radius = 20;
        [DefaultValue(20)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            //using (var path = GetRoundRectagle(bounds, this.Radius))
            //    this.Region = new Region(path);

            //Better round rectangle
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }

        public string ReviewText 
        {
            get => lblReview.Text; 
            set => lblReview.Text = value;
        }

        public Font ReviewFont
        {
            get => lblReview.Font;
            set => lblReview.Font = value;
        }

        public Color ReviewColor
        {
            get => lblReview.ForeColor;
            set => lblReview.ForeColor = value;
        }

        public string UsernameText
        {
            get => lblUsername.Text;
            set => lblUsername.Text = value;
        }

        public Font UsernameFont
        {
            get => lblUsername.Font;
            set => lblUsername.Font = value;
        }

        public Color UsernameColor
        {
            get => lblUsername.ForeColor;
            set => lblUsername.ForeColor = value;
        }

        public string DateText
        {
            get => lblDate.Text;
            set => lblDate.Text = value;
        }

        public Font DateFont
        {
            get => lblDate.Font;
            set => lblDate.Font = value;
        }

        public Color DateColor
        {
            get => lblDate.ForeColor;
            set => lblDate.ForeColor = value;
        }

        public ReviewItem()
        {
            InitializeComponent();
        }

        //public void Build(Review review)
        //{
        //    lblReview.Text = review.ReviewText;
        //    this.Height = lblReview.Height + 12;
        //}

        public void Build(string review, string username, string date)
        {
            lblReview.Text = review;
            lblUsername.Text = username;
            lblDate.Text = date;
            this.Height = lblReview.Height + 65;
        }
    }
}
