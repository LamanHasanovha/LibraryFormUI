using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Models.RequestModels;
using FontAwesome.Sharp;
using System;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class AccountEditForm : BaseForm
    {
        private readonly IAccountService _accountService;

        public Action<BaseForm, bool> OpenFormEvent { get; set; }

        public AccountEditForm()
        {
            InitializeComponent();
            _accountService = new AccountManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
        }

        private void AccountEditForm_Load(object sender, EventArgs e)
        {
            tbxFirstName.Texts = Account?.FirstName;
            tbxLastName.Texts = Account?.LastName;
            tbxEmail.Texts = Account?.Email;
            tbxUserName.Texts = Account?.Username;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = !tbxPassword.PasswordChar;
            if (btnPass.IconChar == IconChar.Eye)
                btnPass.IconChar = IconChar.EyeSlash;
            else 
                btnPass.IconChar = IconChar.Eye;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to save?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            if (tbxFirstName.Texts.Trim() == "" | tbxLastName.Texts.Trim() == "" | tbxUserName.Texts.Trim() == "" | tbxEmail.Texts.Trim() == "")
            {
                DevMsgBox.Show("Please, fill all the required gaps.", "System");
                return;
            }

            if(tbxPassword.Texts.Trim().Length > 0 & tbxPassword.Texts.Length < 5)
            {
                DevMsgBox.Show("Password length must be greater than 5.");
                return;
            }

            if(tbxPassword.Texts.Trim().Length > 0)
            {
                var account = _accountService.UpdateWithPassword(new AccountUpdateModel
                {
                    Id = Account.Id,
                    FirstName = tbxFirstName.Texts.Trim(),
                    LastName = tbxLastName.Texts.Trim(),
                    Email = tbxEmail.Texts.Trim(),
                    Status = true,
                    Password = tbxPassword.Texts.Trim(),
                    Username = tbxUserName.Texts.Trim()
                });
                Account = account;
                DevMsgBox.Show("Saved!", "System");
                return;
            }

            var acc = _accountService.UpdateInfo(new AccountUpdateInfoModel
            {
                Id = Account.Id,
                FirstName = tbxFirstName.Texts.Trim(),
                Email = tbxEmail.Texts.Trim(),
                UserName= tbxUserName.Texts.Trim(),
                LastName= tbxLastName.Texts.Trim()
            });
            Account = acc;
            DevMsgBox.Show("Saved!", "System");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OpenFormEvent?.Invoke(new AccountForm { Account = Account, OpenFormEvent = OpenFormEvent}, false);
        }
    }
}
