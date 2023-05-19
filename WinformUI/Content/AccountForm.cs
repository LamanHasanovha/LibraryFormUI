using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Models.RequestModels;
using System;
using System.Net.Http;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class AccountForm : BaseForm
    {
        private readonly IAccountService _accountService;

        public Action<BaseForm, bool> OpenFormEvent { get; set; }

        public AccountForm()
        {
            InitializeComponent();
            _accountService = new AccountManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            lblFirstnameValue.Text = Account?.FirstName;
            lblLastnameValue.Text = Account?.LastName;
            lblUsernameValue.Text = Account?.Username;
            lblEmailValue.Text = Account?.Email;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpenFormEvent?.Invoke(new AccountEditForm { OpenFormEvent = OpenFormEvent }, false);
        }
    }
}
