using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformUI.Infrastructure.CustomControls;

namespace WinformUI.Infrastructure.Forms
{
    public partial class Test : Form
    {
        SearchDropDownForm searchDropDownForm;
        public Test()
        {
            InitializeComponent();
            searchDropDownForm = new SearchDropDownForm();
            searchDropDownForm.DesktopLocation = 
                new Point(this.DesktopLocation.X + label1.Location.X + 5, 
                          this.DesktopLocation.Y + label1.Location.Y + 5);
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //slider.Add(new BigCard { BorderSize = new Padding(3), BorderColor = Color.Gainsboro }) ;
            //slider.Add(new BigCard { BorderSize = new Padding(3), BorderColor = Color.Gainsboro }) ;
            //slider.Add(new BigCard { BorderSize = new Padding(3), BorderColor = Color.Gainsboro }) ;
            //slider.Add(new BigCard { BorderSize = new Padding(3), BorderColor = Color.Gainsboro }) ;

            //slider.Add(new BookSliderObject());
            //slider.Add(new BookSliderObject());
            //slider.Add(new BookSliderObject());
            //slider.Add(new BookSliderObject());
            //slider.Add(new BookSliderObject());

            //player.URL = @"https://imdb-video.media-imdb.com/vi3063858457/1434659607842-pgv4ql-1668123203322.mp4?Expires=1683196890&Signature=qUr7RKyrBzXarjIRNI1qUoW8KK5las2YZvn5olvT39AZrfX0Rk1sQ2tx66Koz8wv6K8mumO-LzyVDdOzYNRChA3F4GYopH73vAfNQH6XqDmbd1lUh9m2uiLo8fOismwiDMTbEEaMm5Z9tAP5B1kwzQPGwcprWwdiMgG1qpX-4w3Fiz-A8wTHMjDadxxJfDOpqNC0H2qSc2XszjiKwMC7r3msGO5vey3YhAZm1yBBWmv2XyOJAgLO7ViW7PQ4F8pVv~Jvqf-WOizd2qUX7YGZ~UBw4nExVrxh~iJ9kFJFB2ApZhyI~duzqDRld2u5FELfgDqkB~~BMXBtLl254djWnA__&Key-Pair-Id=APKAIFLZBVQZ24NQH3KA";

            //presenter.Add(new NewsCard());
            //presenter.Add(new NewsCard());
            //presenter.Add(new NewsCard());
            //presenter.Add(new NewsCard());
            //presenter.Add(new NewsCard());

            //specialSlider.Add(new NewsCard { TitleText = "Title1"});
            //specialSlider.Add(new NewsCard { TitleText = "Title2"});
            //specialSlider.Add(new NewsCard { TitleText = "Title3"});
            //specialSlider.Add(new NewsCard { TitleText = "Title4"});
            //specialSlider.Add(new NewsCard { TitleText = "Title5"});
            //specialSlider.Add(new NewsCard { TitleText = "Title6"});

            //specialSlider.Add(new BigCard { TitleText = "Title1" });
            //specialSlider.Add(new BigCard { TitleText = "Title2" });
            //specialSlider.Add(new BigCard { TitleText = "Title3" });
            //specialSlider.Add(new BigCard { TitleText = "Title4" });
            //specialSlider.Add(new BigCard { TitleText = "Title5" });
            //specialSlider.Add(new BigCard { TitleText = "Title6" });


            //btnComplex.Add(new ButtonItem { });
            //btnComplex.Add(new ButtonItem());
            //btnComplex.Add(new ButtonItem());
            //supriseMe1.SendToBack();

            //basicSlider1.Add(new BasicCard { TitleText = "Title1"});
            //basicSlider1.Add(new BasicCard { TitleText = "Title2"});
            //basicSlider1.Add(new BasicCard { TitleText = "Title3"});
            //basicSlider1.Add(new BasicCard { TitleText = "Title4"});
            //basicSlider1.Add(new BasicCard { TitleText = "Title5"});
            //basicSlider1.Add(new BasicCard { TitleText = "Title6"});
            //basicSlider1.Add(new BasicCard { TitleText = "Title7"});
            //basicSlider1.Add(new BasicCard { TitleText = "Title8"});

            //ratingControl1.RatingReport = "5.6\n1000";
            //reviewItem4.Build("User review review review review \n review \n \n review \n \n \n review", "Laman", "08.03.2023");
            //reviewItem5.Build("User review \n\n review", "Asim", "07.09.2023");
            //reviewItem6.Build("user review \n\n\n review \n\n review", "Laman", "22.07.2023");
            
            searchDropDownForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = searchDropDownForm.DesktopLocation.X + " " + searchDropDownForm.DesktopLocation.Y;
            label2.Text = this.DesktopLocation.X + " " + this.DesktopLocation.Y;
        }
    }
}
