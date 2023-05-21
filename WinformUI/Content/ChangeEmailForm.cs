using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.DropShadowing;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Models.RequestModels;
using FontAwesome.Sharp;
using System;
using System.Net.Http;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class ChangeEmailForm : BaseForm
    {
        private readonly IAccountService _accountService;
        private readonly IAuthCodeService _authCodeService;
        private TimeSpan _time;

        public ChangeEmailForm()
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
            _accountService = new AccountManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _authCodeService = new AuthCodeManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _time = new TimeSpan(1800000000);
        }

        private void ChangeEmailForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!tbxCode.Visible)
            {
                if (tbxEmail.Texts.Trim() == "" | tbxEmail.Texts.Trim() == Account.Email)
                {
                    DevMsgBox.Show("Please, enter new mail.", "System");
                    return;
                }

                if (tbxPassword.Texts.Trim() == "")
                {
                    DevMsgBox.Show("Please, enter password.", "System");
                    return;
                }

                HandleException(() =>
                {
                    var checkPass = _accountService.CheckPass(Account.Username, tbxPassword.Texts.Trim());

                    if (!checkPass)
                    {
                        DevMsgBox.Show("Incorrect password", "System");
                        return;
                    }

                    _authCodeService.SendAuthCode(Account.Id);

                    tbxCode.Visible = true;
                    lblTimer.Visible = true;
                    timer.Start();
                });
                return;
            }

            HandleException(() =>
            {
                if(tbxCode.Texts.Trim() == "" | tbxCode.Texts.Trim().Length != 9)
                {
                    DevMsgBox.Show("Please, enter code correctly.", "System");
                    return;
                }

                HandleException(() =>
                {
                    var checkCode = _authCodeService.CheckAuthCode(Account.Id, tbxCode.Texts.Trim());

                    if (!checkCode)
                    {
                        DevMsgBox.Show("Incorrect code", "System");
                        return;
                    }

                    _accountService.UpdateInfo(new AccountUpdateInfoModel
                    {
                        Id = Account.Id,
                        Email = tbxEmail.Texts.Trim(),
                        FirstName = Account.FirstName,
                        LastName = Account.LastName,
                        UserName = Account.Username
                    });
                });
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

        private void btnPass_Click(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = !tbxPassword.PasswordChar;
            if (btnPass.IconChar == IconChar.Eye)
                btnPass.IconChar = IconChar.EyeSlash;
            else
                btnPass.IconChar = IconChar.Eye;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
