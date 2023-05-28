using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class CartForm : BaseForm
    {
        private readonly ICartService _cartService;
        private List<CartResponseModel> _models;

        public CartForm()
        {
            InitializeComponent();
            _cartService = new CartManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                 new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _models = new List<CartResponseModel>();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            LoadCart();
        }

        private void LoadCart()
        {
            panelContents.Controls.Clear();

            var items = _cartService.GetByAccount(Account.Id);

            panelContents.Controls.Add(CreateDivider());
            foreach (var item in items)
            {
                var control = new CartItem();
                control.RemoveFromCart = RemoveFromCart;
                control.RecordId = item.Id;
                control.Build(item);
                control.Dock = DockStyle.Top;
                panelContents.Controls.Add(control);
                panelContents.Controls.Add(CreateDivider());
            }
            _models = items;

            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", _models.Select(x => x.Price).Sum());
        }

        private void RemoveFromCart(int id)
        {
            var result = DevMsgBox.Show("Are you sure want to remove?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;
            HandleException(() =>
            {
                _cartService.Delete(new Cart { Id = id });
            });

            LoadCart();
        }

        private Panel CreateDivider()
        {
            return new Panel
            {
                Dock = DockStyle.Top,
                Height = 4,
                BackColor = Color.FromArgb(68, 132, 188)
            };
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            var form = new CheckoutForm { Account = Account, Orders = _models };
            form.ShowDialog();
        }
    }
}
