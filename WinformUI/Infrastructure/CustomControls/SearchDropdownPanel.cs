using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Models.RequestModels;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class SearchDropdownPanel : UserControl
    {
        #region DropShadowing

        private const int WS_EX_TRANSPARENT = 0x20;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the drop shadow manually
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(Color.FromArgb(64, Color.Black), 2))
            {
                path.AddRectangle(new Rectangle(8, 8, Width - 16, Height - 16));
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        #endregion

        private readonly IBookService _bookService;
        private readonly IMovieService _movieService;
        private readonly IBookGenreService _bookGenreService;
        private readonly IMovieGenreService _movieGenreService;
        private readonly IActorService _actorService;
        private readonly IAuthorService _authorService;
        private readonly IDirectorService _directorService;

        private List<BookGenre> _bookGenres;
        private List<int> _selectedBookGenres;
        private List<MovieGenre> _movieGenres;
        private List<int> _selectedMovieGenres;
        private List<Actor> _actors;
        private List<int> _selectedActors;
        private List<Author> _authors;
        private List<int> _selectedAuthors;
        private List<Director> _directors;
        private List<int> _selectedDirectors;

        public SearchDropdownPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
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

            _bookGenres = new List<BookGenre>();
            _selectedBookGenres = new List<int>();
            _movieGenres = new List<MovieGenre>();
            _selectedMovieGenres = new List<int>();
            _actors = new List<Actor>();
            _selectedActors = new List<int>();
            _authors = new List<Author>();
            _selectedAuthors = new List<int>();
            _directors = new List<Director>();
            _selectedDirectors = new List<int>();
        }


        private void SearchDropdownPanel_Load(object sender, EventArgs e)
        {
            LoadBookGenres();
            LoadMovieGenres();
            LoadActors();
            LoadAuthors();
            LoadDirectors();

        }

        private void LoadBookGenres()
        {
            var genres = _bookGenreService.GetAll();
            foreach (var genre in genres)
            {
                var btn = GenerateButton(genre.Id, genre.Name, "BookGenre");
                panelBookGenres.Controls.Add(btn);
            }
        }

        private void LoadMovieGenres()
        {
            var genres = _movieGenreService.GetAll();
            foreach(var genre in genres)
            {
                var btn = GenerateButton(genre.Id, genre.Name, "MovieGenre");
                panelMovieGenres.Controls.Add(btn);
            }
        }

        private void LoadActors()
        {
            var actors = _actorService.GetAll();
            foreach (var item in actors)
            {
                var btn = GenerateButton(item.Id, item.FirstName + " " + item.LastName, "Actor");
                panelActors.Controls.Add(btn);
            }
        }

        private void LoadAuthors()
        {
            var authors = _authorService.GetAll();
            foreach (var item in authors)
            {
                var btn = GenerateButton(item.Id, item.FirstName + " " + item.LastName, "Author");
                panelAuthors.Controls.Add(btn);
            }
        }

        private void LoadDirectors()
        {
            var directors = _directorService.GetAll();
            foreach (var item in directors)
            {
                var btn = GenerateButton(item.Id, item.FirstName + " " + item.LastName, "Director");
                panelDirectors.Controls.Add(btn);
            }

            //panelDirectors.Height = Math.Floor((decimal)(directors.Count / 3))
        }

        private IconButton GenerateButton(int id, string name, string type)
        {
            var button = new IconButton();
            button.Size = new Size(195, 50);
            button.ForeColor = Color.FromArgb(68, 132, 188);
            button.IconColor = Color.FromArgb(68, 132, 188);
            button.BackColor = Color.Gainsboro;
            button.Text = name;
            button.Tag = id + " " + type;
            button.Click += Button_Click;
            button.IconChar = IconChar.CirclePlus;

            return button;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            var btn = (IconButton)sender;
            switch (btn.IconChar)
            {
                case IconChar.CirclePlus:
                    btn.IconChar = IconChar.CircleMinus;
                    btn.BackColor = Color.FromArgb(68, 132, 188);
                    btn.ForeColor = Color.Gainsboro;
                    btn.IconColor = Color.Gainsboro;
                    AddToSelected(btn);
                    break;
                case IconChar.CircleMinus:
                    btn.IconChar = IconChar.CirclePlus;
                    btn.ForeColor = Color.FromArgb(68, 132, 188);
                    btn.IconColor = Color.FromArgb(68, 132, 188);
                    btn.BackColor = Color.Gainsboro;
                    RemoveFromSelected(btn);
                    break;
                default:
                    break;
            }
        }

        private void AddToSelected(IconButton button)
        {
            var temp = button.Tag.ToString().Split();
            var id = int.Parse(temp[0]);
            var type = temp[1];

            switch (type)
            {
                case "BookGenre":
                    _selectedBookGenres.Add(id);
                    break;
                case "MovieGenre":
                    _selectedMovieGenres.Add(id);
                  break;
                case "Actor":
                    _selectedActors.Add(id);
                    break;
                case "Author":
                    _selectedAuthors.Add(id);
                  break;
                case "Director":
                    _selectedDirectors.Add(id);
                    break;
            }
        }

        private void RemoveFromSelected(IconButton button)
        {
            var temp = button.Tag.ToString().Split();
            var id = int.Parse(temp[0]);
            var type = temp[1];

            switch (type)
            {
                case "BookGenre":
                    _selectedBookGenres.Remove(id);
                    break;
                case "MovieGenre":
                    _selectedMovieGenres.Remove(id);
                    break;
                case "Actor":
                    _selectedActors.Remove(id);
                    break;
                case "Author":
                    _selectedAuthors.Remove(id);
                    break;
                case "Director":
                    _selectedDirectors.Remove(id);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }
    }
}
