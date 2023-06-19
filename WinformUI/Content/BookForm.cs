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
    public partial class BookForm : BaseForm
    {
        private readonly IBookService _bookService;
        private readonly IRatingService _ratingService;
        private readonly IReviewService _reviewService;
        private readonly IActivityService _activityService;
        private readonly IRecommenderService _recommenderService;
        private readonly IBookFavListService _bookFavListService;
        private readonly IBookWishListService _bookWishListService;
        private readonly ICartService _cartService;

        public BookForm()
        {
            InitializeComponent();
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _ratingService = new RatingManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                   new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _reviewService = new ReviewManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _activityService = new ActivityManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _recommenderService = new RecommenderManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookFavListService = new BookFavListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookWishListService = new BookWishListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                 new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _cartService = new CartManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                 new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

            rtcBook.SetRating = SetRating;
            rtcBook.ReloadRating = ReloadRating;
            
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            Build();
            _activityService.Add(new Activity
            {
                AccountId = Account.Id,
                ProductType = ProductTypes.Book,
                RecordId = RecordId
            });
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
            if (ratings.Count > 0)
            {
                rtcBook.RatingReport = ratings.Select(r => r.Value).Average() + "\n" + ratings.Count;
                var temp = ratings.FirstOrDefault(r => r.AccountId == Account.Id);
                if (temp != null)
                    rtcBook.Value = temp.Value;
            }
            else
                rtcBook.RatingReport = 0 + "\n" + ratings.Count;

        }

        private void LoadSimilars()
        {
            var books = _recommenderService.GetBooks(RecordId, 20);

            foreach (var book in books)
            {
                var item = new BookSliderObject();
                item.Build(book);
                sliderSimilars.Add(item);
            }
        }

        private void LoadReviews()
        {
            var currentReview = _reviewService.GetByAccount(Account.Id, RecordId, RatingTypes.Book);
            if(currentReview != null)
            {
                btnAddReview.Visible = tbxReview.Visible = false;
            }

            var reviews = _reviewService.GetByType(RecordId, RatingTypes.Book);
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
            var ratings = _ratingService.GetByRecord(RecordId, RatingTypes.Book);
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
                Type = RatingTypes.Book,
                Value = rating
            });
        }

        private void btnAddFavourites_Click(object sender, EventArgs e)
        {
            var data = _bookFavListService.GetByAccount(Account.Id)?.Where(b => b.Id == RecordId).ToList();
            if (data is null | data.Count == 0)
            {
                _bookFavListService.Add(new BookFavList
                {
                    BookId = RecordId,
                    AccountId = Account.Id,
                });
            }
            else
            {
                _bookFavListService.Delete(new BookFavList { Id = data.FirstOrDefault().Id });
            }
        }

        private void btnAddWishList_Click(object sender, EventArgs e)
        {
            var data = _bookWishListService.GetByAccount(Account.Id)?.Where(b => b.Id == RecordId).ToList();
            if (data is null | data.Count == 0)
            {
                _bookWishListService.Add(new BookWishList
                {
                    BookId = RecordId,
                    AccountId = Account.Id,
                });
            }
            else
            {
                _bookWishListService.Delete(new BookWishList { Id = data.FirstOrDefault().Id });
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            var data = _cartService.GetByAccount(Account.Id)?.Where(c => c.ProductType == ProductTypes.Book & c.RecordId == RecordId).ToList();
            if (data is null | data.Count == 0)
            {
                _cartService.Add(new Cart
                {
                    RecordId = RecordId,
                    AccountId = Account.Id,
                    Type = ProductTypes.Book
                });
            }
            else
            {
                _cartService.Delete(new Cart { Id = data.FirstOrDefault().Id });
            }
        }

        private void btnAddReview_Click(object sender, EventArgs e)
        {
            var review = new Review
            {
                AccountId = Account.Id,
                Date = DateTime.Now,
                RecordId = RecordId,
                Text = tbxReview.Texts,
                Type = RatingTypes.Book
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
