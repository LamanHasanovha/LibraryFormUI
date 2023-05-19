using Entities.Constants;
using Entities.Models.ResponseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class OrderItem : UserControl
    {
        public OrderItem()
        {
            InitializeComponent();
        }

        private void OrderItem_Load(object sender, EventArgs e)
        {

        }

        public void Build(CartResponseModel model)
        {
            try
            {
                pcbImage.Load(model.Image);
            }
            catch
            {
                switch (model.ProductType)
                {
                    case ProductTypes.Book:
                        pcbImage.Image = Properties.Resources.book;
                        break;
                    case ProductTypes.Movie:
                        pcbImage.Image = Properties.Resources.movie;
                        break;
                    default:
                        break;
                }
            }

            tbxName.Texts = model.Name;
            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", model.Price);

        }
    }
}
