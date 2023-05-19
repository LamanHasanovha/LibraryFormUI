using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Models.RequestModels;
using System;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class BookForm : BaseForm
    {
        private readonly IBookService _bookService;

        public BookForm()
        {
            InitializeComponent();
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            //Build();
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
        }

        private void LoadSimilars()
        {

        }

        private void LoadReviews()
        {

        }
    }
}
