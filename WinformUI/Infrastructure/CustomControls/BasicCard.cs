using Entities.Concrete;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class BasicCard : UserControl
    {
        [Browsable(false)]
        public Action<object, EventArgs> ClickEvent { get; set; }

        [Browsable(false)]
        public bool IsBook { get; set; }
        [Browsable(false)]
        public int RecordId { get; set; }

        public Image Image
        {
            get => pcbImage.Image;
            set => pcbImage.Image = value;
        }

        public Font TitleFont
        {
            get => lblTitle.Font;
            set => lblTitle.Font = value;
        }

        public Color TitleColor
        {
            get => lblTitle.ForeColor;
            set => lblTitle.ForeColor = value;
        }

        public string TitleText
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public int BorderSize { get; set; }

        public BasicCard()
        {
            InitializeComponent();
        }

        public void Build(Book book)
        {
            if (book is null)
                return;
            IsBook = true;
            try 
            {
                pcbImage.Load(book.Image);
            }
            catch 
            {
                pcbImage.Image = Properties.Resources.book;
            }
            lblTitle.Text = book.Name;
            RecordId = book.Id;
        }

        public void Build(Movie movie)
        {
            if (movie is null) 
                return;
            IsBook = false;
            try
            {
                pcbImage.Load(movie.Image);
            }
            catch 
            {
                pcbImage.Image = Properties.Resources.movie;
            }
            lblTitle.Text = movie.Name;
            RecordId = movie.Id;
        }

        public void Build(string title, string imageUrl)
        {
            pcbImage.Load(imageUrl);
            lblTitle.Text = title;
        }

        private void card_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
        }


        private void card_MouseHover(object sender, EventArgs e)
        {
            this.Padding = new Padding(BorderSize);
        }

        private void card_MouseLeave(object sender, EventArgs e)
        {
            this.Padding = new Padding(0);
        }
    }
}
