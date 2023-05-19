using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class MultiSelector : UserControl
    {
        public string[] Items { get; set; }

        private SelectorForm _selectorForm;

        private List<int> _selectedIndexes;
        public List<int> SelectedIndexes
        {
            get 
            {
                if(_selectedIndexes is null)
                    _selectedIndexes = new List<int>();
                return _selectedIndexes; 
            }
            set
            {
                if(value is null)
                    value = new List<int>();
                _selectedIndexes = value;
            }
        }

        private object _data;
        [Browsable(false)]
        public object Data 
        { 
            get
            {
                if(_data is null)
                    _data = new object();

                return _data;
            }
            set
            {
                if(value is null)
                    value = new object();
                _data = value;
            }
        }

        public string ItemsText
        {
            get => lblSelectedItems.Text;
            set => lblSelectedItems.Text = value;
        }

        public Font ItemsFont
        {
            get => lblSelectedItems.Font;
            set => lblSelectedItems.Font = value;
        }

        public Color ItemsForeColor
        {
            get => lblSelectedItems.ForeColor;
            set => lblSelectedItems.ForeColor = value;
        }

        public int ItemsOpacity
        {
            get => lblSelectedItems.Opacity; 
            set => lblSelectedItems.Opacity = value;
        }

        public Color SearchButtonBackColor
        {
            get => btnSearch.BackColor;
            set => btnSearch.BackColor = value;
        }

        public Color SearchButtonIconColor
        {
            get => btnSearch.IconColor; 
            set => btnSearch.IconColor = value;
        }

        public MultiSelector()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            _selectorForm = new SelectorForm();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Parent != null && this.BackColor == Color.Transparent)
            {
                using (var bmp = new Bitmap(Parent.Width, Parent.Height))
                {
                    Parent.Controls.Cast<Control>()
                          .Where(c => Parent.Controls.GetChildIndex(c) > Parent.Controls.GetChildIndex(this))
                          .Where(c => c.Bounds.IntersectsWith(this.Bounds))
                          .OrderByDescending(c => Parent.Controls.GetChildIndex(c))
                          .ToList()
                          .ForEach(c => c.DrawToBitmap(bmp, c.Bounds));

                    e.Graphics.DrawImage(bmp, -Left, -Top);

                }
            }
            base.OnPaint(e);
        }

        private void MultiSelector_Load(object sender, System.EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            _selectorForm.SelectedItemIndexes = SelectedIndexes;
            _selectorForm.Build(Items);
            _selectorForm.ShowDialog();
            
            SelectedIndexes = _selectorForm.SelectedItemIndexes;

            SetSelectedItems();
        }

        public void SetSelectedItems()
        {
            if (lblSelectedItems is null)
                return;

            var selectedItems = new List<string>();

            for (int i = 0; i < Items.Length; i++)
            {
                if (SelectedIndexes.Contains(i))
                    selectedItems.Add(Items[i]);
            }

            if (selectedItems.Count > 0)
                lblSelectedItems.Text = string.Join(", ", selectedItems);
            else
                lblSelectedItems.Text = "No item selected";
        }
    }
}
