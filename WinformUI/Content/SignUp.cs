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
using WinformUI.Content;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Application
{
    public partial class SignUp : BaseForm
    {
        private readonly IAccountService _accountService;
        private readonly IAuthCodeService _authCodeService;

        public SignUp()
        {
            InitializeComponent();
            _accountService = new AccountManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()),
                                                   ConfigurationHelper.GetAppSetting("BaseAddress"),
                                                   new UserForLoginModel
                                                   {
                                                       Email = ConfigurationHelper.GetAppSetting("Email"),
                                                       Password = ConfigurationHelper.GetAppSetting("Password")
                                                   });
            _authCodeService = new AuthCodeManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Login();
            form.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                _authCodeService.SendAuthCode(0, tbxEmail.Texts.Trim());
                DevMsgBox.Show("Auth code has been sent your email.", "System");

                var form = new SignUpConfirmForm();
                Account = new Account
                {
                    FirstName = tbxFirstName.Texts.Trim(),
                    LastName = tbxLastName.Texts.Trim(),
                    Username = tbxUserName.Texts.Trim(),
                    Email = tbxEmail.Texts.Trim()
                };
                form.Account = Account;
                form.ShowDialog();

                if (!form.Result)
                {
                    return;
                }

                var account = _accountService.Register(new AccountRegisterModel
                {
                    Email = Account.Email,
                    FirstName = Account.FirstName,
                    LastName = Account.LastName,
                    Username = Account.Username,
                    Password = tbxPassword.Texts.Trim()
                });

                Account = account;

                DevMsgBox.Show("Registered successfully.", "System");

                this.Hide();
                var login = new Login();
                login.tbxUserName.Texts = Account.Username;
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                lblErrors.Text = ex.Message;
                return;
            }
        }

        private void lblSignUp_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SignUp_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SignUp_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            MultiColorGradient(sender, e, Color.FromArgb(28, 167, 236), Color.FromArgb(31, 47, 152), Color.FromArgb(31, 100, 152));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to quit?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void panelSide_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
