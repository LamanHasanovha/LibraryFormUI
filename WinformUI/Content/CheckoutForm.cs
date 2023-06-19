using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.DropShadowing;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using Entities.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinformUI.Infrastructure.CustomControls;

namespace WinformUI.Content
{
    public partial class CheckoutForm : Form
    {
        private readonly IPurchaseService _purchaseService;
        private readonly IPaymentService _paymentService;
        private readonly IBookWishListService _bookWishListService;
        private readonly IMovieWishListService _movieWishListService;
        private readonly ICartService _cartService;

        public List<CartResponseModel> Orders { get; set; }
        public Account Account { get; set; }

        public CheckoutForm()
        {
            InitializeComponent();
            new DropShadow().ApplyShadows(this);
            _purchaseService = new PurchaseManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _paymentService = new PaymentManager();
            _bookWishListService = new BookWishListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieWishListService = new MovieWishListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                              new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _cartService = new CartManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            foreach (var order in Orders)
            {
                var item = new OrderItem();
                item.Dock = DockStyle.Top;
                item.Build(order);

                panelOrders.Controls.Add(item);
            }

            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", Orders.Select(o => o.Price).Sum());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to close?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            bool value = false;

            if (tbxCardNumber.Text.Trim().Length < 19)
            {
                lblCardNumber.ForeColor = Color.Red;
                value = true;
            }
            else
                lblCardNumber.ForeColor = Color.FromArgb(68, 132, 188);

            if (tbxCVV.Text.Trim().Length != 3)
            {
                lblCVV.ForeColor = Color.Red;
                value = true;
            }
            else
                lblCVV.ForeColor = Color.FromArgb(68, 132, 188);

            if (!CheckExpDate(tbxExpDate.Text.Trim()))
            {
                lblExpDate.ForeColor = Color.Red;
                value = true;
            }
            else
                lblExpDate.ForeColor = Color.FromArgb(68, 132, 188);

            if (value)
                return;

            var file = _paymentService.Pay(new PaymentModel
            {
                AccountInfo = new AccountInfoModel
                {
                    Id = Account.Id,
                    Email = Account.Email,
                    FirstName = Account.FirstName,
                    LastName = Account.LastName,
                    UserName = Account.Username
                },
                Orders = GetOrders()
            });

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Create a new FileStream for the output file
                using (var outputFileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    // Copy the PDF data from the input FileStream to the output FileStream
                    file.CopyTo(outputFileStream);
                }

                DevMsgBox.Show("PDF saved successfully.", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (var item in Orders)
            {
                _purchaseService.Add(new Purchase
                {
                    AccountId = Account.Id,
                    ProductType = item.ProductType,
                    RecordId = item.RecordId
                });
                _cartService.RemoveByAccount(Account.Id, item.RecordId, item.ProductType);
                switch (item.ProductType)
                {
                    case ProductTypes.Book:
                        _bookWishListService.RemoveByAccount(Account.Id, item.RecordId);
                        break;
                    case ProductTypes.Movie:
                        _movieWishListService.RemoveByAccount(Account.Id, item.RecordId);
                        break;
                }
            }
            this.Close();
        }

        private List<OrderInfoModel> GetOrders()
        {
            var result = new List<OrderInfoModel>();
            foreach (var item in Orders)
            {
                result.Add(new OrderInfoModel
                {
                    Name = item.Name,
                    Price = item.Price,
                    ProductType = (int)item.ProductType
                });
            }

            return result;
        }

        private bool CheckExpDate(string expDate)
        {
            if (expDate.Length != 5)
                return false;

            var data = expDate.Split('/');
            if (int.Parse(data[0]) < 1 | int.Parse(data[0]) > 12)
                return false;

            return true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
