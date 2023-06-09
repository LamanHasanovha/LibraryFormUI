﻿using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Constants;
using Entities.Models.RequestModels;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WinformUI.Infrastructure.CustomControls;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Content
{
    public partial class MainMenu : Form
    {
        private int borderSize = 4;
        private Size formSize;
        private BaseForm _activeForm;
        private IconButton _currentButton;
        private SearchDropDownForm _searchDropDownForm;

        private readonly IMenuContentService _menuContentService;
        private readonly IMenuObjectService _menuObjectService;
        private readonly IBookService _bookService;
        private readonly IMovieService _movieService;
        private readonly IBookGenreService _bookGenreService;
        private readonly IMovieGenreService _movieGenreService;
        private readonly IActorService _actorService;
        private readonly IAuthorService _authorService;
        private readonly IDirectorService _directorService;
        private readonly ICartService _cartService;
        private readonly IBookWishListService _bookWishListService;
        private readonly IMovieWishListService _movieWishListService;
        private readonly IBookFavListService _bookFavListService;
        private readonly IMovieFavListService _movieFavListService;
        private readonly IRecommenderService _recommenderService;

        public Account Account { get; set; }
        public SearchParams SearchParams { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            _menuContentService = new MenuContentManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                      new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _menuObjectService = new MenuObjectManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookService = new BookManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookGenreService = new BookGenreManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieGenreService = new MovieGenreManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _actorService = new ActorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _authorService = new AuthorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _directorService = new DirectorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _cartService = new CartManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookWishListService = new BookWishListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieWishListService = new MovieWishListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _bookFavListService = new BookFavListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieFavListService = new MovieFavListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                     new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _recommenderService = new RecommenderManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                    new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

            _searchDropDownForm = new SearchDropDownForm
            {
                SetSearchParams = SetSearchParams,
                Visible = false
            };

            CollapseMenu();
            this.Padding = new Padding(borderSize);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            LoadHomePage();
        }

        private void OpenChildForm(BaseForm childForm, IconButton sender)
        {
            if (_currentButton != null)
            {
                _currentButton.BackColor = Color.FromArgb(68, 132, 188);
                _currentButton.IconColor = Color.Gainsboro;
                _currentButton.ForeColor = Color.Gainsboro;
            }

            _currentButton = sender;
            _currentButton.BackColor = Color.Gainsboro;
            _currentButton.IconColor = Color.FromArgb(68, 132, 188);
            _currentButton.ForeColor = Color.FromArgb(68, 132, 188);

            _activeForm?.Close();
            _activeForm = childForm;
            childForm.Account = Account;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.Account = Account;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void OpenFromChild(BaseForm childForm, bool deactiveSideButton)
        {
            if (deactiveSideButton & _currentButton != null)
            {
                _currentButton.BackColor = Color.FromArgb(68, 132, 188);
                _currentButton.IconColor = Color.Gainsboro;
                _currentButton.ForeColor = Color.Gainsboro;
            }

            _activeForm?.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.Account = Account;
            panelContent.Controls.Clear();
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) // Collapse menu
            {
                panelMenu.Width = 80;
                pcbLogo.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                panelMenu.Width = 230;
                pcbLogo.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void MainMenu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to quit?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result != DialogResult.OK)
                return;

            System.Windows.Forms.Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadHomePage();
        }

        private void btnWishList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WishListForm { Account = Account}, (IconButton)sender);
        }

        private void btnFavlist_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FavouriteForm { Account = Account}, (IconButton)sender);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CartForm { Account = Account}, (IconButton)sender);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountForm { OpenFormEvent = OpenFromChild, Account = Account }, (IconButton)sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to log out?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result != DialogResult.OK)
                return;

            this.Hide();
            var form = new Login();
            form.ShowDialog();
        }

        public void LoadMenuContent(int contentId)
        {
            var content = _menuContentService.Get(contentId);
            var objects = _menuObjectService.GetByContent(contentId);

            BuildContent(content, objects);
        }

        private void BuildContent(MenuContent content, List<MenuObject> objects)
        {
            var productType = objects.FirstOrDefault()?.ProductType == ProductTypes.Book ? SliderType.Book : SliderType.Movie;

            switch (content.ContentType)
            {
                case ContentTypes.SliderDetails:
                    var sliderDetails = CreateSliderContent(productType, ObjectTypes.Details, content, objects);
                    panelContent.Controls.Add(sliderDetails);
                    break;
                case ContentTypes.SliderBigCards:
                    var sliderBigCards = CreateSliderContent(productType, ObjectTypes.BigCards, content, objects);
                    panelContent.Controls.Add(sliderBigCards);
                    break;
                case ContentTypes.SpecialSliderNewsCard:
                    var specialSliderNewsCard = CreateSpecialSliderContent(SpecialSliderTypes.NewsCard, content, objects);
                    panelContent.Controls.Add(specialSliderNewsCard);
                    break;
                case ContentTypes.SpecialSliderBigCard:
                    var specialSliderBigCard = CreateSpecialSliderContent(SpecialSliderTypes.BigCard, content, objects);
                    panelContent.Controls.Add(specialSliderBigCard);
                    break;
                case ContentTypes.News:
                    var newsPresenter = CreateNewsPresenterContent(content, objects);
                    panelContent.Controls.Add(newsPresenter);
                    break;
                case ContentTypes.SupriseMe:
                    var supriseMe = CreateSupriseMeContent(content, objects);
                    panelContent.Controls.Add(supriseMe);
                    break;
                case ContentTypes.ButtonComplex:
                    var buttonComplex = CreateButtonComplexContent(content, objects);
                    panelContent.Controls.Add(buttonComplex);
                    break;
                default:
                    break;
            }
        }

        private Slider CreateSliderContent(SliderType sliderType, ObjectTypes layoutType, MenuContent content, List<MenuObject> objects)
        {
            var slider = new Slider();
            slider.Dock = DockStyle.Top;
            slider.Height = 600;

            slider.Type = sliderType;
            slider.LayoutType = layoutType;
            slider.ButtonColor = Color.FromArgb(230, 230, 230);
            slider.ButtonIconColor = Color.FromArgb(68, 132, 188);
            slider.DescriptionForeColor = slider.TitleForeColor = Color.FromArgb(68, 132, 188);
            var text = content.Title.Split('|');
            slider.TitleText = text.Length == 2 ? text[1] : content.Title;
            slider.DescriptionText = content.Description;

            slider.AddCart = AddToCart;
            slider.AddFavourites = AddToFavourites;
            slider.AddWishlist = AddToWishList;
            slider.MovieClickEvent = SliderObjectMovieClickEvent;
            slider.BookClickEvent = SliderObjectBookClickEvent;

            if (text.Length > 1)
            {
                switch (text[0])
                {
                    case "User":
                        switch (slider.Type)
                        {
                            case SliderType.Book:
                                var books = _recommenderService.GetBooksByAccount(Account.Id, 10);
                                foreach (var book in books)
                                {
                                    switch (slider.LayoutType)
                                    {
                                        case ObjectTypes.Details:
                                            var bookObjectDetails = new BookSliderObject();
                                            bookObjectDetails.Build(book);
                                            slider.Add(bookObjectDetails);
                                            break;
                                        case ObjectTypes.BigCards:
                                            var bookObjectBigCards = new BigCard();
                                            bookObjectBigCards.Build(book);
                                            slider.Add(bookObjectBigCards);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case SliderType.Movie:
                                var movies = _recommenderService.GetMoviesByAccount(Account.Id, 10);
                                foreach (var movie in movies)
                                {
                                    switch (slider.LayoutType)
                                    {
                                        case ObjectTypes.Details:
                                            var movieObjectDetails = new MovieSliderObject();
                                            movieObjectDetails.Build(movie);
                                            slider.Add(movieObjectDetails);
                                            break;
                                        case ObjectTypes.BigCards:
                                            var bookObjectBigCards = new BigCard();
                                            bookObjectBigCards.Build(movie);
                                            slider.Add(bookObjectBigCards);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Popular":
                        switch (slider.Type)
                        {
                            case SliderType.Book:
                                var books = _bookService.GetPopularBooks();
                                foreach (var book in books)
                                {
                                    switch (slider.LayoutType)
                                    {
                                        case ObjectTypes.Details:
                                            var bookObjectDetails = new BookSliderObject();
                                            bookObjectDetails.Build(book);
                                            slider.Add(bookObjectDetails);
                                            break;
                                        case ObjectTypes.BigCards:
                                            var bookObjectBigCards = new BigCard();
                                            bookObjectBigCards.Build(book);
                                            slider.Add(bookObjectBigCards);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            case SliderType.Movie:
                                var movies = _movieService.GetPopularMovies();
                                foreach (var movie in movies)
                                {
                                    switch (slider.LayoutType)
                                    {
                                        case ObjectTypes.Details:
                                            var bookObjectDetails = new MovieSliderObject();
                                            bookObjectDetails.Build(movie);
                                            slider.Add(bookObjectDetails);
                                            break;
                                        case ObjectTypes.BigCards:
                                            var bookObjectBigCards = new BigCard();
                                            bookObjectBigCards.Build(movie);
                                            slider.Add(bookObjectBigCards);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                return slider;
            }

            foreach (var item in objects)
            {
                switch (slider.Type)
                {
                    case SliderType.Book:
                        var book = _bookService.Get(item.RecordId);
                        switch (slider.LayoutType)
                        {
                            case ObjectTypes.Details:
                                var bookObjectDetails = new BookSliderObject();
                                bookObjectDetails.Build(book);
                                slider.Add(bookObjectDetails);
                                break;
                            case ObjectTypes.BigCards:
                                var bookObjectBigCards = new BigCard();
                                bookObjectBigCards.Build(book);
                                slider.Add(bookObjectBigCards);
                                break;
                            default:
                                break;
                        }
                        break;
                    case SliderType.Movie:
                        var movie = _movieService.Get(item.RecordId);
                        switch (slider.LayoutType)
                        {
                            case ObjectTypes.Details:
                                var movieObjectDetails = new MovieSliderObject();
                                movieObjectDetails.Build(movie);
                                slider.Add(movieObjectDetails);
                                break;
                            case ObjectTypes.BigCards:
                                var movieObjectBigCards = new BigCard();
                                movieObjectBigCards.Build(movie);
                                slider.Add(movieObjectBigCards);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }

            return slider;
        }

        private void AddToFavourites(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(MovieSliderObject))
            {
                var obj = (MovieSliderObject)sender;

                _movieFavListService.Add(new MovieFavList
                {
                    AccountId = Account.Id,
                    MovieId = obj.RecordId
                });
            }
            else
            {
                var obj = (BookSliderObject)sender;

                _bookFavListService.Add(new BookFavList
                {
                    AccountId = Account.Id,
                    BookId = obj.RecordId
                });
            }
        }

        private void AddToWishList(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(MovieSliderObject))
            {
                var obj = (MovieSliderObject)sender;

                _movieWishListService.Add(new MovieWishList
                {
                    AccountId = Account.Id,
                    MovieId = obj.RecordId
                });
            }
            else
            {
                var obj = (BookSliderObject)sender;

                _bookWishListService.Add(new BookWishList
                {
                    AccountId = Account.Id,
                    BookId = obj.RecordId
                });
            }
        }

        private void AddToCart(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(MovieSliderObject))
            {
                var obj = (MovieSliderObject)sender;

                _cartService.Add(new Cart
                {
                    AccountId = Account.Id,
                    Type = ProductTypes.Movie,
                    RecordId = obj.RecordId
                });
            }
            else
            {
                var obj = (BookSliderObject)sender;

                _cartService.Add(new Cart
                {
                    AccountId = Account.Id,
                    Type = ProductTypes.Book,
                    RecordId = obj.RecordId
                });
            }
        }

        private void SliderObjectBookClickEvent(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                var obj = (BookSliderObject)sender;
                id = obj.RecordId;
            }
            catch { }
            try
            {
                var obj = (BigCard)sender;
                id = obj.RecordId;
            }
            catch { }

            OpenFromChild(new BookForm { RecordId = id, Account = Account }, true);
        }

        private void SliderObjectMovieClickEvent(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                var obj = (MovieSliderObject)sender;
                id = obj.RecordId;
            }
            catch { }
            try
            {
                var obj = (BigCard)sender;
                id = obj.RecordId;
            }
            catch { }

            OpenFromChild(new MovieForm { RecordId = id, Account = Account }, true);
        }

        private SpecialSlider CreateSpecialSliderContent(SpecialSliderTypes sliderType, MenuContent content, List<MenuObject> objects)
        {
            var slider = new SpecialSlider();
            slider.Dock = DockStyle.Top;
            slider.Height = 600;

            slider.Type = sliderType;
            slider.ButtonColor = Color.FromArgb(230, 230, 230);
            slider.ButtonIconColor = Color.FromArgb(68, 132, 188);
            slider.ShowButtonColor = Color.FromArgb(230, 230, 230);
            slider.ShowButtonColor = Color.FromArgb(68, 132, 188);
            slider.ShowButtonForeColor = Color.Gainsboro;
            slider.DescriptionForeColor = Color.FromArgb(68, 132, 188);
            slider.DescriptionText = content.Description;
            slider.PersonType = PersonTypes.None;

            slider.BookClickEvent = SpecialSliderBookClickEvent;
            slider.MovieClickEvent = SpecialSliderMovieClickEvent;
            slider.SeeAllClickEvent = SpecialSliderSeeAllClickEvent;

            var text = content.Title.Split('|');

            if (text.Length > 1)
            {
                switch (text[0])
                {
                    case "Actor":
                        slider.PersonType = PersonTypes.Actor;
                        var actor = _actorService.GetRandomActor();
                        slider.DescriptionText = actor.FirstName + " " + actor.LastName;
                        slider.ImageUrl = actor.Image;
                        slider.RecordId = actor.Id;
                        var actorMovies = _movieService.GetByActor(actor.Id);
                        if (actorMovies is null)
                            break;
                        foreach (var movie in actorMovies)
                        {
                            switch (sliderType)
                            {
                                case SpecialSliderTypes.NewsCard:
                                    var newsCard = new NewsCard();
                                    newsCard.Build(movie);
                                    slider.Add(newsCard);
                                    break;
                                case SpecialSliderTypes.BigCard:
                                    var bigCard = new BigCard();
                                    bigCard.Build(movie);
                                    slider.Add(bigCard);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "Author":
                        slider.PersonType = PersonTypes.Author;
                        var author = _authorService.GetRandomAuthor();
                        slider.DescriptionText = author.FirstName + " " + author.LastName;
                        slider.ImageUrl = author.Image;
                        slider.RecordId = author.Id;
                        var books = _bookService.GetByAuthor(author.Id);
                        if (books is null)
                            break;
                        foreach (var book in books)
                        {
                            switch (sliderType)
                            {
                                case SpecialSliderTypes.NewsCard:
                                    var newsCard = new NewsCard();
                                    newsCard.Build(book);
                                    slider.Add(newsCard);
                                    break;
                                case SpecialSliderTypes.BigCard:
                                    var bigCard = new BigCard();
                                    bigCard.Build(book);
                                    slider.Add(bigCard);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    case "Director":
                        slider.PersonType = PersonTypes.Director;
                        var director = _directorService.GetRandomDirector();
                        slider.DescriptionText = director.FirstName + " " + director.LastName;
                        slider.ImageUrl = director.Image;
                        slider.RecordId = director.Id;
                        var directorMovies = _movieService.GetByDirector(director.Id);
                        if (directorMovies is null)
                            break;
                        foreach (var movie in directorMovies)
                        {
                            switch (sliderType)
                            {
                                case SpecialSliderTypes.NewsCard:
                                    var newsCard = new NewsCard();
                                    newsCard.Build(movie);
                                    slider.Add(newsCard);
                                    break;
                                case SpecialSliderTypes.BigCard:
                                    var bigCard = new BigCard();
                                    bigCard.Build(movie);
                                    slider.Add(bigCard);
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }

                return slider;
            }

            foreach (var item in objects)
            {
                switch (item.ProductType)
                {
                    case ProductTypes.Book:
                        var book = _bookService.Get(item.RecordId);
                        switch (sliderType)
                        {
                            case SpecialSliderTypes.NewsCard:
                                var newsCard = new NewsCard();
                                newsCard.Build(book);
                                slider.Add(newsCard);
                                break;
                            case SpecialSliderTypes.BigCard:
                                var bigCard = new BigCard();
                                bigCard.Build(book);
                                slider.Add(bigCard);
                                break;
                            default:
                                break;
                        }
                        break;
                    case ProductTypes.Movie:
                        var movie = _movieService.Get(item.RecordId);
                        switch (sliderType)
                        {
                            case SpecialSliderTypes.NewsCard:
                                var newsCard = new NewsCard();
                                newsCard.Build(movie);
                                slider.Add(newsCard);
                                break;
                            case SpecialSliderTypes.BigCard:
                                var bigCard = new BigCard();
                                bigCard.Build(movie);
                                slider.Add(bigCard);
                                break;
                            default:
                                break;
                        }
                        break;
                    case ProductTypes.Other:
                        break;
                    default:
                        break;
                }
            }

            return slider;
        }

        private void SpecialSliderBookClickEvent(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                var obj = (BigCard)sender;
                id = obj.RecordId;
            }
            catch { }
            try
            {
                var obj = (NewsCard)sender;
                id = obj.RecordId;
            }
            catch { }

            OpenFromChild(new BookForm { RecordId = id, Account = Account }, true);
        }

        private void SpecialSliderMovieClickEvent(object sender, EventArgs e)
        {
            var id = 0;
            try
            {
                var obj = (BigCard)sender;
                id = obj.RecordId;
            }
            catch { }
            try
            {
                var obj = (NewsCard)sender;
                id = obj.RecordId;
            }
            catch { }

            OpenFromChild(new MovieForm { RecordId = id, Account = Account }, true);
        }

        private void SpecialSliderSeeAllClickEvent(object sender, EventArgs e)
        {
            var obj = (SpecialSlider)sender;
            switch (obj.PersonType)
            {
                case PersonTypes.Actor:
                    OpenFromChild(new ActorForm { RecordId = obj.RecordId, Account = Account }, true);
                    break;
                case PersonTypes.Author:
                    OpenFromChild(new AuthorForm { RecordId = obj.RecordId, Account = Account }, true);
                    break;
                case PersonTypes.Director:
                    OpenFromChild(new DirectorForm { RecordId = obj.RecordId, Account = Account }, true);
                    break;
                case PersonTypes.None:
                    break;
                default:
                    break;
            }
        }

        private NewsPresenter CreateNewsPresenterContent(MenuContent content, List<MenuObject> objects)
        {
            var presenter = new NewsPresenter();
            presenter.Dock = DockStyle.Top;
            presenter.Height = 600;

            presenter.TitleText = content.Title;
            presenter.DescriptionText = content.Description;

            foreach (var item in objects)
            {
                switch (item.ProductType)
                {
                    case ProductTypes.Book:
                        var book = _bookService.Get(item.RecordId);
                        presenter.ClickEvent = PresenterBookClickEvent;
                        var bookCard = new NewsCard();
                        bookCard.Build(book);
                        presenter.Add(bookCard);
                        break;
                    case ProductTypes.Movie:
                        var movie = _movieService.Get(item.RecordId);
                        presenter.ClickEvent = PresenterMovieClickEvent;
                        var movieCard = new NewsCard();
                        movieCard.Build(movie);
                        presenter.Add(movieCard);
                        break;
                    case ProductTypes.Other:
                        var card = new NewsCard();
                        card.Build(content.Title, content.Description, "local");
                        presenter.Add(card);
                        break;
                    default:
                        break;
                }
            }

            return presenter;
        }

        private void PresenterBookClickEvent(object sender, EventArgs e)
        {
            var obj = (NewsCard)sender;
            OpenFromChild(new BookForm { RecordId = obj.RecordId, Account = Account }, true);
        }

        private void PresenterMovieClickEvent(object sender, EventArgs e)
        {
            var obj = (NewsCard)sender;
            OpenFromChild(new MovieForm { RecordId = obj.RecordId, Account = Account }, true);
        }

        private SupriseMe CreateSupriseMeContent(MenuContent content, List<MenuObject> objects)
        {
            var supriseMe = new SupriseMe();
            supriseMe.Dock = DockStyle.Top;
            supriseMe.Height = 600;

            supriseMe.ShowBookClickEvent = SupriseMeShowBookClickEvent;
            supriseMe.ShowMovieClickEvent = SupriseMeShowMovieClickEvent;

            return supriseMe;
        }

        private void SupriseMeShowBookClickEvent(object sender, EventArgs e)
        {
            var obj = (SupriseMe)sender;
            OpenFromChild(new BookForm { RecordId = obj.RecordId, Account = Account }, true);
        }

        private void SupriseMeShowMovieClickEvent(object sender, EventArgs e)
        {
            var obj = (SupriseMe)sender;
            OpenFromChild(new MovieForm { RecordId = obj.RecordId, Account = Account }, true);
        }

        private ButtonComplex CreateButtonComplexContent(MenuContent content, List<MenuObject> objects)
        {
            var buttonComplex = new ButtonComplex();
            buttonComplex.Dock = DockStyle.Top;
            buttonComplex.Height = 600;


            return buttonComplex;
        }

        public void LoadHomePage()
        {
            panelContent.Controls.Clear();

            var contents = _menuContentService.GetAll().OrderByDescending(c => c.Priority);

            foreach (var item in contents)
            {
                LoadMenuContent(item.Id);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pcbLogo.Visible)
            {
                if (panelMenu.Width == 80)
                {
                    pcbLogo.Visible = false;
                    btnMenu.Dock = DockStyle.Top;
                    foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                    {
                        menuButton.Text = "";
                        menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                        menuButton.Padding = new Padding(0);
                    }
                    timer.Stop();
                    timer.Dispose();
                    this.Refresh();
                }
                panelMenu.Width -= 10;
            }
            else
            {
                if (panelMenu.Width == 230)
                {
                    pcbLogo.Visible = true;
                    btnMenu.Dock = DockStyle.None;
                    foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                    {
                        menuButton.Text = "   " + menuButton.Tag.ToString();
                        menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                        menuButton.Padding = new Padding(10, 0, 0, 0);
                    }
                    timer.Stop();
                    timer.Dispose();
                    this.Refresh();
                }
                panelMenu.Width += 10;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _searchDropDownForm.Visible = true;
            _searchDropDownForm.ShowDialog();
            SearchParams = _searchDropDownForm.Params;
        }

        private void SetSearchParams(SearchParams searchParams)
        {
            SearchParams = searchParams;
        }

        private void timerTest_Tick(object sender, EventArgs e)
        {

        }
    }
}
