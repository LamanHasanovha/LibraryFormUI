using Core.WinFormUI.Design.MessageBox;
using Entities.Concrete;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.Forms
{
    public partial class BaseForm : Form
    {
        protected Form _activeForm;

        public int RecordId { get; set; }
        public Account Account { get; set; }

        #region Dll import

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        protected static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        protected static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        protected static extern void SendMessage(IntPtr hWnd, int wMessage, int wParam, int lParam);

        #endregion

        public BaseForm()
        {
            InitializeComponent();
        }

        protected void OpenChildForm(Form childForm, Panel panelContainer)
        {
            _activeForm?.Close();
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        protected virtual void DesignDataGridView(DataGridView dgwBase)
        {
            dgwBase.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgwBase.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter };
            dgwBase.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgwBase.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwBase.BackgroundColor = Color.FromArgb(32, 30, 45);
            dgwBase.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = SystemColors.Control,
                ForeColor = SystemColors.WindowText,
                //SelectionBackColor = Color.FromArgb(31, 30, 68),
                SelectionBackColor = Color.FromArgb(23, 21, 32),
                SelectionForeColor = SystemColors.HighlightText,
                Font = new Font("Microsoft", 12, FontStyle.Regular, GraphicsUnit.Pixel, 204, false),
                WrapMode = DataGridViewTriState.True,
                Alignment = DataGridViewContentAlignment.MiddleCenter,
                Padding = new Padding(10)
            };
            dgwBase.RowTemplate = new DataGridViewRow
            {
                DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.FromArgb(23, 21, 32), ForeColor = Color.White },
                Height = 40,
                ReadOnly = true,
            };
            dgwBase.AllowUserToResizeColumns = false;
            dgwBase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwBase.ReadOnly = true;
            dgwBase.Location = new Point(30, 30);
            dgwBase.Margin = new Padding(3, 3, 3, 3);
            dgwBase.MinimumSize = new Size(100, 100);
            dgwBase.RowHeadersWidth = 51;
            //dgwBase.Size = new Size(483, 453);
            dgwBase.ScrollBars = ScrollBars.Both;

            this.DesignDataGrid(dgwBase);
        }

        private void DesignDataGrid(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 30, 45);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(23, 21, 32);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Gainsboro;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(23, 21, 32);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gainsboro;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected void SortColumnsOfDgw(DataGridView dgw, params string[] columnNames)
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                dgw.Columns[columnNames[i]].DisplayIndex = i;
            }
        }

        protected void HideColumnsOfDgw(DataGridView dgw, params string[] columnNames)
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                dgw.Columns[columnNames[i]].Visible = false;
            }

        }

        protected void RenameColumnsOfDgw(DataGridView dgw, params string[] columnNames)
        {
            for (int i = 0; i < dgw.Columns.Count; i++)
            {
                //dgw.Columns[i].HeaderCell.Value = columnNames[i];
                dgw.Columns[i].HeaderText = columnNames[i];
            }
        }

        public bool HandleException(Action action)
        {
            bool result = true;
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                result = false;
                DevMsgBox.Show(exception.Message, "System");
            }

            return result;
        }

        public bool HandleWithCatch(Action forTry, Action forCatch)
        {
            bool result = true;
            try
            {
                forTry.Invoke();
            }
            catch (Exception exception)
            {
                result = false;
                DevMsgBox.Show(exception.Message, "System");
                forCatch.Invoke();
            }

            return result;
        }

        protected void MultiColorGradient(object sender, PaintEventArgs e, params Color[] colors)
        {
            using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.Red, Color.Yellow, 45))
            {
                ColorBlend cblend = new ColorBlend(colors.Length)
                {
                    Colors = colors,
                    Positions = CreateGradientPositions(colors.Length)
                };
                linearGradientBrush.InterpolationColors = cblend;

                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            }
        }

        private float[] CreateGradientPositions(int n)
        {
            var positions = new float[n];

            for (int i = 1; i < positions.Length; i++)
            {
                positions[i] = positions[i - 1] + ((float)1 / (n - 1));
            }

            return positions;
        }

        protected void GradientColor(object sender, PaintEventArgs e, Color color1, Color color2)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        protected struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        protected TTarget Map<TCurrent, TTarget>(TCurrent source)
        {
            var data = Activator.CreateInstance<TTarget>();

            var targetProperties = source.GetType().GetProperties();
            var destinationProperties = data.GetType().GetProperties();

            foreach (var dp in destinationProperties)
            {
                var val = targetProperties.FirstOrDefault(p => p.Name == dp.Name)?.GetValue(source);
                dp.SetValue(data, val);
            }

            return data;
        }

        protected byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        protected Image ByteArrayToImage(byte[] bytesIn)
        {
            using(var ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }
    }
}
