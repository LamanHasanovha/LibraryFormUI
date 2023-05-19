using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class Slider : UserControl
    {

        private SliderType _sliderType = SliderType.Book;

        public SliderType Type
        {
            get { return _sliderType; }
            set { _sliderType = value; }
        }

        private ObjectTypes _objectType = ObjectTypes.Details;

        public ObjectTypes LayoutType
        {
            get { return _objectType; }
            set { _objectType = value; }
        }

        private List<BookSliderObject> _bookObjects;
        private List<MovieSliderObject> _movieObjects;
        private List<BigCard> _bigCards;
        private FlowLayoutPanel _sliderArea;

        [Browsable(false)]
        public Action<object, EventArgs> AddFavourites { get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> AddWishlist{ get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> AddCart { get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> BookClickEvent { get; set; }
        [Browsable (false)]
        public Action<object, EventArgs> MovieClickEvent { get; set; }

        public string TitleText
        {
            get => lblTitle.Text;
            set
            {
                this.lblTitle.Text = value;
            }
        }

        public Color TitleForeColor
        {
            get => lblTitle.ForeColor;
            set { lblTitle.ForeColor = value; }
        }

        public Font TitleFont
        {
            get => lblTitle.Font;
            set => lblTitle.Font = value;
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

        public Slider()
        {
            InitializeComponent();
            BuildArea();
            _bookObjects = new List<BookSliderObject>();
            _movieObjects = new List<MovieSliderObject>();
            _bigCards = new List<BigCard>();
        }

        private void Slider_Load(object sender, EventArgs e)
        {

        }

        public void Add(BookSliderObject obj)
        {
            if (Type == SliderType.Movie)
                return;

            if (!_bookObjects.Any())
            {
                _sliderArea.Height = obj.Height + 10;
            }
            obj.AddCart = AddCart;
            obj.AddFavourites = AddFavourites;
            obj.AddWishlist = AddWishlist;
            obj.ClickEvent = BookClickEvent;
            _bookObjects.Add(obj);
            _sliderArea.Controls.Add(obj);
            RebuildAreaForDetailsLayout();
        }

        public void Add(MovieSliderObject obj)
        {
            if (Type == SliderType.Book)
                return;
            if (!_bookObjects.Any())
            {
                _sliderArea.Height = obj.Height + 10;
            }
            obj.AddCart = AddCart;
            obj.AddFavourites = AddFavourites;
            obj.AddWishlist = AddWishlist;
            obj.ClickEvent = MovieClickEvent;
            _movieObjects.Add(obj);
            _sliderArea.Controls.Add(obj);
            RebuildAreaForDetailsLayout();
        }

        public void Add(BigCard card)
        {
            if(LayoutType == ObjectTypes.Details) 
                return;

            if(!_bigCards.Any())
                _sliderArea.Height= card.Height + 10;
            switch (Type)
            {
                case SliderType.Book:
                    card.ClickEvent = BookClickEvent;
                    break;
                case SliderType.Movie:
                    card.ClickEvent = MovieClickEvent;
                    break;
                default:
                    break;
            }
            _bigCards.Add(card);
            _sliderArea.Controls.Add(card);
            RebuildAreaForBigCardLayout();
        }

        private void BuildArea()
        {
            _sliderArea = new FlowLayoutPanel
            {
                Dock = DockStyle.None,
                Size = new Size(0, 0),
            };
            panelMain.Controls.Add(_sliderArea);
            _sliderArea.Show();
        }

        private void RebuildAreaForDetailsLayout()
        {
            int width = Type == SliderType.Book 
                        ? _bookObjects.Count * (_bookObjects[0].Width + 10)
                        : _movieObjects.Count * (_movieObjects[0].Width + 10);
            _sliderArea.Width = width;
        }

        private void RebuildAreaForBigCardLayout()
        {
            _sliderArea.Width = _bigCards.Count * (_bigCards[0].Width + 10);
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            timerRight.Start();
        }

        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            timerRight.Stop();
            timerRight.Dispose();
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            timerLeft.Start();
        }

        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            timerLeft.Stop();
            timerLeft.Dispose();
        }

        private void timerLeft_Tick(object sender, EventArgs e)
        {
            if (_sliderArea.Left < 0)
                _sliderArea.Left += 5;
        }

        private void timerRight_Tick(object sender, EventArgs e)
        {
            if(_sliderArea.Right >= panelMain.Left + panelMain.Width)
            {
                _sliderArea.Left -= 5;
            }
        }       
    }

    public enum SliderType
    {
        Book = 1,
        Movie = 2
    }

    public enum ObjectTypes
    {
        Details = 1,
        BigCards = 2
    }
}
