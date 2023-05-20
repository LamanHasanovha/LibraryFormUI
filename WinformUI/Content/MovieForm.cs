using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class MovieForm : BaseForm
    {
        private readonly IMovieService _movieService;
        private readonly IRatingService _ratingService;

        public MovieForm()
        {
            InitializeComponent();
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _ratingService = new RatingManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            rtcMovie.SetRating = SetRating;
            rtcMovie.ReloadRating = ReloadRating;
        }

        private void MovieForm_Load(object sender, System.EventArgs e)
        {
            Build();
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
            rtcMovie.RatingReport = ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
        }


        private void LoadSimilars()
        {

        }

        private void LoadReviews()
        {

        }

        private string ReloadRating()
        {
            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Movie);
            return ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
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

    }
}
