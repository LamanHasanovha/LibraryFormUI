using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class ButtonComplex : UserControl
    {
        private List<ButtonItem> _bookItems;
        private List<ButtonItem> _movieItems;

        private int _mode;
        private int Mode  // 1-book 2-movie
        {
            get => _mode;
            set
            {
                if(_mode == value) 
                    return;

                _mode = value;

                switch(_mode)
                {
                    case 1:
                        btnBook.BackColor = Color.FromArgb(68, 132, 188);
                        btnBook.IconColor = Color.Gainsboro;
                        btnBook.ForeColor = Color.Gainsboro;

                        btnMovie.BackColor = Color.FromKnownColor(KnownColor.Control);
                        btnMovie.IconColor = Color.FromArgb(68, 132, 188);
                        btnMovie.ForeColor = Color.FromArgb(68, 132, 188);
                        break;
                    case 2:
                        btnMovie.BackColor = Color.FromArgb(68, 132, 188);
                        btnMovie.IconColor = Color.Gainsboro;
                        btnMovie.ForeColor = Color.Gainsboro;

                        btnBook.BackColor = Color.FromKnownColor(KnownColor.Control);
                        btnBook.IconColor = Color.FromArgb(68, 132, 188);
                        btnBook.ForeColor = Color.FromArgb(68, 132, 188);
                        break;
                    default:
                        break;
                }
            }
        }
        
        [Browsable(false)] 
        public Action<object, EventArgs> ClickEventBook { get; set; }
        [Browsable(false)]
        public Action<object, EventArgs> ClickEventMovie { get; set; }

        public ButtonComplex()
        {
            InitializeComponent();
            _bookItems = new List<ButtonItem>();
            _movieItems = new List<ButtonItem>();
        }

        private void ButtonComplex_Load(object sender, EventArgs e)
        {
            Mode = 1;
        }

        public void AddToMovie(ButtonItem item)
        {
            if (item == null)
                return;

            item.Margin = new Padding(5);
            item.ClickEvent = ClickEventMovie;

            _movieItems.Add(item);
            panelMain.Controls.Add(item);
        }

        public void AddToBook(ButtonItem item)
        {
            if (item == null)
                return;

            item.Margin = new Padding(5);
            item.ClickEvent = ClickEventBook;

            _bookItems.Add(item);
            panelMain.Controls.Add(item);
        }


        private void btnBook_Click(object sender, EventArgs e)
        {
            Mode = 1;
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            Mode = 2;
        }
    }
}
