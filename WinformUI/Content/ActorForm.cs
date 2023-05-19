using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Constants;
using Entities.Models.RequestModels;
using System;
using System.Net.Http;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class ActorForm : BaseForm
    {
        private readonly IActorService _actorService;
        private readonly IMovieService _movieService;

        public ActorForm()
        {
            InitializeComponent();
            _actorService = new ActorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

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
        }
    }
}
