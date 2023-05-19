using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.AdminPanel
{
    public partial class DirectorAdminForm : BaseForm
    {
        private readonly IDirectorService _directorService;

        public DirectorAdminForm()
        {
            InitializeComponent();
            _directorService = new DirectorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void DirectorAdminForm_Load(object sender, EventArgs e)
        {
            LoadData();
            DesignDataGridView(dgwDirectors);
        }

        protected override void DesignDataGridView(DataGridView dgwBase)
        {
            base.DesignDataGridView(dgwBase);


        }

        private void LoadData()
        {
            dgwDirectors.DataSource = _directorService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to add?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                if (pcbImage.Image == null)
                    tbxImageUrl.Texts = "local";

                var director = _directorService.Add(new Director
                {
                    FirstName = tbxFirstName.Texts.Trim(),
                    LastName = tbxLastName.Texts.Trim(),
                    Description = tbxDescription.Texts.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Gender = (Gender)(cmbGenders.SelectedIndex + 1),
                    Image = tbxImageUrl.Texts.Trim()
                });
            });

            if (tbxImageUrl.Texts == "local")
                switch (cmbGenders.SelectedIndex)
                {
                    case 0:
                        pcbImage.Image = Properties.Resources.man;
                        break;
                    case 1:
                        pcbImage.Image = Properties.Resources.woman;
                        break;
                    default:
                        break;
                }

            LoadData();
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

                var director = _directorService.Update(new Director
                {
                    Id = RecordId,
                    FirstName = tbxFirstName.Texts.Trim(),
                    LastName = tbxLastName.Texts.Trim(),
                    Description = tbxDescription.Texts.Trim(),
                    BirthDate = dtpBirthDate.Value,
                    Gender = (Gender)(cmbGenders.SelectedIndex + 1),
                    Image = tbxImageUrl.Texts.Trim()
                });
            });

            if (tbxImageUrl.Texts == "local")
                switch (cmbGenders.SelectedIndex)
                {
                    case 0:
                        pcbImage.Image = Properties.Resources.man;
                        break;
                    case 1:
                        pcbImage.Image = Properties.Resources.woman;
                        break;
                    default:
                        break;
                }

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to delete?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                var director = _directorService.Delete(new Director
                {
                    Id = RecordId
                });
            });

            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxFirstName.Texts = "";
            tbxLastName.Texts = "";
            tbxDescription.Texts = "";
            cmbGenders.SelectedIndex = 0;
            dtpBirthDate.Value = DateTime.Now;
            tbxImageUrl.Texts = "";
            pcbImage.Image = null;
        }

        private void dgwDirectors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RecordId = Convert.ToInt32(dgwDirectors.CurrentRow.Cells[0].Value);

            var director = _directorService.Get(RecordId);
            tbxFirstName.Texts = director.FirstName;
            tbxLastName.Texts = director.LastName;
            tbxDescription.Texts = director.Description;
            cmbGenders.SelectedIndex = (int)director.Gender - 1;
            dtpBirthDate.Value = director.BirthDate;
            tbxImageUrl.Texts = director.Image;
            try
            {
                pcbImage.Load(director.Image);
            }
            catch 
            {
                switch (cmbGenders.SelectedIndex)
                {
                    case 0:
                        pcbImage.Image = Properties.Resources.man;
                        break;
                    case 1:
                        pcbImage.Image = Properties.Resources.woman;
                        break;
                    default:
                        break;
                }
            }

        }

        private void tbxImageUrl__TextChanged(object sender, EventArgs e)
        {
            try
            {
                pcbImage.Load(tbxImageUrl.Texts.Trim());
            }
            catch 
            {
                switch (cmbGenders.SelectedIndex)
                {
                    case 0:
                        pcbImage.Image = Properties.Resources.man;
                        break;
                    case 1:
                        pcbImage.Image = Properties.Resources.woman;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
