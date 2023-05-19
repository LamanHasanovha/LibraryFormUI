using FontAwesome.Sharp;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class ButtonItem : UserControl
    {
        [Browsable(false)]
        public Action<object, EventArgs> ClickEvent { get; set; }

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

        public IconChar Icon
        {
            get => btnIcon.IconChar;
            set => btnIcon.IconChar = value;
        }

        public Color IconColor
        {
            get => btnIcon.IconColor;
            set => btnIcon.IconColor = value;
        }

        public ButtonItem()
        {
            InitializeComponent();
        }

        private void ButtonItem_Load(object sender, EventArgs e)
        {

        }

        private void Item_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
        }
    }
}
