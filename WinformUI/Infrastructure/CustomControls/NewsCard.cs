using Entities.Concrete;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class NewsCard : UserControl
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

        public Font DescriptionFont
        {
            get => lblDescription.Font;
            set => lblDescription.Font = value;
        }

        public Color DescriptionColor
        {
            get => lblDescription.ForeColor;
            set => lblDescription.ForeColor = value;
        }

        public string DescriptionText
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }

        public int BorderSize { get; set; }

        public NewsCard()
        {
            InitializeComponent();
        }

        public void Build(Book book)
        {
            if (book is null)
                return;
            IsBook = true;
            pcbImage.Load(book.Image);
            lblDescription.Text = book.Description;
            lblTitle.Text = book.Name;
            RecordId = book.Id;
        }

        public void Build(Movie movie)
        {
            if (movie is null) 
                return;
            IsBook = false;
            pcbImage.Load(movie.Image);
            lblDescription.Text = movie.Description;
            lblTitle.Text = movie.Name;
            RecordId = movie.Id;
        }

        public void Build(string title, string description, string imageUrl)
        {
            pcbImage.Load(imageUrl);
            lblDescription.Text = description;
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
