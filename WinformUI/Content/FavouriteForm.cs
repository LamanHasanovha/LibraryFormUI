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
    public partial class FavouriteForm : BaseForm
    {
        private readonly IBookFavListService _bookFavListService;
        private readonly IMovieFavListService _movieFavListService;
        private readonly ICartService _cartService;

        public FavouriteForm()
        {
            InitializeComponent();
            _bookFavListService = new BookFavListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieFavListService = new MovieFavListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _cartService = new CartManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                                  new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

        }

        private void FavouriteForm_Load(object sender, EventArgs e)
        {
            btnBook.IconColor = Color.Gainsboro;
            btnBook.ForeColor = Color.Gainsboro;
            btnBook.BackColor = Color.FromArgb(68, 132, 188);
            LoadBookFavList();
        }

        private void LoadBookFavList()
        {
            panelMain.Controls.Clear();
            var books = _bookFavListService.GetByAccount(Account.Id);

            panelMain.Controls.Add(CreateDivider());
            foreach (var book in books)
            {
                var isAdded = _cartService.Check(Account.Id, book.Id, ProductTypes.Book);
                var item = new FavListItem();
                item.IsAddedCart = isAdded;
                item.AddToCart = AddToCart;
                item.RemoveFromCart = RemoveFromCart;
                item.RemoveFromFavList = RemoveFromFavList;
                item.Dock = DockStyle.Top;
                item.Build(book);

                panelMain.Controls.Add(item);
                panelMain.Controls.Add(CreateDivider());
            }
            if(panelMain.Controls.Count == 1) 
            {
                var label = new TransparentLabel();
                label.Font = lblFavList.Font;
                label.ForeColor = lblFavList.ForeColor;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = "No book added to favourites";
                panelMain.Controls.Add(label);
            }
        }

        private void LoadMovieFavList()
        {
            panelMain.Controls.Clear();
            var movies = _movieFavListService.GetByAccount(Account.Id);

            panelMain.Controls.Add(CreateDivider());
            foreach (var movie in movies)
            {
                var isAdded = _cartService.Check(Account.Id, movie.Id, ProductTypes.Movie);
                var item = new FavListItem();
                item.IsAddedCart = isAdded;
                item.AddToCart = AddToCart;
                item.RemoveFromCart = RemoveFromCart;
                item.RemoveFromFavList = RemoveFromFavList;
                item.Dock = DockStyle.Top;
                item.Build(movie);

                panelMain.Controls.Add(item);
                panelMain.Controls.Add(CreateDivider());
            }
            if (panelMain.Controls.Count == 1)
            {
                var label = new TransparentLabel();
                label.Font = lblFavList.Font;
                label.ForeColor = lblFavList.ForeColor;
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = "No movie added to favourites";
                panelMain.Controls.Add(label);
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            if(!timerBook.Enabled)
                timerBook.Start();

            if (btnBook.IconColor == Color.Gainsboro)
                return;

            LoadBookFavList();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            if (!timerMovie.Enabled)
                timerMovie.Start();

            if (btnMovie.IconColor == Color.Gainsboro)
                return;

            LoadMovieFavList();
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

        private void RemoveFromFavList(int id, bool isBook)
        {
            var result = DevMsgBox.Show("Are you sure want to remove?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            if(isBook)
            {
                _bookFavListService.RemoveByAccount(Account.Id, id);
            }
            else
            {
                _movieFavListService.RemoveByAccount(Account.Id, id);
            }
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
