using Entities.Models.ResponseModels;
using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class WishListItem : UserControl
    {
        [Browsable(false)]
        public Action<int, bool> AddToCart { get; set; }
        [Browsable(false)]
        public Action<int, bool> RemoveFromCart { get; set; }
        [Browsable(false)]
        public Action<int, bool> RemoveFromWishList { get; set; }

        [Browsable(false)]
        public int RecordId { get; set; }

        [Browsable(false)]
        public bool IsBook { get; set; }

        [Browsable(false)]
        public bool IsAddedCart { get; set; }

        public WishListItem()
        {
            InitializeComponent();
        }

        private void WishListItem_Load(object sender, EventArgs e)
        {

        }

        public void Build(BookResponseModel book)
        {
            try
            {
                pcbImage.Load(book.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.book;
            }

            tbxName.Text = book.Name;
            tbxDescription.Texts = book.Description;
            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", book.Price);
            RecordId = book.Id;
            IsBook = true;

            if (IsAddedCart)
            {
                btnAddToCart.IconChar = IconChar.CircleMinus;
                btnAddToCart.Text = "Remove from cart";
            }
            else
            {
                btnAddToCart.IconChar = IconChar.CartPlus;
                btnAddToCart.Text = "Add to cart";
            }
        }

        public void Build(MovieResponseModel movie)
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
            tbxDescription.Texts = movie.Description;
            lblPrice.Text = string.Format(CultureInfo.CreateSpecificCulture("az-AZ"), "{0:C}", movie.Price);
            RecordId = movie.Id;
            IsBook = false;

            if (IsAddedCart)
            {
                btnAddToCart.IconChar = IconChar.CircleMinus;
                btnAddToCart.Text = "Remove from cart";
            }
            else
            {
                btnAddToCart.IconChar = IconChar.CartPlus;
                btnAddToCart.Text = "Add to cart";
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (IsAddedCart)
            {
                btnAddToCart.IconChar = IconChar.CartPlus;
                btnAddToCart.Text = "Add to cart";
                RemoveFromCart?.Invoke(RecordId, IsBook);
            }
            else
            {
                btnAddToCart.IconChar = IconChar.CircleMinus;
                btnAddToCart.Text = "Remove from cart";
                AddToCart?.Invoke(RecordId, IsBook);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveFromWishList?.Invoke(RecordId, IsBook);
        }
    }
}
