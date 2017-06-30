using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Streamship_Screenshot_Tool.Presentation
{
    public partial class StreamshipEditor : Form
    {
        
        private Rectangle rect;
        
        
        public StreamshipEditor()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        public StreamshipEditor(Image Image)
        {
            InitializeComponent();
            editorImage.Image = Image;
            this.DoubleBuffered = true;
            this.Invalidate();
        }

        private void StreamshipEditor_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Clicked(object sender)
        {
            this.Dispose();
        }

        private void btnSave_Clicked(object sender)
        {
            (editorImage.Image as Bitmap).Save(System.IO.Path.Combine(Properties.Settings.Default.Destination,DateTime.Now.ToLongTimeString().Replace(':','1')+".bmp"));
        }

        private void btnSquare_Clicked(object sender)
        {
               
        }
        private void DrawRectangle()
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                Graphics g = editorImage.CreateGraphics();
                using (Pen p = new Pen(new SolidBrush(Properties.Settings.Default.InkColor), Properties.Settings.Default.PenWidth))
                {
                    if (rect.Equals(null))
                    {
                        rect = new Rectangle(Cursor.Position, new Size(0, 0));
                        g.DrawRectangle(p, rect);
                        this.Invalidate();
                        
                    }
                    else
                    {
                        rect = new Rectangle(rect.Location, new Size((rect.X - Cursor.Position.X), rect.Y - Cursor.Position.Y));
                        g.DrawRectangle(p, rect);
                        this.Invalidate();
                        
                    }
                }
            }
        }
    }
}
