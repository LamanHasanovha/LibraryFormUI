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
    public partial class AuthorForm : BaseForm
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        private readonly IRatingService _ratingService;

        public AuthorForm()
        {
            InitializeComponent();
            _authorService = new AuthorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _ratingService = new RatingManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            rtcAuthor.SetRating = SetRating;
            rtcAuthor.ReloadRating = ReloadRating;
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            Build();
        }

        private void Build()
        {
            var author = _authorService.Get(RecordId);
            lblFullName.Text = author.FirstName + " " + author.LastName;
            lblBirthDate.Text = author.BirthDate.ToString("dd MMMM yyyy");
            tbxDescription.Text = author.Description;
            try
            {
                pcbImage.Load(author.Image);
            }
            catch
            {
                switch (author.Gender)
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

            var books = _bookService.GetByAuthor(RecordId);
            foreach (var book in books)
            {
                var card = new BasicCard();
                card.Build(book);
                basicSlider.Add(card);
            }

            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Author);
            if (ratings.Count > 0)
            {
                rtcAuthor.RatingReport = ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
                var temp = ratings.FirstOrDefault(r => r.AccountId == Account.Id);
                if (temp != null)
                    rtcAuthor.Value = temp.Value;
            }
            else
                rtcAuthor.RatingReport = "0\n0";
        }

        private string ReloadRating()
        {
            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Author);
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
                Type = RatingTypes.Author,
                Value = rating
            });
        }

    }
}
