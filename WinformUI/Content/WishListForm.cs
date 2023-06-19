using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class WishListForm : BaseForm
    {
        private readonly IBookWishListService _bookWishListService;
        private readonly IMovieWishListService _movieWishListService;
        private readonly ICartService _cartService;

        public WishListForm()
        {
            InitializeComponent();
            _bookWishListService = new BookWishListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieWishListService = new MovieWishListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _cartService = new CartManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

        }

        private void WishListForm_Load(object sender, EventArgs e)
        {
            btnBook.IconColor = Color.Gainsboro;
            btnBook.ForeColor = Color.Gainsboro;
            btnBook.BackColor = Color.FromArgb(68, 132, 188);
            LoadBookWishList();
        }

        private void LoadBookWishList()
        {
            panelMain.Controls.Clear();
            var books = _bookWishListService.GetByAccount(Account.Id);

            panelMain.Controls.Add(CreateDivider());
            foreach (var book in books)
            {
                var isAdded = _cartService.Check(Account.Id, book.Id, ProductTypes.Book);
                var item = new WishListItem();
                item.IsAddedCart = isAdded;
                item.AddToCart = AddToCart;
                item.RemoveFromCart = RemoveFromCart;
                item.RemoveFromWishList = RemoveFromWishList;
                item.Dock = DockStyle.Top;
                item.Build(book);

                panelMain.Controls.Add(item);
                panelMain.Controls.Add(CreateDivider());
            }
            if (panelMain.Controls.Count == 1)
            {
                var label = new TransparentLabel();
                label.Font = lblWishList.Font;
                label.ForeColor = lblWishList.ForeColor;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = "No book added to wishlist";
                panelMain.Controls.Add(label);
            }
        }

        private void LoadMovieWishList()
        {
            panelMain.Controls.Clear();
            var movies = _movieWishListService.GetByAccount(Account.Id);

            panelMain.Controls.Add(CreateDivider());
            foreach (var movie in movies)
            {
                var isAdded = _cartService.Check(Account.Id, movie.Id, ProductTypes.Movie);
                var item = new WishListItem();
                item.IsAddedCart = isAdded;
                item.AddToCart = AddToCart;
                item.RemoveFromCart = RemoveFromCart;
                item.RemoveFromWishList = RemoveFromWishList;
                item.Dock = DockStyle.Top;
                item.Build(movie);

                panelMain.Controls.Add(item);
                panelMain.Controls.Add(CreateDivider());
            }
            if (panelMain.Controls.Count == 1)
            {
                var label = new TransparentLabel();
                label.Font = lblWishList.Font;
                label.ForeColor = lblWishList.ForeColor;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = "No movie added to wishlist";
                panelMain.Controls.Add(label);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (!timerBook.Enabled)
                timerBook.Start();

            if (btnBook.IconColor == Color.Gainsboro)
                return;

            LoadBookWishList();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            if (!timerMovie.Enabled)
                timerMovie.Start();

            if (btnMovie.IconColor == Color.Gainsboro)
                return;

            LoadMovieWishList();
        }

        private void RemoveFromWishList(int id, bool isBook)
        {
            var result = DevMsgBox.Show("Are you sure want to remove?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            if (isBook)
            {
                _bookWishListService.RemoveByAccount(Account.Id, id);
                LoadBookWishList();
            }
            else
            {
                _movieWishListService.RemoveByAccount(Account.Id, id);
                LoadMovieWishList();
            }
        }

        private void timerBook_Tick(object sender, EventArgs e)
        {
            if (panelHighlight.Location.X <= btnBook.Location.X + 10)
            {
                timerBook.Stop();
                btnMovie.IconColor = Color.FromArgb(68, 132, 188);
                btnMovie.ForeColor = Color.FromArgb(68, 132, 188);
                btnMovie.BackColor = Color.FromKnownColor(KnownColor.Control);

                btnBook.IconColor = Color.Gainsboro;
                btnBook.ForeColor = Color.Gainsboro;
                btnBook.BackColor = Color.FromArgb(68, 132, 188);
                return;
            }

            panelHighlight.Location = new Point(panelHighlight.Location.X - 4, panelHighlight.Location.Y);
        }

        private void timerMovie_Tick(object sender, EventArgs e)
        {
            if (panelHighlight.Location.X >= btnMovie.Location.X + 10)
            {
                timerMovie.Stop();
                btnMovie.IconColor = Color.Gainsboro;
                btnMovie.ForeColor = Color.Gainsboro;
                btnMovie.BackColor = Color.FromArgb(68, 132, 188);

                btnBook.IconColor = Color.FromArgb(68, 132, 188);
                btnBook.ForeColor = Color.FromArgb(68, 132, 188);
                btnBook.BackColor = Color.FromKnownColor(KnownColor.Control);
                return;
            }

            panelHighlight.Location = new Point(panelHighlight.Location.X + 4, panelHighlight.Location.Y);
        }

        private void AddToCart(int recordId, bool isBook)
        {
            _cartService.Add(new Cart
            {
                AccountId = Account.Id,
                RecordId = recordId,
                Type = isBook ? ProductTypes.Book : ProductTypes.Movie
            });
        }

        private void RemoveFromCart(int recordId, bool isBook)
        {
            var type = isBook ? ProductTypes.Book : ProductTypes.Movie;
            _cartService.RemoveByAccount(Account.Id, recordId, type);
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
    }
}
