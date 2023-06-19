using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Models.RequestModels;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class SupriseMe : UserControl
    {
        private int _type; // 1-book 2-movie

        [Browsable(false)]
        public Action<object, EventArgs> ShowBookClickEvent { get; set; }

        [Browsable(false)]
        public Action<object, EventArgs> ShowMovieClickEvent { get; set; }
        
        [Browsable(false)]
        public int RecordId { get; set; }

        private readonly IBookService _bookService;
        private readonly IMovieService _movieService;

        public SupriseMe()
        {
            InitializeComponent();
            _type = 0;
            panelContent.Location = new Point(this.Width, this.Height);
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
        }

        protected void MultiColorGradient(object sender, PaintEventArgs e, params Color[] colors)
        {
            using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.Red, Color.Yellow, 45))
            {
                ColorBlend cblend = new ColorBlend(colors.Length)
                {
                    Colors = colors,
                    Positions = CreateGradientPositions(colors.Length)
                };
                linearGradientBrush.InterpolationColors = cblend;

                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            }
        }

        private float[] CreateGradientPositions(int n)
        {
            var positions = new float[n];

            for (int i = 1; i < positions.Length; i++)
            {
                positions[i] = positions[i - 1] + ((float)1 / (n - 1));
            }

            return positions;
        }

        protected void GradientColor(object sender, PaintEventArgs e, Color color1, Color color2)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void SupriseMe_Paint(object sender, PaintEventArgs e)
        {
            MultiColorGradient(sender, e, Color.FromArgb(41, 128, 185), Color.FromArgb(109, 213, 250), Color.FromArgb(255, 255, 255));
        }

        private void btnSupriseMe_Click(object sender, EventArgs e)
        {
            pcbImage.Location = new Point(this.Width, this.Height);
            lblQuestion.Location = new Point(this.Width, this.Height);

            panelContent.Visible = true;

            EnableLoading();
            _type = new Random().Next(1, 3);
            switch (_type)
            {
                case 1:
                    var book = _bookService.GetRandomBook();
                    DisableLoading(book.Image, book.Name, string.Join(", ", book.Genres.Select(g => g.Name)), book.Price);
                    RecordId = book.Id;
                    break;
                case 2:
                    var movie = _movieService.GetRandomMovie();
                    DisableLoading(movie.Image, movie.Name, string.Join(", ", movie.Genres.Select(g=>g.Name)), movie.Price);
                    RecordId = movie.Id;
                    break;
                default:
                    break;
            }
            //DisableLoading("", "About time", "Drama, Scifi", 12.5m);
        }

        private void EnableLoading()
        {
            pcbContentImage.Visible = false;
            lblTitle.Visible = false;
            lblGenres.Visible = false;
            btnShow.Visible = false;
            lblPrice.Visible = false;

            panelContent.Location = new Point((this.Width / 2) - (panelContent.Width / 2), 30);
        }

        private void DisableLoading(string imageUrl, string title, string genres, decimal price)
        {
            try
            {
                pcbContentImage.Load(imageUrl);
            }
            catch 
            {
                switch(_type) 
                { 
                    case 1:
                        pcbContentImage.Image = Properties.Resources.book;
                        break;
                    case 2:
                        pcbContentImage.Image = Properties.Resources.movie;
                        break;
                    default :
                        break;
                }
            }

            lblTitle.Text = title;
            lblGenres.Text = genres;
            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", price);

            pcbContentImage.Visible = true;
            lblTitle.Visible = true;
            lblGenres.Visible = true;
            btnShow.Visible = true;
            lblPrice.Visible = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            switch (_type)
            {
                case 1:
                    ShowBookClickEvent?.Invoke(this, e);
                    break;
                case 2:
                    ShowMovieClickEvent?.Invoke(this, e);
                    break;
                default:
                    break;
            }
        }
    }
}
