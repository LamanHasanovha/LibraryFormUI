using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class NewsPresenter : UserControl
    {
        private List<NewsCard> _newsCards;

        [Browsable(false)]
        public Action<object, EventArgs> ClickEvent { get; set; }

        public Image BackImage
        {
            get => pcbBackImage.Image;
            set => pcbBackImage.Image = value;
        }

        public int Opacity
        {
            get => lblShadowLayer.Opacity;
            set => lblShadowLayer.Opacity = value;
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

        public NewsPresenter()
        {
            InitializeComponent();
            _newsCards = new List<NewsCard>();
        }

        private void NewsPresenter_Load(object sender, EventArgs e)
        {

        }

        public void Add(NewsCard newsCard)
        {
            if (newsCard is null)
                return;

            if (_newsCards.Count == 4)
                return;

            newsCard.ClickEvent = ClickEvent;
            newsCard.BorderSize = 3;

            _newsCards.Add(newsCard);
            this.Controls.Add(newsCard);
            newsCard.BringToFront();

            RebuildPanel(newsCard.Width);
        }

        private void RebuildPanel(int width)
        {
            int upperBorderY = lblDescription.Location.Y + lblDescription.Height + 10;

            int totalWidth = (_newsCards.Count - 1) * 20 + (_newsCards.Count * width);

            int leftBorder = (this.Width / 2) - (totalWidth / 2);

            for (int i = 0; i < _newsCards.Count; i++, leftBorder += width + 20)
            {
                _newsCards[i].Location = new Point(leftBorder, upperBorderY);
            }
        }

        private void card_Resize(object sender, EventArgs e)
        {
            if(_newsCards.Count > 0) 
                RebuildPanel(_newsCards[0].Width);
        }
    }
}
