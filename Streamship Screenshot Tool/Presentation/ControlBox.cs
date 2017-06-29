using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streamship_Screenshot_Tool.Presentation
{
    public partial class ControlBox : Form
    {
        public Image selectedImage { get; set; }

        public ControlBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SelectArea_Clicked(object sender)
        {
            this.Hide();
            BackgroundHelper a = new BackgroundHelper()
            {
                Visible = true,

            };
        }

        private void FullScreenCapture_Clicked(object sender)
        {
            Streamship_Screenshot_Tool.Business_Logic.ScreenShotFull screen = new Business_Logic.ScreenShotFull();
            Bitmap fullImage = screen.CaptureScreen();

        }

        private void ControlBox_Load(object sender, EventArgs e)
        {

        }

        private void imageButton2_Clicked(object sender)
        {
            StreamshipScreenShotAbout aboutBox = new StreamshipScreenShotAbout();
            aboutBox.ShowDialog();
        }

        private void imageButton1_Clicked(object sender)
        {
            Configurations config = new Configurations();
            config.ShowDialog();
        }
    }
}
