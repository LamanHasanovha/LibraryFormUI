using Core.WinFormUI.Design.MessageBox;
using Entities.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinformUI.Infrastructure.CustomControls;

namespace WinformUI.Content
{
    public partial class CheckoutForm : Form
    {
        public List<CartResponseModel> Orders { get; set; }

        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            //LoadOrders();
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


        }

        private bool CheckExpDate(string expDate)
        {
            if(expDate.Length != 5)
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
