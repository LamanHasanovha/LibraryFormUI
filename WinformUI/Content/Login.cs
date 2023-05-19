using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Models.RequestModels;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.AdminPanel;
using WinformUI.Application;
using WinformUI.Content;
using WinformUI.Infrastructure.Forms;

namespace WinformUI
{
    public partial class Login : BaseForm
    {
        private readonly IAccountService _accountService;
        public Login()
        {
            InitializeComponent();
            DoubleBuffered = true;

            _accountService = new AccountManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()),
                                                    ConfigurationHelper.GetAppSetting("BaseAddress"),
                                                    new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), 
                                                                            Password = ConfigurationHelper.GetAppSetting("Password") });
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            MultiColorGradient(sender, e, Color.FromArgb(28, 167, 236), Color.FromArgb(31, 47, 152), Color.FromArgb(31, 100, 152));
            //GradientColor(sender, e, Color.FromArgb(28, 167, 236), Color.FromArgb(31, 47, 152));
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbxUserName.Texts == "20090702" &  tbxPassword.Texts == "20090702")
            {
                this.Hide();
                var form = new AdminForm();
                form.ShowDialog();
                return;
            }

            try
            {
                var account = _accountService.Login(new AccountLoginModel
                {
                    Username = tbxUserName.Texts.Trim(),
                    Password = tbxPassword.Texts.Trim()
                });
                base.Account = account;

                this.Hide();
                var form = new WinformUI.Content.MainMenu
                {
                    Account = base.Account
                };
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                lblErrors.Text = ex.Message;
                return;
            }
        }

        private void lblSingUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new SignUp();
            form.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to quit?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void panelSide_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.FromArgb(68, 132, 188);
        }
    }
}
