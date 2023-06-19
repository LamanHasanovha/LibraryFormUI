using Entities.Concrete;
using Entities.Models.ResponseModels;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class MovieSliderObject : UserControl
    {
        [Browsable(false)]
        public Action<object, EventArgs> AddFavourites { get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> AddCart { get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> AddWishlist{ get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> ClickEvent { get; set; }
        [Browsable(false)]
        public int RecordId { get; set; }

        private Mode _mode;
        public Mode Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                ChangeMode(value);
            }
        }

        public Color NameColor
        {
            get => lblName.ForeColor;
            set => lblName.ForeColor = value;
        }

        public Color AuthorColor
        {
            get => lblGenre.ForeColor;
            set => lblGenre.ForeColor = value;
        }

        public Color PriceColor
        {
            get => lblPrice.ForeColor;
            set => lblPrice.ForeColor = value;
        }

        public MovieSliderObject()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
        }

        private void SliderObject_Load(object sender, EventArgs e)
        {

        }

        public void Build(Movie movie)
        {
            try
            {
                pcbImage.Load(movie.Image);
            }
            catch 
            {
                pcbImage.Image = Properties.Resources.movie;
            }
            
            lblName.Text = movie.Name;
            //lblGenre.Text = book.Author;
            lblPrice.Text = movie.Price.ToString();
            RecordId = movie.Id;
        }

        public void Build(MovieResponseModel movie)
        {
            try
            {
                pcbImage.Load(movie.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.movie;
            }
            lblName.Text = movie.Name;
            lblGenre.Text = string.Join(",", movie.Genres);
            lblPrice.Text = movie.Price.ToString();
            RecordId = movie.Id;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        protected static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private void btnAddFavourites_Click(object sender, EventArgs e) 
        {
            AddFavourites?.Invoke(this, e);
        }

        private void btnAddWishlist_Click(object sender, EventArgs e) 
        {
            AddWishlist?.Invoke(this, e);
        }

        private void btnAddChart_Click(object sender, EventArgs e) 
        {
            AddCart?.Invoke(this, e);
        }

        private void movieSliderObject_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
        }

        private void ChangeMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.Light:
                    break;
                case Mode.Dark:
                    break;
                default:
                    break;
            }
        }

    }
}
