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
            this.Hide();
            BackgroundHelper a = new BackgroundHelper()
            {
                Visible = true,
                
            };
        }
    }
}
