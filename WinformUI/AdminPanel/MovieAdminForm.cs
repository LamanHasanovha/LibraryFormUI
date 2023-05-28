using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers;
using Core.WinFormUI.Design.MessageBox;
using Core.WinFormUI.Infrastructure.Helpers;
using Entities.Concrete;
using Entities.Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.AdminPanel
{
    public partial class MovieAdminForm : BaseForm
    {
        private readonly IMovieService _movieService;
        private readonly IMovieGenreService _movieGenreService;
        private readonly IMovieGenreListService _movieGenreListService;
        private readonly IDirectorService _directorService;
        private readonly IActorService _actorService;
        private readonly IMovieActorService _movieActorService;

        public MovieAdminForm()
        {
            InitializeComponent();
            _movieService = new MovieManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieGenreService = new MovieGenreManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieGenreListService = new MovieGenreListManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _directorService = new DirectorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _actorService = new ActorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });
            _movieActorService = new MovieActorManager(InstanceFactory.GetInstance<HttpClient>(new BusinessModule()), ConfigurationHelper.GetAppSetting("BaseAddress"),
                       new UserForLoginModel { Email = ConfigurationHelper.GetAppSetting("Email"), Password = ConfigurationHelper.GetAppSetting("Password") });

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void AccountAdminForm_Load(object sender, EventArgs e)
        {
            LoadGenres();
            LoadDirectors();
            LoadData();
            LoadStars();
            DesignDataGridView(dgwMovies);
        }

        private void LoadData()
        {
            dgwMovies.DataSource = _movieService.GetMovies();
        }

        protected override void DesignDataGridView(DataGridView dgwBase)
        {
            base.DesignDataGridView(dgwBase);

        }

        private void LoadGenres()
        {
            slcGenres.Data = _movieGenreService.GetAll();
            slcGenres.Items = ((List<MovieGenre>)slcGenres.Data).Select(m => m.Name).ToArray();
        }

        private void LoadDirectors()
        {
            cmbDirectors.DataSource = _directorService.GetAll().Select(d => new { d.Id, FullName = d.FirstName + " " + d.LastName }).ToList();
            cmbDirectors.DisplayMember = "FullName";
            cmbDirectors.ValueMember = "Id";
        }

        private void LoadStars()
        {
            slcActors.Data = _actorService.GetAll();
            slcActors.Items = ((List<Actor>)slcActors.Data).Select(m => m.FirstName + " " + m.LastName).ToArray();
        }

        //protected override void OnPaintBackground(PaintEventArgs e) { }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to add?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                if (pcbImage.Image == null)
                    tbxImageUrl.Texts = "local";

                var movie = _movieService.Add(new Movie
                {
                    Name = tbxName.Texts.Trim(),
                    Description = tbxDescription.Texts.Trim(),
                    DirectorId = (int)cmbDirectors.SelectedValue,
                    Imdb = Convert.ToDouble(tbxImdb.Texts.Trim()),
                    Time = new TimeSpan(int.Parse(tbxHour.Texts), int.Parse(tbxMinutes.Texts), 0).Ticks,
                    ReleaseDate = dtpReleaseDate.Value,
                    Image = tbxImageUrl.Texts.Trim(),
                    Price = Convert.ToDecimal(tbxPrice.Texts.Trim())
                });

                AddMovieGenres(movie);
                AddMovieActors(movie);
            });

            pcbImage.Image = Properties.Resources.movie;

            LoadData();
        }

        private void AddMovieGenres(Movie movie)
        {
            var genres = (List<MovieGenre>)slcGenres.Data;

            for (int i = 0; i < slcGenres.SelectedIndexes.Count; i++)
            {
                _movieGenreListService.Add(new MovieGenreList
                {
                    MovieId = movie.Id,
                    MovieGenreId = genres[slcGenres.SelectedIndexes[i]].Id
                });
            }
        }

        private void AddMovieActors(Movie movie)
        {
            var actors = (List<Actor>)slcActors.Data;

            for (int i = 0; i < slcActors.SelectedIndexes.Count; i++)
            {
                _movieActorService.Add(new MovieActor
                {
                    MovieId = movie.Id,
                    ActorId = actors[slcActors.SelectedIndexes[i]].Id
                });
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to update?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                if (pcbImage.Image == null)
                    tbxImageUrl.Texts = "local";

                var movie = _movieService.Update(new Movie
                {
                    Id = RecordId,
                    Name = tbxName.Texts.Trim(),
                    Description = tbxDescription.Texts.Trim(),
                    DirectorId = (int)cmbDirectors.SelectedValue,
                    Imdb = Convert.ToDouble(tbxImdb.Texts.Trim()),
                    Time = new TimeSpan(int.Parse(tbxHour.Texts), int.Parse(tbxMinutes.Texts), 0).Ticks,
                    ReleaseDate = dtpReleaseDate.Value,
                    Image = tbxImageUrl.Texts.Trim(),
                    Price = Convert.ToDecimal(tbxPrice.Texts.Trim())
                });

                UpdateGenres(movie);
                UpdateActors(movie);
            });

            pcbImage.Image = Properties.Resources.movie;

            LoadData();
        }
        
        private void UpdateGenres(Movie movie)
        {
            var genres = (List<MovieGenre>)slcGenres.Data;

            var list = new List<MovieGenreList>();

            for (int i = 0; i < slcGenres.SelectedIndexes.Count; i++)
            {
                list.Add(new MovieGenreList
                {
                    MovieId = movie.Id,
                    MovieGenreId = genres[slcGenres.SelectedIndexes[i]].Id
                });
            }

            _movieGenreListService.UpdateByMovie(list);
        }

        private void UpdateActors(Movie movie)
        {
            var actors = (List<Actor>)slcActors.Data;

            var list = new List<MovieActor>();

            for (int i = 0; i < slcActors.SelectedIndexes.Count; i++)
            {
                list.Add(new MovieActor
                {
                    MovieId = movie.Id,
                    ActorId = actors[slcActors.SelectedIndexes[i]].Id
                });
            }

            _movieActorService.UpdateByMovie(list);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to delete?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            HandleException(() =>
            {
                _movieGenreListService.DeleteByMovie(RecordId);
                _movieActorService.DeleteByMovie(RecordId);
                _movieService.Delete(new Movie { Id = RecordId });
            });

            LoadData();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxName.Texts = "";
            tbxDescription.Texts = "";
            dtpReleaseDate.Value = DateTime.Now;
            slcGenres.SelectedIndexes = new List<int>();
            tbxImdb.Texts = "";
            slcActors.SelectedIndexes = new List<int>();
            tbxHour.Texts = "";
            tbxMinutes.Texts = "";
            tbxPrice.Texts = "";
            pcbImage.Image = null;
            tbxImageUrl.Texts = "";
        }

        private void dgwAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RecordId = Convert.ToInt32(dgwMovies.CurrentRow.Cells[0].Value);

            var movie = _movieService.Get(RecordId);
            tbxName.Texts = movie.Name.Trim();
            tbxDescription.Texts = movie.Description.Trim();
            cmbDirectors.SelectedValue = movie.DirectorId;
            dtpReleaseDate.Value = movie.ReleaseDate;
            tbxImdb.Texts = movie.Imdb.ToString();
            var time = new TimeSpan(movie.Time);
            tbxHour.Texts = time.Hours.ToString();
            tbxMinutes.Texts = time.Minutes.ToString();
            tbxPrice.Texts = movie.Price.ToString();
            tbxImageUrl.Texts = movie.Image;
            try
            {
                pcbImage.Load(movie.Image);
            } catch 
            {
                pcbImage.Image = Properties.Resources.movie;
            }

            var listGenre = _movieGenreListService.GetByMovie(RecordId).Select(l => l.MovieGenreId).ToList();
            var indexesGenre = new List<int>();
            var dataGenre = (List<MovieGenre>)slcGenres.Data;
            foreach (var item in listGenre)
            {
                for (int i = 0; i < dataGenre.Count; i++)
                {
                    if (dataGenre[i].Id == item)
                        indexesGenre.Add(i);
                }
                //indexesGenre.Add(dataGenre[item - 1].Id - 1);
            }
            slcGenres.SelectedIndexes = indexesGenre;
            slcGenres.SetSelectedItems();


            var listActor = _movieActorService.GetByMovie(RecordId).Select(l => l.Id).ToList();
            var indexesActor = new List<int>();
            var dataActor = (List<Actor>)slcActors.Data;
            foreach (var item in listActor)
            {
                for (int i = 0; i < dataActor.Count; i++)
                {
                    if (dataActor[i].Id == item)
                        indexesActor.Add(i);
                }
                //indexesActor.Add(dataActor[item - 1].Id - 1);
            }
            slcActors.SelectedIndexes = indexesActor;
            slcActors.SetSelectedItems();
        }

        private void tbxImageUrl__TextChanged(object sender, EventArgs e)
        {
            try
            {
                pcbImage.Load(tbxImageUrl.Texts.Trim());
            }
            catch 
            {
                pcbImage.Image = Properties.Resources.movie;
            }
        }
    }
}
