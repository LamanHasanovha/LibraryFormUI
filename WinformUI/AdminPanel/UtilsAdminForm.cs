using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Models.RequestModels;
using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.AdminPanel
{
    public partial class UtilsAdminForm : BaseForm
    {
        private Types EntityType { get; set; }
        private readonly IBookGenreService _bookGenreService;
        private readonly IMovieGenreService _movieGenreService;
        private readonly ILanguageService _languageService;

        public UtilsAdminForm()
        {
            InitializeComponent();
            _bookGenreService = new BookGenreManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieGenreService = new MovieGenreManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _languageService = new LanguageManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void UtilsAdminForm_Load(object sender, EventArgs e)
        {
            LoadBookGenres();
            LoadMovieGenres();
            LoadLanguages();
            DesignDataGridView(dgwBookGenres);
            DesignDataGridView(dgwMovieGenres);
            DesignDataGridView(dgwLanguages);
        }

        private void LoadBookGenres()
        {
            dgwBookGenres.DataSource = _bookGenreService.GetAll();
        }

        private void LoadMovieGenres()
        {
            dgwMovieGenres.DataSource = _movieGenreService.GetAll();
        }

        private void LoadLanguages()
        {
            dgwLanguages.DataSource = _languageService.GetAll();
        }

        protected override void DesignDataGridView(DataGridView dgwBase)
        {
            base.DesignDataGridView(dgwBase);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to add?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            switch (EntityType)
            {
                case Types.BookGenre:
                    _bookGenreService.Add(new BookGenre { Name = tbxName.Texts.Trim() });
                    LoadBookGenres();
                    break;
                case Types.MovieGenre:
                    _movieGenreService.Add(new MovieGenre { Name = tbxName.Texts.Trim() });
                    LoadMovieGenres();
                    break;
                case Types.Language:
                    _languageService.Add(new Language { Name = tbxName.Texts.Trim() });
                    LoadLanguages();
                    break;
                default:
                    break;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to update?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            switch (EntityType)
            {
                case Types.BookGenre:
                    _bookGenreService.Update(new BookGenre { Id = RecordId, Name = tbxName.Texts.Trim() });
                    LoadBookGenres();
                    break;
                case Types.MovieGenre:
                    _movieGenreService.Update(new MovieGenre { Id = RecordId, Name = tbxName.Texts.Trim() });
                    LoadMovieGenres();
                    break;
                case Types.Language:
                    _languageService.Update(new Language { Id = RecordId, Name = tbxName.Texts.Trim() });
                    LoadLanguages();
                    break;
                default:
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to delete?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            switch (EntityType)
            {
                case Types.BookGenre:
                    _bookGenreService.Delete(new BookGenre { Id = RecordId });
                    LoadBookGenres();
                    break;
                case Types.MovieGenre:
                    _movieGenreService.Delete(new MovieGenre { Id = RecordId });
                    LoadMovieGenres();
                    break;
                case Types.Language:
                    _languageService.Delete(new Language { Id = RecordId });
                    LoadLanguages();
                    break;
                default:
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxName.Texts = "";
        }

        private void dgwBookGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EntityType = Types.BookGenre;
            if (dgwBookGenres.CurrentRow == null)
                return;

            RecordId = Convert.ToInt32(dgwBookGenres.CurrentRow?.Cells[0].Value);

            var bookGenre = _bookGenreService.Get(RecordId);
            tbxName.Texts = bookGenre.Name;

            lblBookGenres.ForeColor = Color.DimGray;
            lblLanguages.ForeColor = Color.Gainsboro;
            lblMovieGenres.ForeColor = Color.Gainsboro;
        }

        private void dgwMovieGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EntityType = Types.MovieGenre;
            if (dgwMovieGenres.CurrentRow == null)
                return;

            RecordId = Convert.ToInt32(dgwMovieGenres.CurrentRow?.Cells[0].Value);

            var movieGenre = _movieGenreService.Get(RecordId);
            tbxName.Texts = movieGenre.Name;

            lblBookGenres.ForeColor = Color.Gainsboro;
            lblLanguages.ForeColor = Color.Gainsboro;
            lblMovieGenres.ForeColor = Color.DimGray;
        }

        private void dgwLanguages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EntityType = Types.Language;
            if (dgwLanguages.CurrentRow == null)
                return;

            RecordId = Convert.ToInt32(dgwLanguages.CurrentRow?.Cells[0].Value);

            var language = _languageService.Get(RecordId);
            tbxName.Texts = language.Name;

            lblBookGenres.ForeColor = Color.Gainsboro;
            lblLanguages.ForeColor = Color.DimGray;
            lblMovieGenres.ForeColor = Color.Gainsboro;
        }

        private void lblBookGenres_Click(object sender, EventArgs e)
        {
            EntityType = Types.BookGenre;

            lblBookGenres.ForeColor = Color.DimGray;
            lblLanguages.ForeColor = Color.Gainsboro;
            lblMovieGenres.ForeColor = Color.Gainsboro;
        }

        private void lblMovieGenres_Click(object sender, EventArgs e)
        {
            EntityType = Types.MovieGenre;

            lblBookGenres.ForeColor = Color.Gainsboro;
            lblLanguages.ForeColor = Color.Gainsboro;
            lblMovieGenres.ForeColor = Color.DimGray;
        }

        private void lblLanguages_Click(object sender, EventArgs e)
        {
            EntityType = Types.Language;

            lblBookGenres.ForeColor = Color.Gainsboro;
            lblLanguages.ForeColor = Color.DimGray;
            lblMovieGenres.ForeColor = Color.Gainsboro;
        }
    }

    enum Types
    {
        BookGenre = 1,
        MovieGenre = 2,
        Language = 3
    }
}
