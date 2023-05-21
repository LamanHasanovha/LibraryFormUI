using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.DropShadowing;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Models.RequestModels;
using System;
using System.Net.Http;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class SignUpConfirmForm : BaseForm
    {
        private readonly IAccountService _accountService;
        private readonly IAuthCodeService _authCodeService;
        private TimeSpan _time;

        public bool Result { get; set; }

        public SignUpConfirmForm()
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
            _accountService = new AccountManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _authCodeService = new AuthCodeManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _time = new TimeSpan(1800000000);
            Result = true;
        }

        private void SignUpConfirmForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            HandleException(() =>
            {
                if (tbxCode.Texts.Trim() == "" | tbxCode.Texts.Trim().Length != 9)
                {
                    DevMsgBox.Show("Please, enter code correctly.", "System");
                    Result = false;
                    return;
                }
                var checkCode = _authCodeService.CheckAuthCode(Account.Id, tbxCode.Texts.Trim());

                if (!checkCode)
                {
                    DevMsgBox.Show("Incorrect code", "System");
                    Result = false;
                    return;
                }

                DevMsgBox.Show("Email confirmed.", "System");
            });
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_time.TotalSeconds == 0)
            {
                timer.Stop();
                timer.Dispose();
                DevMsgBox.Show("Session has expired for changing mail. Please, try again.", "System");
                this.Close();
                return;
            }

            _time = _time.Subtract(new TimeSpan(0, 0, 1));
            lblTimer.Text = _time.Minutes.ToString().PadLeft(2, '0') + ":" + _time.Seconds.ToString().PadLeft(2, '0');
        }
    }
}
