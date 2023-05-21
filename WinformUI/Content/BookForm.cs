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
using System.Windows.Forms;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class BookForm : BaseForm
    {
        private readonly IBookService _bookService;
        private readonly IRatingService _ratingService;
        private readonly IReviewService _reviewService;

        public BookForm()
        {
            InitializeComponent();
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _ratingService = new RatingManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                   new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _reviewService = new ReviewManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            
            rtcBook.SetRating = SetRating;
            rtcBook.ReloadRating = ReloadRating;
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            Build();
        }

        private void Build()
        {
            var book = _bookService.GetBookById(RecordId);

            lblBookName.Text = book.Name;
            try
            {
                pcbImage.Load(book.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.book;
            }

            tbxDescription.Texts = book.Description;
            lblPage.Text = book.Page > 1 ? book.Page + " pages" : book.Page + " page";
            lblLanguage.Text = book.Language;
            lblGenres.Text = string.Join(", ", book.Genres.Select(g => g.Name));
            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", book.Price);
            lblAuthorName.Text = book.Author;

            LoadSimilars();
            LoadReviews();

            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Book);
            rtcBook.RatingReport = ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
        }

        private void LoadSimilars()
        {

        }

        private void LoadReviews()
        {
            var reviews = _reviewService.GetByType(RecordId, RatingTypes.Book);

            foreach (var review in reviews)
            {
                var item = new ReviewItem();
                item.UsernameText = review.Username;
                item.DateText = review.Date.ToString("dd.MM.yyyy");
                item.ReviewText = review.Text;
                item.Dock = DockStyle.Top;
                item.Margin = new Padding(3, 10, 3, 20);

                panelReviews.Controls.Add(item);
            }
        }

        private string ReloadRating()
        {
            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Book);
            return ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
        }

        private void SetRating(int rating)
        {
            _ratingService.SaveRating(new Rating
            {
                AccountId = Account.Id,
                RecordId = RecordId,
                Type = RatingTypes.Book,
                Value = rating
            });
        }
    }
}
