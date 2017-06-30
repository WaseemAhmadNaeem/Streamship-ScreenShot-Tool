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
    public partial class StreamshipEditor : Form
    {

        public StreamshipEditor()
        {
            InitializeComponent();
        }
        public StreamshipEditor(Image Image)
        {
            InitializeComponent();
            editorImage.Image = Image;
            this.Invalidate();
        }

        private void StreamshipEditor_Load(object sender, EventArgs e)
        {

        }
    }
}
