using System;
using System.ComponentModel;
using System.Windows.Forms;
using WinformUI.Properties;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class RatingControl : UserControl
    {
        [Browsable(false)]
        public Action<int> SetRating { get; set; }
        [Browsable(false)]
        public Func<string> ReloadRating { get; set; }

        public RatingControl()
        {
            InitializeComponent();
        }

        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                SetStar(value);
                _value = value;
            }
        }

        public string RatingReport
        {
            get => lblRatingReport.Text;
            set => lblRatingReport.Text = value;
        }

        private void pcbStar1_Click(object sender, EventArgs e)
        {
            SetStar(1);
            Value = 1;
            SetRating?.Invoke(Value);
            RatingReport = ReloadRating?.Invoke();
        }

        private void pcbStar2_Click(object sender, EventArgs e)
        {
            SetStar(2);
            Value = 2;
            SetRating?.Invoke(Value);
            RatingReport = ReloadRating?.Invoke();
        }

        private void pcbStar3_Click(object sender, EventArgs e)
        {
            SetStar(3);
            Value = 3;
            SetRating?.Invoke(Value);
            RatingReport = ReloadRating?.Invoke();
        }

        private void pcbStar4_Click(object sender, EventArgs e)
        {
            SetStar(4);
            Value = 4;
            SetRating?.Invoke(Value);
            RatingReport = ReloadRating?.Invoke();
        }

        private void pcbStar5_Click(object sender, EventArgs e)
        {
            SetStar(5);
            Value = 5;
            SetRating?.Invoke(Value);
            RatingReport = ReloadRating?.Invoke();
        }

        private void panelEmpty_Click(object sender, EventArgs e)
        {
            SetStar(0);
            Value = 0;
            SetRating?.Invoke(Value);
            RatingReport = ReloadRating?.Invoke();
        }

        private void SetStar(int count)
        {
            switch (count)
            {
                case 0:
                    pcbStar1.Image = Resources.emptyStar;
                    pcbStar2.Image = Resources.emptyStar;
                    pcbStar3.Image = Resources.emptyStar;
                    pcbStar4.Image = Resources.emptyStar;
                    pcbStar5.Image = Resources.emptyStar;
                    break;
                case 1:
                    pcbStar1.Image = Resources.star;
                    pcbStar2.Image = Resources.emptyStar;
                    pcbStar3.Image = Resources.emptyStar;
                    pcbStar4.Image = Resources.emptyStar;
                    pcbStar5.Image = Resources.emptyStar;
                    break;
                case 2:
                    pcbStar1.Image = Resources.star;
                    pcbStar2.Image = Resources.star;
                    pcbStar3.Image = Resources.emptyStar;
                    pcbStar4.Image = Resources.emptyStar;
                    pcbStar5.Image = Resources.emptyStar;
                    break;
                case 3:
                    pcbStar1.Image = Resources.star;
                    pcbStar2.Image = Resources.star;
                    pcbStar3.Image = Resources.star;
                    pcbStar4.Image = Resources.emptyStar;
                    pcbStar5.Image = Resources.emptyStar;
                    Value = 3;
                    break;
                case 4:
                    pcbStar1.Image = Resources.star;
                    pcbStar2.Image = Resources.star;
                    pcbStar3.Image = Resources.star;
                    pcbStar4.Image = Resources.star;
                    pcbStar5.Image = Resources.emptyStar;
                    break;
                case 5:
                    pcbStar1.Image = Resources.star;
                    pcbStar2.Image = Resources.star;
                    pcbStar3.Image = Resources.star;
                    pcbStar4.Image = Resources.star;
                    pcbStar5.Image = Resources.star;
                    break;
            }
        }
    }
}
