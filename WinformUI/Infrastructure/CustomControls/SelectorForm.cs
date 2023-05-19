using Core.WinFormUI.Design.DropShadowing;
using Core.WinFormUI.Design.MessageBox;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinformUI.Infrastructure.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class SelectorForm : BaseForm
    {
        [Browsable(false)]
        public List<int> SelectedItemIndexes { get; set; }
        private string[] Items { get; set; }

        public SelectorForm()
        {
            InitializeComponent();
            SelectedItemIndexes = new List<int>();
        }

        private void SelectorForm_Load(object sender, EventArgs e)
        {
            new DropShadow().ApplyShadows(this);
        }

        private void SelectorForm_Paint(object sender, PaintEventArgs e)
        {
            MultiColorGradient(sender, e, Color.FromArgb(41, 128, 185), Color.FromArgb(109, 213, 250), Color.FromArgb(255, 255, 255));
        }

        private void SelectorForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var result = DevMsgBox.Show("Are you sure want to quit?", "System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        public void Build(params string[] contents)
        {
            panelContents.Controls.Clear();

            Items = contents;
            int lblX = 100, lblY = 10, btnX = 40, btnY = 10;

            for (int i = 0; i < contents.Length; i++)
            {
                var btn = CreateButton(contents[i]);
                var lbl = CreateLabel(contents[i]);

                if (SelectedItemIndexes.Any())
                {
                    if (SelectedItemIndexes.Contains(i))
                    {
                        btn.BackColor = Color.Green;
                        btn.IconChar = IconChar.CheckCircle;
                    }
                }

                btn.Location = new Point(btnX, btnY);
                lbl.Location = new Point(lblX, lblY);

                panelContents.Controls.Add(btn);
                panelContents.Controls.Add(lbl);

                btnY += btn.Height + 10;
                lblY += btn.Height + 10;
            }
        }

        private TransparentLabelNew CreateLabel(string text)
        {
            var lbl = new TransparentLabelNew();

            lbl.Text = text;
            lbl.Font = new Font("Comic Sans MS", 15, FontStyle.Regular, GraphicsUnit.Point, 0, false);
            lbl.ForeColor = Color.Gainsboro;
            lbl.AutoSize = true;

            return lbl;
        }

        private IconButton CreateButton(string name)
        {
            var btn = new IconButton();

            btn.BackColor = Color.DarkRed;
            btn.IconColor = Color.Gainsboro;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Cursor = Cursors.Hand;
            btn.IconChar = IconChar.Ban;
            btn.IconSize = 25;
            btn.Click += btn_Click;
            btn.Tag = name;
            btn.Size = new Size(35, 35);
            btn.Text = "";

            return btn;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var btn = (IconButton)sender;
            if (btn.BackColor == Color.DarkRed)
            {
                btn.BackColor = Color.Green;
                btn.IconChar = IconChar.CheckCircle;
                SetValue(1, btn.Tag.ToString());
            }
            else
            {
                btn.BackColor = Color.DarkRed;
                btn.IconChar = IconChar.Ban;
                SetValue(0, btn.Tag.ToString());
            }
        }

        private void SetValue(int value, string name)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (name == Items[i])
                {
                    switch (value)
                    {
                        case 0:
                            SelectedItemIndexes.Remove(i);
                            break;
                        case 1:
                            SelectedItemIndexes.Add(i);
                            break;
                        default:
                            break;
                    }
                    break;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
