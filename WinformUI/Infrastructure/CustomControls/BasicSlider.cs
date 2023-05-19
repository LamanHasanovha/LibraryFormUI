using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class BasicSlider : UserControl
    {
        private FlowLayoutPanel _sliderArea;
        private List<BasicCard> _cards;

        public BasicSlider()
        {
            InitializeComponent();
            BuildArea();
            _cards = new List<BasicCard>();
        }

        private void BasicSlider_Load(object sender, EventArgs e)
        {

        }

        public void Add(BasicCard card)
        {
            if (!_cards.Any())
            {
                _sliderArea.Height = card.Height + 10;
                this.Height = card.Height + 70;
            }

            _cards.Add(card);
            _sliderArea.Controls.Add(card);

            RebuildArea();
        }

        private void BuildArea()
        {
            _sliderArea = new FlowLayoutPanel
            {
                Dock = DockStyle.None,
                Size = new Size(0, 0),
                WrapContents = false
            };
            panelMain.Controls.Add(_sliderArea);
            _sliderArea.Show();
        }

        private void RebuildArea()
        {
            int width = _cards.Count * (_cards[0].Width + 25);
            _sliderArea.Width = width;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (_sliderArea.Left < 0)
                if (_cards.Count > 0)
                    _sliderArea.Left += _cards[0].Width + 10;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (_sliderArea.Right >= panelMain.Left + panelMain.Width)
                if (_cards.Count > 0)
                    _sliderArea.Left -= _cards[0].Width + 10;
        }
    }
}
