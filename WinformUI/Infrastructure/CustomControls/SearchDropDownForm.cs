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
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class SearchDropDownForm : Form
    {
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
        private List<int> _selectedProductTypes;

        public Action<SearchParams> SetSearchParams { get; set; }
        public SearchParams Params { get; set; }

        public SearchDropDownForm()
        {
            InitializeComponent();
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

        }

        private void SearchDropDownForm_Load(object sender, EventArgs e)
        {
            //LoadBookGenres();
            //LoadMovieGenres();
            //LoadActors();
            //LoadAuthors();
            //LoadDirectors();
            //SetMaxMinValues();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
        }

        private void SetMaxMinValues()
        {
            var movieValues = _movieService.GetMaxMinValues().Split('-');
            var bookValues = _bookService.GetMaxMinValues().Split('-');

            nudMinValue.Minimum = nudMaxValue.Minimum = Math.Min(decimal.Parse(movieValues[0]), decimal.Parse(bookValues[0]));
            nudMaxValue.Maximum = nudMinValue.Maximum = Math.Max(decimal.Parse(movieValues[1]), decimal.Parse(bookValues[1]));
        }

        private void LoadBookGenres()
        {
            var genres = _bookGenreService.GetAll();
            foreach (var genre in genres)
            {
                var btn = GenerateButton(genre.Id, genre.Name, "BookGenre");
                panelBookGenres.Controls.Add(btn);
            }
            panelBookGenres.Height = (int)(Math.Floor((decimal)(genres.Count / 3)) * 51);
        }

        private void LoadMovieGenres()
        {
            var genres = _movieGenreService.GetAll();
            foreach (var genre in genres)
            {
                var btn = GenerateButton(genre.Id, genre.Name, "MovieGenre");
                panelMovieGenres.Controls.Add(btn);
            }
            panelMovieGenres.Height = (int)(Math.Floor((decimal)(genres.Count / 3)) * 51);
        }

        private void LoadActors()
        {
            var actors = _actorService.GetAll();
            foreach (var item in actors)
            {
                var btn = GenerateButton(item.Id, item.FirstName + " " + item.LastName, "Actor");
                panelActors.Controls.Add(btn);
            }
            panelActors.Height = (int)(Math.Floor((decimal)(actors.Count / 3)) * 51);
        }

        private void LoadAuthors()
        {
            var authors = _authorService.GetAll();
            foreach (var item in authors)
            {
                var btn = GenerateButton(item.Id, item.FirstName + " " + item.LastName, "Author");
                panelAuthors.Controls.Add(btn);
            }
            panelAuthors.Height = (int)(Math.Floor((decimal)(authors.Count / 3)) * 51);
        }

        private void LoadDirectors()
        {
            var directors = _directorService.GetAll();
            foreach (var item in directors)
            {
                var btn = GenerateButton(item.Id, item.FirstName + " " + item.LastName, "Director");
                panelDirectors.Controls.Add(btn);
            }

            panelDirectors.Height = (int)(Math.Floor((decimal)(directors.Count / 3)) * 51);
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
                    //AddToSelected(btn);
                    break;
                case IconChar.CircleMinus:
                    btn.IconChar = IconChar.CirclePlus;
                    btn.ForeColor = Color.FromArgb(68, 132, 188);
                    btn.IconColor = Color.FromArgb(68, 132, 188);
                    btn.BackColor = Color.Gainsboro;
                    //RemoveFromSelected(btn);
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
                case "Book":
                    _selectedProductTypes.Add(id);
                    break;
                case "Movie":
                    _selectedProductTypes.Add(id);
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
                case "Book":
                    _selectedProductTypes.Remove(id);
                    break;
                case "Movie":
                    _selectedProductTypes.Remove(id);
                    break;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Params = new SearchParams
            {
                SelectedActors = _selectedActors,
                SelectedAuthors = _selectedAuthors,
                SelectedDirectors = _selectedDirectors,
                SelectedBookGenres = _selectedBookGenres,
                SelectedMovieGenres = _selectedMovieGenres,
                SelectedProductTypes = _selectedProductTypes,
                MinValue = (int)nudMinValue.Value,
                MaxValue = (int)nudMaxValue.Value
            };

            SetSearchParams?.Invoke(Params);
        }

        private void nudMinValue_ValueChanged(object sender, EventArgs e)
        {
            if (nudMinValue.Value > nudMaxValue.Value)
                nudMaxValue.Value = nudMinValue.Value;
        }

        private void nudMaxValue_ValueChanged(object sender, EventArgs e)
        {
            if (nudMaxValue.Value < nudMinValue.Value)
                nudMinValue.Value = nudMaxValue.Value;
        }

       
    }

    public class SearchParams
    {
        public SearchParams() { }

        public List<int> SelectedProductTypes { get; set; }
        public List<int> SelectedBookGenres { get; set; }
        public List<int> SelectedMovieGenres { get; set; }
        public List<int> SelectedActors { get; set; }
        public List<int> SelectedAuthors { get; set; }
        public List<int> SelectedDirectors { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

    }
}
