using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace Streamship_Screenshot_Tool.Presentation
{
    public partial class BackgroundHelper : Form
    {

        /// <summary>
        /// Delegates
        /// </summary>
        public Bitmap CropedImage { get; set; }

        //Fields
        
        int leftCount = 0;
        Color _color;
        Rectangle _croppedArea;

       
        /// <summary>
        /// Simple no Argument Constructor
        /// </summary>
        public BackgroundHelper()
        {

            SetResolution();
            InitializeComponent();
            _color = Properties.Settings.Default.InkColor;
            Streamship_Screenshot_Tool.Business_Logic.ScreenShotFull screen = new Business_Logic.ScreenShotFull();
            this.BackgroundImage = screen.CaptureScreen() as Image;
            this.DoubleBuffered = true;
            
         }
 
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if(e.Button == MouseButtons.Left && leftCount.Equals(0) && _croppedArea != null)
            {
                _croppedArea = new Rectangle(e.Location, new Size(0, 0));
                leftCount++;
            }else if (leftCount.Equals(1))
            {
                leftCount++;
            }
            if(leftCount == 2)
            {
                CropedImage = (BackgroundImage as Bitmap).Clone(_croppedArea,(BackgroundImage as Bitmap).PixelFormat);
                this.Close();
            }
        }
        /// <summary>
        /// A Helper in Selection of Area to be Capture
        /// </summary>
        /// <param name="e">Mouse Event Arguments</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (leftCount < 2)
            {
                _croppedArea = new Rectangle(_croppedArea.Location, new Size(e.X - _croppedArea.X, e.Y - _croppedArea.Y));
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           
            Pen pen = new Pen(new SolidBrush(Properties.Settings.Default.InkColor), Properties.Settings.Default.PenWidth);
            Graphics g = e.Graphics;
            if (leftCount > 0)
            {
                SizeF StringLength = g.MeasureString(_croppedArea.Location.ToString(), this.Font);
                g.DrawRectangle(pen, _croppedArea);
                g.DrawString(_croppedArea.Location.ToString(),this.Font,new SolidBrush(Properties.Settings.Default.InkColor),new Point((int)(_croppedArea.X-StringLength.Width),(int)(_croppedArea.Y-StringLength.Height)));
                g.DrawString(Control.MousePosition.ToString(), this.Font, new SolidBrush(Properties.Settings.Default.InkColor),Control.MousePosition);
            }
            this.Invalidate();
                
            

        }
        /// <summary>
        /// Set Form Size equals to sreen resolution.
        /// </summary>
        private void SetResolution()
        {
            Rectangle res = Screen.PrimaryScreen.Bounds;
            this.Width = res.Width;
            this.Height = res.Height;
        }

    }
}
