using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.AdminPanel
{
    public partial class BookAdminForm : BaseForm
    {
        private readonly IBookService _bookService;
        private readonly IBookGenreService _bookGenreService;
        private readonly ILanguageService _languageService;
        private readonly IBookGenreListService _bookGenreListService;
        private readonly IAuthorService _authorService;

        public BookAdminForm()
        {
            InitializeComponent();
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookGenreService = new BookGenreManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _languageService = new LanguageManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                   new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookGenreListService = new BookGenreListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _authorService = new AuthorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void AccountAdminForm_Load(object sender, EventArgs e)
        {
            LoadGenres();
            LoadLanguages();
            LoadData();
            LoadAuthors();
            DesignDataGridView(dgwBooks);
        }

        private void LoadData()
        {
            dgwBooks.DataSource = _bookService.GetBooks();
        }

        protected override void DesignDataGridView(DataGridView dgwBase)
        {
            base.DesignDataGridView(dgwBase);

        }

        private void LoadGenres()
        {
            slcGenres.Data = _bookGenreService.GetAll();
            slcGenres.Items = ((List<BookGenre>)slcGenres.Data).Select(b => b.Name).ToArray();
        }

        private void LoadLanguages()
        {
            cmbLanguages.DataSource = _languageService.GetAll();
            cmbLanguages.DisplayMember = "Name";
            cmbLanguages.ValueMember = "Id";
        }

        private void LoadAuthors()
        {
            cmbAuthors.DataSource = _authorService.GetAll().Select(a => new { a.Id, FullName = a.FirstName + " " + a.LastName}).ToList();
            cmbAuthors.DisplayMember = "FullName";
            cmbAuthors.ValueMember = "Id";
        }

        //protected override void OnPaintBackground(PaintEventArgs e) { }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to add?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                if (pcbImage.Image == null)
                    tbxImageUrl.Texts = "local";

                var book = _bookService.Add(new Book
                {
                    Name = tbxName.Texts.Trim(),
                    Description = tbxDescription.Texts.Trim(),
                    Page = Convert.ToInt32(tbxPage.Texts.Trim()),
                    LanguageId = (int)cmbLanguages.SelectedValue,
                    Image = tbxImageUrl.Texts.Trim(),
                    Price = Convert.ToDecimal(tbxPrice.Texts.Trim()),
                    AuthorId = (int)cmbAuthors.SelectedValue
                });

                AddBookGenres(book);
            });

            pcbImage.Image = Properties.Resources.book;

            LoadData();
        }

        private void AddBookGenres(Book book)
        {
            var genres = (List<BookGenre>)slcGenres.Data;

            for (int i = 0; i < slcGenres.SelectedIndexes.Count; i++)
            {
                _bookGenreListService.Add(new BookGenreList
                {
                    BookId = book.Id,
                    BookGenreId = genres[slcGenres.SelectedIndexes[i]].Id
                });
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to update?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                if (pcbImage.Image == null)
                    tbxImageUrl.Texts = "local";

                var book = _bookService.Update(new Book
                {
                    Id = RecordId,
                    Name = tbxName.Texts.Trim(),
                    Description = tbxDescription.Texts.Trim(),
                    Page = Convert.ToInt32(tbxPage.Texts.Trim()),
                    LanguageId = (int)cmbLanguages.SelectedValue,
                    Image = tbxImageUrl.Texts.Trim(),
                    Price = Convert.ToDecimal(tbxPrice.Texts.Trim()),
                    AuthorId = (int)cmbAuthors.SelectedValue
                });

                UpdateGenres(book);
            });

            pcbImage.Image = Properties.Resources.book;

            LoadData();
        }

        private void UpdateGenres(Book book)
        {
            var genres = (List<BookGenre>)slcGenres.Data;

            var list = new List<BookGenreList>();

            for (int i = 0; slcGenres.SelectedIndexes.Count > 0; i++)
            {
                list.Add(new BookGenreList
                {
                    BookId = book.Id,
                    BookGenreId = genres[slcGenres.SelectedIndexes[i]].Id
                });
            }

            _bookGenreListService.UpdateByBook(list);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to delete?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                _bookGenreListService.DeleteByBook(RecordId);
                _bookService.Delete(new Book
                {
                    Id = RecordId
                });
            });

            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxName.Texts = "";
            tbxDescription.Texts = "";
            tbxPage.Texts = "";
            cmbAuthors.SelectedIndex = 0;
            slcGenres.SelectedIndexes = new List<int>();
            cmbLanguages.SelectedIndex = 0;
            tbxImageUrl.Texts = "";
            pcbImage.Image = null;
            tbxPrice.Texts = "";
        }

        private void dgwAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwBooks.CurrentRow is null)
                return;

            RecordId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value);

            var book = _bookService.Get(RecordId);
            tbxName.Texts = book.Name;
            tbxDescription.Texts = book.Description;
            tbxPage.Texts = book.Page.ToString();
            cmbLanguages.SelectedValue = book.LanguageId;
            tbxPrice.Texts = book.Price.ToString();
            tbxImageUrl.Texts = book.Image;
            try
            {
                pcbImage.Load(book.Image);
            } catch 
            {
                pcbImage.Image = Properties.Resources.book;
            }

            var list = _bookGenreListService.GetByBook(RecordId).Select(l => l.BookGenreId).ToList();
            var indexes = new List<int>();
            var data = (List<BookGenre>)slcGenres.Data;

            foreach (var item in list)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i].Id == item)
                        indexes.Add(i);
                }
            }
            slcGenres.SelectedIndexes = indexes;
            slcGenres.SetSelectedItems();
        }

        private void tbxImageUrl__TextChanged(object sender, EventArgs e)
        {
            try
            {
                pcbImage.Load(tbxImageUrl.Texts.Trim());
            }
            catch 
            {
                pcbImage.Image = Properties.Resources.book;
            }
        }
    }
}
