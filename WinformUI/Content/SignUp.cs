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

namespace WinformUI.Application
{
    public partial class SignUp : BaseForm
    {
        private readonly IAccountService _accountService;

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
                var account = _accountService.Register(new AccountRegisterModel
                {
                    Email = tbxEmail.Texts.Trim(),
                    FirstName = tbxFirstName.Texts.Trim(),
                    LastName = tbxLastName.Texts.Trim(),
                    Password = tbxPassword.Texts.Trim(),
                    Username = tbxUserName.Texts.Trim()
                });
            }
            catch (Exception ex)
            {
                lblErrors.Text = ex.Message;
                return;
            }
            
            this.Hide();
            var form = new Login();
            form.tbxUserName.Texts = tbxUserName.Texts.Trim();
            form.ShowDialog();
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
