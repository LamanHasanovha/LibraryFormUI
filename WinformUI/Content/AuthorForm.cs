using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using System;
using System.Net.Http;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class AuthorForm : BaseForm
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;

        public AuthorForm()
        {
            InitializeComponent();
            _authorService = new AuthorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

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
        }

    }
}
