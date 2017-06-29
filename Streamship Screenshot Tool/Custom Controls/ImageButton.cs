using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Streamship_Screenshot_Tool.Custom_Controls
{
    public partial class ImageButton : UserControl
    {
        private Bitmap _image;
        public event EventHandler Clicked;
        public Bitmap Image
        {
            get { return _image; }
            set { _image = value;
                pictureBox1.Image = _image as Image;
            }
        }

        public ImageButton()
        {
            InitializeComponent();
            
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }
    }
}
