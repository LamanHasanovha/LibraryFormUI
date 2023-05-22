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
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.AdminPanel
{
    public partial class AccountAdminForm : BaseForm
    {
        private readonly IAccountService _accountService;

        public AccountAdminForm()
        {
            InitializeComponent();
            _accountService = new AccountManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void AccountAdminForm_Load(object sender, EventArgs e)
        {
            LoadData();
            DesignDataGridView(dgwAccounts);
        }

        private void LoadData()
        {
            var data = _accountService.GetAll();
            var result = new List<AccountViewModel>();
            foreach (var account in data)
            {
                result.Add(Map<Account, AccountViewModel>(account));
            }
            dgwAccounts.DataSource = result;
        }

        protected override void DesignDataGridView(DataGridView dgwBase)
        {
            base.DesignDataGridView(dgwBase);

        }

        //protected override void OnPaintBackground(PaintEventArgs e) { }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to add?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                _accountService.Register(new AccountRegisterModel
                {
                    Email = tbxEmail.Texts.Trim(),
                    Password = tbxPassword.Texts.Trim(),
                    FirstName = tbxFirstname.Texts.Trim(),
                    LastName = tbxLastname.Texts.Trim(),
                    Username = tbxUsername.Texts.Trim()
                });
            });

            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to update?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                var account = _accountService.Get(RecordId);
                if (tbxPassword.Texts.Trim() == "")
                {
                    _accountService.Update(new Account
                    {
                        Id = account.Id,
                        FirstName = tbxFirstname.Texts.Trim(),
                        LastName = tbxLastname.Texts.Trim(),
                        Email = tbxEmail.Texts.Trim(),
                        LastLoginDate = account.LastLoginDate,
                        PasswordHash = account.PasswordHash,
                        PasswordSalt = account.PasswordSalt,
                        Status = chkStatus.Checked,
                        Username = tbxUsername.Texts.Trim()
                    });
                }
                else
                {
                    _accountService.UpdateWithPassword(new AccountUpdateModel
                    {
                        Id = account.Id,
                        FirstName = tbxFirstname.Texts.Trim(),
                        LastName = tbxLastname.Texts.Trim(),
                        Email = account.Email,
                        Password = tbxPassword.Texts.Trim(),
                        Status = chkStatus.Checked,
                        Username = tbxUsername.Texts.Trim()
                    });
                }
            });

            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to delete?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                _accountService.Delete(new Account
                {
                    Id = RecordId
                });
            });

            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxEmail.Texts = "";
            tbxFirstname.Texts = "";
            tbxLastname.Texts = "";
            tbxPassword.Texts = "";
            tbxUsername.Texts = "";
            chkStatus.Checked = false;
        }

        private void dgwAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwAccounts.CurrentRow == null)
                return;

            RecordId = Convert.ToInt32(dgwAccounts.CurrentRow.Cells[0].Value);

            var account = _accountService.Get(RecordId);
            tbxEmail.Texts = account.Email;
            tbxFirstname.Texts = account.FirstName;
            tbxLastname.Texts = account.LastName;
            tbxUsername.Texts = account.Username;
            chkStatus.Checked = account.Status;
        }
    }
}
