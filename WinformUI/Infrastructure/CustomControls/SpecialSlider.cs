using Entities.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class SpecialSlider : UserControl
    {
        private SpecialSliderTypes _sliderType = SpecialSliderTypes.NewsCard;

        public SpecialSliderTypes Type
        {
            get { return _sliderType; }
            set { _sliderType = value; }
        }

        public PersonTypes PersonType { get; set; }

        private List<BigCard> _bigCards;
        private List<NewsCard> _newsCards;
        private FlowLayoutPanel _sliderArea;

        [Browsable(false)]
        public Action<object, EventArgs> BookClickEvent { get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> MovieClickEvent { get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> SeeAllClickEvent { get; set; }

        private string _imageUrl;

        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                try
                {
                    pcbImage.Load(value);
                } 
                catch 
                {
                    pcbImage.Image = Properties.Resources.man;
                }
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

        public Color DescriptionForeColor
        {
            get => lblDescription.ForeColor;
            set { lblDescription.ForeColor = value; }
        }

        public Font DescriptionFont
        {
            get => lblDescription.Font;
            set => lblDescription.Font = value;
        }

        public Color ButtonColor
        {
            get => btnLeft.BackColor;
            set
            {
                btnLeft.BackColor = value;
                btnRight.BackColor = value;
            }
        }

        public Color ButtonIconColor
        {
            get => btnLeft.IconColor;
            set
            {
                btnLeft.IconColor = value;
                btnRight.IconColor = value;
            }
        }

        public Color ShowButtonColor
        {
            get => btnShowAll.BackColor;
            set => btnShowAll.BackColor = value;
        }

        public Color ShowButtonIconColor
        {
            get => btnShowAll.IconColor;
            set => btnShowAll.IconColor = value;
        }

        public Color ShowButtonForeColor
        {
            get => btnShowAll.ForeColor;
            set => btnShowAll.ForeColor = value;
        }
        public int RecordId { get; set; }
        public SpecialSlider()
        {
            InitializeComponent();
            BuildArea();
            _bigCards = new List<BigCard>();
            _newsCards = new List<NewsCard>();
        }

        private void SpecialSlider_Load(object sender, EventArgs e)
        {

        }

        private void BuildArea()
        {
            _sliderArea = new FlowLayoutPanel
            {
                Dock = DockStyle.None,
                Size = new Size(0, 0),
            };
            panelSlider.Controls.Add(_sliderArea);
            _sliderArea.Show();
        }

        public void Add(BigCard card)
        {
            if (Type == SpecialSliderTypes.NewsCard)
                return;

            if (!_bigCards.Any())
                _sliderArea.Height = card.Height + 10;
            if (card.IsBook)
                card.ClickEvent = BookClickEvent;
            else 
                card.ClickEvent = MovieClickEvent;
            _bigCards.Add(card);
            _sliderArea.Controls.Add(card);
            RebuildAreaForBigCardLayout();
        }

        public void Add(NewsCard card)
        {
            if(Type == SpecialSliderTypes.BigCard)
                return;

            if (!_newsCards.Any())
                _sliderArea.Height = card.Height + 10;
            if(card.IsBook)
                card.ClickEvent = BookClickEvent;
            else
                card.ClickEvent = MovieClickEvent;
            _newsCards.Add(card);
            _sliderArea.Controls.Add(card);
            RebuildAreaForNewsCardLayout();
        }

        private void RebuildAreaForBigCardLayout()
        {
            int width = _bigCards.Count * (_bigCards[0].Width + 10);
            _sliderArea.Width = width;
        }

        private void RebuildAreaForNewsCardLayout()
        {
            int width = _newsCards.Count * (_newsCards[0].Width + 10);
            _sliderArea.Width = width;
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            //timerRight.Start();
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            //timerRight.Stop();
            //timerRight.Dispose();
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            //timerLeft.Start();
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            //timerLeft.Stop();
            //timerLeft.Dispose();
        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            if (_sliderArea.Left < 0)
                _sliderArea.Left += 5;
        }

        private void timerRight_Tick(object sender, EventArgs e)
        {
            if(_sliderArea.Right >= panelSlider.Left + panelSlider.Width)
                _sliderArea.Left -= 5;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (_sliderArea.Left < 0)
            {
                if (Type == SpecialSliderTypes.NewsCard & _newsCards.Count > 0)
                    _sliderArea.Left += _newsCards[0].Width + 10;
                else if(Type == SpecialSliderTypes.BigCard & _bigCards.Count > 0)
                    _sliderArea.Left += _bigCards[0].Width + 10;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (_sliderArea.Right >= panelSlider.Left + panelSlider.Width)
                if (Type == SpecialSliderTypes.NewsCard & _newsCards.Count > 0)
                    _sliderArea.Left -= _newsCards[0].Width + 10;
                else if (Type == SpecialSliderTypes.BigCard & _bigCards.Count > 0)
                    _sliderArea.Left -= _bigCards[0].Width + 10;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            SeeAllClickEvent?.Invoke(this, e);
        }
    }

    public enum SpecialSliderTypes
    {
        NewsCard = 1,
        BigCard = 2
    }

    public enum PersonTypes
    {
        Actor = 1,
        Author = 2,
        Director = 3,
        None = 4
    }
}
