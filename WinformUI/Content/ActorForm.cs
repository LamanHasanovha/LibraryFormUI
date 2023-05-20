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
    public partial class ActorForm : BaseForm
    {
        private readonly IActorService _actorService;
        private readonly IMovieService _movieService;
        private readonly IRatingService _ratingService;

        public ActorForm()
        {
            InitializeComponent();
            _actorService = new ActorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _ratingService = new RatingManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            rtcActor.SetRating = SetRating;
            rtcActor.ReloadRating = ReloadRating;
        }

        private void ActorForm_Load(object sender, EventArgs e)
        {
            Build();
        }

        private void Build()
        {
            var actor = _actorService.Get(RecordId);
            lblFullName.Text = actor.FirstName + " " + actor.LastName;
            lblBirthDate.Text = actor.BirthDate.ToString("dd MMMM yyyy");
            tbxDescription.Text = actor.Description;
            try
            {
                pcbImage.Load(actor.Image);
            }
            catch
            {
                switch (actor.Gender)
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

            var movies = _movieService.GetByActor(RecordId);
            foreach (var movie in movies)
            {
                var card = new BasicCard();
                card.Build(movie);
                basicSlider.Add(card);
            }

            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Actor);
            rtcActor.RatingReport = ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
        }

        private string ReloadRating()
        {
            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Actor);
            return ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
        }

        private void SetRating(int rating)
        {
            _ratingService.SaveRating(new Rating
            {
                AccountId = Account.Id,
                RecordId = RecordId,
                Type = RatingTypes.Actor,
                Value = rating
            });
        }

    }
}
