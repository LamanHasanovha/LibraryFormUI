using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using System;
using System.Linq;
using System.Net.Http;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class DirectorForm : BaseForm
    {
        private readonly IDirectorService _directorService;
        private readonly IMovieService _movieService;
        private readonly IRatingService _ratingService;

        public DirectorForm()
        {
            InitializeComponent();
            _directorService = new DirectorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                    new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _ratingService = new RatingManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            rtcDirector.SetRating = SetRating;
            rtcDirector.ReloadRating = ReloadRating;
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            Build();
        }

        private void Build()
        {
            var director = _directorService.Get(RecordId);
            lblFullName.Text = director.FirstName + " " + director.LastName;
            lblBirthDate.Text = director.BirthDate.ToString("dd MMMM yyyy");
            tbxDescription.Text = director.Description;
            try
            {
                pcbImage.Load(director.Image);
            }
            catch
            {
                switch (director.Gender)
                {
                    case Gender.Male:
                        pcbImage.Image = Properties.Resources.man;
                        break;
                    case Gender.Female:
                        pcbImage.Image = Properties.Resources.woman;
                        break;
                    default:
                        break;
                }
            }

            var movies = _movieService.GetByDirector(RecordId);
            foreach (var movie in movies)
            {
                var card = new BasicCard();
                card.Build(movie);
                basicSlider.Add(card);
            }

            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Director);
            if (ratings.Count > 0)
            {
                rtcDirector.RatingReport = ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
                var temp = ratings.FirstOrDefault(r => r.AccountId == Account.Id);
                if (temp != null)
                    rtcDirector.Value = temp.Value;
            }
            else
                rtcDirector.RatingReport = "0\n0";
        }

        private string ReloadRating()
        {
            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Director);
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
                Type = RatingTypes.Director,
                Value = rating
            });
        }
    }
}
