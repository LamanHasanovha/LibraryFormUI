using Entities.Concrete;
using Entities.Models.ResponseModels;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class BigCard : UserControl
    {
        public Color BorderColor
        {
            get => this.BackColor;
            set => this.BackColor = value;
        }

        public Padding BorderSize { get; set; }

        public string TitleText
        {
            get => lblTitle.Text;
            set
            {
                this.lblTitle.Text = value;
            }
        }

        public Font TitleFont 
        {
            get => lblTitle.Font;
            set
            {
                lblTitle.Font = value;
                Invalidate();
            }
        }

        public Color TitleColor
        {
            get => lblTitle.ForeColor;
            set
            {
                lblTitle.ForeColor = value;
                Invalidate();
            }
        }

        public Font DescriptionFont
        {
            get { return lblDescription.Font; }
            set { lblDescription.Font = value; Invalidate(); }
        }

        public Color DescriptionColor
        {
            get => lblDescription.ForeColor; 
            set 
            {
                lblDescription.ForeColor = value;
                Invalidate();
            }   
        }

        public string DescriptionText
        {
            get => lblDescription.Text;
            set
            {
                this.lblDescription.Text = value;
            }
        }

        [Browsable(false)]
        public Action<object, EventArgs> ClickEvent { get; set; }
        [Browsable(false)]
        public bool IsBook { get; set; }
        [Browsable (false)]
        public int RecordId { get; set; }

        public BigCard()
        {
            InitializeComponent();
        }

        private void Card_MouseHover(object sender, EventArgs e)
        {
            this.Padding = BorderSize;
            Invalidate();
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            this.Padding = Padding.Empty;
            Invalidate();
        }

        public void Build(Movie movie)
        {
            IsBook = false;
            lblTitle.Text = movie.Name;
            lblDescription.Text = movie.Description;
            try
            {
                pcbImage.Load(movie.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.movie;
            }
            RecordId = movie.Id;
        }

        public void Build(MovieResponseModel movie)
        {
            IsBook = false;
            lblTitle.Text = movie.Name;
            lblDescription.Text = movie.Description;
            try
            {
                pcbImage.Load(movie.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.movie;
            }
            RecordId = movie.Id;
        }

        public void Build(Book book)
        {
            IsBook = true;
            lblTitle.Text = book.Name;
            lblDescription.Text=book.Description;
            try
            {
                pcbImage.Load(book.Image);
            }
            catch
            {
                pcbImage.Image = Properties.Resources.book;
            }
            RecordId = book.Id;
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
            IsBook = true;
            lblTitle.Text = book.Name;
            lblDescription.Text = book.Description;
            RecordId = book.Id;
        }

        public void Build(string title, string description, string imageUrl)
        {
            lblTitle.Text = title;
            lblDescription.Text = description;
            pcbImage.Load(imageUrl);
        }

        private void card_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
        }
    }
}
