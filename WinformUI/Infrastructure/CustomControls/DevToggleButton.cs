using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Core.WinFormUI.CustomControls
{
    public class DevToggleButton : CheckBox
    {
        private Color _onBackColor = Color.MediumSlateBlue;
        private Color _onToggleColor = Color.WhiteSmoke;
        private Color _offBackColor = Color.Gray;
        private Color _offToggleColor = Color.Gainsboro;
        private bool _solidStyle = true;

        public Color OnBackColor
        {
            get => _onBackColor; set
            {
                _onBackColor = value;
                this.Invalidate();
            }
        }
        public Color OnToggleColor
        {
            get => _onToggleColor; set
            {
                _onToggleColor = value;
                this.Invalidate();
            }
        }
        public Color OffBackColor
        {
            get => _offBackColor; set
            {
                _offBackColor = value;
                this.Invalidate();
            }
        }
        public Color OffToggleColor
        {
            get => _offToggleColor; set
            {
                _offToggleColor = value;
                this.Invalidate();
            }
        }

        public override string Text { get => base.Text; set { } }

        [DefaultValue(true)]
        public bool SolidStyle
        {
            get => _solidStyle; set
            {
                _solidStyle = value;
                this.Invalidate();
            }
        }

        public DevToggleButton()
        {
            this.MinimumSize = new Size(45, 22);
        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rigthArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(leftArc, 90, 180);
                path.AddArc(rigthArc, 270, 180);
                path.CloseFigure();

                return path;
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //ON
            {
                //Draw the control surface
                if (_solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(_onBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(_onBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(_onToggleColor),
                  new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //OFF
            {
                //Draw the control surface
                if (_solidStyle)
                    pevent.Graphics.FillPath(new SolidBrush(_offBackColor), GetFigurePath());
                else pevent.Graphics.DrawPath(new Pen(_offBackColor, 2), GetFigurePath());
                //Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(_offToggleColor),
                  new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }
    }
}
