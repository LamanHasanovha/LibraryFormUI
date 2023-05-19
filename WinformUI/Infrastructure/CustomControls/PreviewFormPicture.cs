using System.Drawing;
using System.Windows.Forms;

namespace WinformUI.Infrastructure.CustomControls
{
    public partial class PreviewFormPicture : Form
    {
        public PreviewFormPicture()
        {
            InitializeComponent();
        }

        public void SetPicture(Image image)
        {
            pictureBox1.Image = image;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
