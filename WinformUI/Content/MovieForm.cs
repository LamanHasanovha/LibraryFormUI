using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class MovieForm : BaseForm
    {
        private readonly IMovieService _movieService;
        private readonly IRatingService _ratingService;
        private readonly IReviewService _reviewService;
        private readonly IActivityService _activityService;
        private readonly IRecommenderService _recommenderService;
        private readonly IMovieFavListService _movieFavListService;
        private readonly IMovieWishListService _movieWishListService;
        private readonly ICartService _cartService;

        public MovieForm()
        {
            InitializeComponent();
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _ratingService = new RatingManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _reviewService = new ReviewManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _activityService = new ActivityManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _recommenderService = new RecommenderManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieFavListService = new MovieFavListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieWishListService = new MovieWishListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                 new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _cartService = new CartManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                 new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

            rtcMovie.SetRating = SetRating;
            rtcMovie.ReloadRating = ReloadRating;
            
        }

        private void MovieForm_Load(object sender, System.EventArgs e)
        {
            Build();
            _activityService.Add(new Activity
            {
                AccountId = Account.Id,
                ProductType = ProductTypes.Movie,
                RecordId = RecordId
            });
        }

        private void Build()
        {
            var movie = _movieService.GetMovieById(RecordId);

            lblMovieName.Text = movie.Name;
            lblImdb.Text = string.Format("{0:0.0}", movie.Imdb);
            lblReleaseDate.Text = movie.ReleaseDate.ToString("dd MMMM yyyy");
            var time = new TimeSpan(movie.Time);
            lblTime.Text = time.Hours + "h " + time.Minutes + "m";
            tbxDescription.Texts = movie.Description;
            lblDirectorName.Text = movie.Director;
            try
            {
                pcbImage.Load(movie.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.movie;
            }
            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", movie.Price);
            lblGenres.Text = string.Join(", ", movie.Genres.Select(g => g.Name));
            lblActors.Text = string.Join(", ", movie.Actors.Select(g => g.FirstName + " " + g.LastName));

            LoadSimilars();
            LoadReviews();

            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Movie);
            if (ratings.Count > 0)
            {
                rtcMovie.RatingReport = ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
                var temp = ratings.FirstOrDefault(r => r.AccountId == Account.Id);
                if (temp != null)
                    rtcMovie.Value = temp.Value;
            }
            else
                rtcMovie.RatingReport = 0 + "\n" + ratings.Count;

        }


        private void LoadSimilars()
        {
            var movies = _recommenderService.GetMovies(RecordId, 20);

            foreach (var movie in movies)
            {
                var item = new MovieSliderObject();
                item.Build(movie);
                sliderSimilars.Add(item);
            }
        }

        private void LoadReviews()
        {
            var currentReview = _reviewService.GetByAccount(Account.Id, RecordId, RatingTypes.Movie);
            if(currentReview != null)
            {
                btnAddReview.Visible = tbxReview.Visible = false;
            }

            var reviews = _reviewService.GetByType(RecordId, RatingTypes.Movie);
            if (reviews == null)
                return;
            foreach (var review in reviews)
            {
                var item = new ReviewItem();
                item.UsernameText = review.Username;
                item.DateText = review.Date.ToString("dd.MM.yyyy");
                item.ReviewText = review.Text;
                item.Dock = DockStyle.Top;
                item.Margin = new Padding(3, 10, 3, 20);

                panelReviewItems.Controls.Add(item);
                panelReviewItems.Controls.Add(CreateDivider());
            }
        }

        private string ReloadRating()
        {
            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Movie);
            if (ratings.Count > 0)
                return ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
            else
                return "0\n0";
        }

        private void SetRating(int rating)
        {
            _ratingService.SaveRating(new Rating
            {
                AccountId = Account.Id,
                RecordId = RecordId,
                Type = RatingTypes.Movie,
                Value = rating
            });
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            var review = new Review
            {
                AccountId = Account.Id,
                Date = DateTime.Now,
                RecordId = RecordId,
                Type = RatingTypes.Movie,
                Text = tbxReview.Texts
            };
            _reviewService.Add(review);

            btnAddReview.Visible = tbxReview.Visible = false;

            var item = new ReviewItem();
            item.UsernameText = Account.Username;
            item.DateText = review.Date.ToString("dd.MM.yyyy");
            item.ReviewText = review.Text;
            item.Dock = DockStyle.Top;
            item.Margin = new Padding(3, 10, 3, 20);

            panelReviewItems.Controls.Add(item);
        }

        private void btnAddFavourites_Click(object sender, EventArgs e)
        {
            var data = _movieFavListService.GetByAccount(Account.Id)?.Where(b => b.Id == RecordId).ToList();
            if (data is null | data.Count == 0)
            {
                _movieFavListService.Add(new MovieFavList
                {
                    MovieId = RecordId,
                    AccountId = Account.Id,
                });
            }
            else
            {
                _movieFavListService.Delete(new MovieFavList { Id = data.FirstOrDefault().Id });
            }
        }

        private void btnAddWishList_Click(object sender, EventArgs e)
        {
            var data = _movieWishListService.GetByAccount(Account.Id)?.Where(b => b.Id == RecordId).ToList();
            if (data is null | data.Count == 0)
            {
                _movieWishListService.Add(new MovieWishList
                {
                    MovieId = RecordId,
                    AccountId = Account.Id,
                });
            }
            else
            {
                _movieWishListService.Delete(new MovieWishList { Id = data.FirstOrDefault().Id });
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            var data = _cartService.GetByAccount(Account.Id)?.Where(c => c.ProductType == ProductTypes.Movie & c.RecordId == RecordId).ToList();
            if (data is null | data.Count == 0)
            {
                _cartService.Add(new Cart
                {
                    RecordId = RecordId,
                    AccountId = Account.Id,
                    Type = ProductTypes.Movie
                });
            }
            else
            {
                _cartService.Delete(new Cart { Id = data.FirstOrDefault().Id });
            }
        }

        private Panel CreateDivider()
        {
            return new Panel
            {
                Dock = DockStyle.Top,
                Height = 4,
                BackColor = Color.FromArgb(68, 132, 188)
            };
        }
    }
}
