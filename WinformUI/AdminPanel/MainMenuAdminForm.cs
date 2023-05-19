using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Content;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.AdminPanel
{
    public partial class MainMenuAdminForm : BaseForm
    {
        private readonly IMenuContentService _menuContentService;
        private readonly IMenuObjectService _menuObjectService;
        private readonly IBookService _bookService;
        private readonly IMovieService _movieService;
        private readonly List<Book> _books;
        private readonly List<Movie> _movies;

        private int _objectId;

        public MainMenuAdminForm()
        {
            InitializeComponent();
            _menuContentService = new MenuContentManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _menuObjectService = new MenuObjectManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _books = _bookService.GetAll();
            _movies = _movieService.GetAll();
            _objectId = 0;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void MainMenuAdminForm_Load(object sender, EventArgs e)
        {
            LoadContents();
            DesignDataGridView(dgwContents);
            DesignDataGridView(dgwObjects);
        }

        private void LoadContents()
        {
            var data = _menuContentService.GetAll();
            dgwContents.DataSource = data;

            cmbContents.ValueMember = "Id";
            cmbContents.DisplayMember = "Title";
            cmbContents.DataSource = data;
        }

        private void LoadObjects(int contentId)
        {
            dgwObjects.DataSource = _menuObjectService.GetByContent(contentId);
        }


        #region Content click events

        private void btnAddContent_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to add?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                var content = new MenuContent
                {
                    Title = tbxTitleContent.Texts.Trim(),
                    Description = tbxDescriptionContent.Texts.Trim(),
                    ContentType = (ContentTypes)(cmbContentTypes.SelectedIndex + 1),
                    Priority = Convert.ToInt32(tbxPriority.Texts.Trim())
                };
                _menuContentService.Add(content);
            });

            LoadContents();
        }

        private void btnUpdateContent_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to update?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                _menuContentService.Update(new MenuContent
                {
                    Id = RecordId,
                    Title = tbxTitleContent.Texts.Trim(),
                    Description = tbxDescriptionContent.Texts.Trim(),
                    ContentType = (ContentTypes)(cmbContentTypes.SelectedIndex + 1),
                    Priority = Convert.ToInt32(tbxPriority.Texts.Trim())
                });
            });

            LoadContents();
        }

        private void btnDeleteContent_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to delete?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                _menuContentService.Delete(new MenuContent
                {
                    Id = RecordId
                });
            });

            LoadContents();
        }

        private void btnResetContent_Click(object sender, EventArgs e)
        {
            tbxTitleContent.Texts = string.Empty;
            tbxDescriptionContent.Texts = string.Empty;
            cmbContentTypes.SelectedIndex = 0;
            tbxPriority.Texts = string.Empty;
            RecordId = 0;
        }

        private void btnPreviewContent_Click(object sender, EventArgs e)
        {
            if(RecordId  == 0)
            {
                DevMsgBox.Show("Content not selected.", "System");
                return;
            }
            var form = new WinformUI.Content.MainMenu();
            form.LoadMenuContent(RecordId);
            form.ShowDialog();
        }

        private void btnPreviewAllContent_Click(object sender, EventArgs e)
        {
            if(dgwContents.Rows.Count == 0)
            {
                DevMsgBox.Show("Contents not exist.", "System");
                return;
            }
            var form = new WinformUI.Content.MainMenu();
            form.LoadHomePage();
            form.ShowDialog();
        }

        private void btnFastPeekContent_Click(object sender, EventArgs e)
        {
            var form = new PreviewFormPicture();
            switch (cmbContentTypes.SelectedIndex)
            {
                case 0:
                    form.SetPicture(Properties.Resources.Slider);
                    break;
                case 1:
                    form.SetPicture(Properties.Resources.SpecialSlider);
                    break;
                case 2:
                    form.SetPicture(Properties.Resources.NewsPresenter);
                    break;
                case 3:
                    form.SetPicture(Properties.Resources.SupriseMe);
                    break;
                default:
                    return;
            }

            form.ShowDialog();
        }

        #endregion

        #region Object click events

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to add?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                if (cmbContents.DataSource is null)
                    throw new Exception("Content must be select.");

                _menuObjectService.Add(new MenuObject
                {
                    Title = tbxTitleObject.Texts.Trim(),
                    Description = tbxDescriptionObject.Texts.Trim(),
                    ContentId = (int)cmbContents.SelectedValue,
                    ProductType = (ProductTypes)(cmbProductTypes.SelectedIndex + 1),
                    RecordId = (int)cmbRecords.SelectedValue
                });

            });

            LoadObjects((int)cmbContents.SelectedValue);
        }

        private void btnUpdateObject_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to update?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                if (RecordId == 0)
                    throw new Exception("Content must be selected.");

                if (_objectId == 0)
                    throw new Exception("Object must be selected.");

                _menuObjectService.Update(new MenuObject
                {
                    Id = _objectId,
                    Title = tbxTitleObject.Text.Trim(),
                    Description = tbxDescriptionObject.Texts.Trim(),
                    ContentId = (int)cmbContents.SelectedValue,
                    ProductType = (ProductTypes)(cmbProductTypes.SelectedIndex + 1),
                    RecordId = (int)cmbRecords.SelectedValue
                });
            });

            LoadObjects((int)cmbContents.SelectedValue);
        }

        private void btnDeleteObject_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to delete?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                if (_objectId == 0)
                    throw new Exception("Object must be selected");

                _menuObjectService.Delete(new MenuObject
                {
                    Id = _objectId
                });
            });

            LoadObjects((int)cmbContents.SelectedValue);
        }

        private void btnResetObject_Click(object sender, EventArgs e)
        {
            tbxTitleObject.Texts = string.Empty;
            tbxDescriptionObject.Texts = string.Empty;
            cmbContents.SelectedIndex = 0;
            cmbRecords.SelectedIndex = 0;
            cmbProductTypes.SelectedIndex = 0;
            _objectId = 0;
        }

        private void btnPreviewObject_Click(object sender, EventArgs e)
        {

        }

        private void btnPreviewAllObject_Click(object sender, EventArgs e)
        {

        }

        private void btnFastPeekObject_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void dgwContents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwContents.CurrentRow is null)
                return;

            RecordId = (int)dgwContents.CurrentRow.Cells[0].Value;

            var content = _menuContentService.Get(RecordId);
            tbxTitleContent.Texts = content.Title;
            tbxDescriptionContent.Texts = content.Description;
            tbxPriority.Texts = content.Priority.ToString();
            cmbContentTypes.SelectedIndex = (int)content.ContentType - 1;
        }

        private void dgwObjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _objectId = (int)dgwObjects.CurrentRow.Cells[0].Value;

            var obj = _menuObjectService.Get(_objectId);
            tbxTitleObject.Texts = obj.Title;
            tbxDescriptionObject.Texts = obj.Description;
            cmbContentTypes.SelectedValue = obj.ContentId;
            cmbProductTypes.SelectedIndex = (int)obj.ProductType - 1;
            cmbRecords.SelectedValue = obj.RecordId;
        }

        private void cmbProductTypes_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProductTypes.SelectedIndex)
            {
                case 0:
                    cmbRecords.DataSource = _books;
                    break;
                case 1:
                    cmbRecords.DataSource = _movies;
                    break;
                default:
                    break;
            }

            cmbRecords.DisplayMember = "Name";
            cmbRecords.ValueMember = "Id";            
        }

        private void cmbContents_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var objects = _menuObjectService.GetByContent((int)cmbContents.SelectedValue);
            dgwObjects.DataSource = objects;
        }
    }
}
