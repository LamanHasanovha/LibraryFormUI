using Entities.Abstract;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.ResponseModels;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Input;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class CartItem : UserControl
    {
        [Browsable(false)]
        public Action<int> RemoveFromCart { get; set; }

        [Browsable(false)]
        public int RecordId { get; set; }

        [Browsable(false)]
        public object Data { get; set; }

        public CartItem()
        {
            InitializeComponent();
        }

        private void CartItem_Load(object sender, EventArgs e)
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
            switch (model.ProductType)
            {
                case ProductTypes.Book:
                    lblProductType.Text = "Book";
                    break;
                case ProductTypes.Movie:
                    lblProductType.Text = "Movie";
                    break;
                default:
                    break;
            }

            Data = model;
        }

        public void Build(Book book)
        {
            try
            {
                pcbImage.Load(book.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.book;
            }

            tbxName.Texts = book.Name;
            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", book.Price);
            lblProductType.Text = "Book";

            Data = book;
        }

        public void Build(Movie movie)
        {
            try
            {
                pcbImage.Load(movie.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.movie;
            }

            tbxName.Texts = movie.Name;
            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", movie.Price);
            lblProductType.Text = "Movie";

            Data = movie;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveFromCart?.Invoke(RecordId);
        }
    }
}
