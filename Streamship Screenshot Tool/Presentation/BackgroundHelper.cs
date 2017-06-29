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
        Point start, end;
        int leftCount = 0;
        Color _color;
        Rectangle _croppedArea = new Rectangle();

       
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
            
         }
        /// <summary>
        /// Constructor That Have Color of Rectangle to draw For Selection
        /// </summary>
        /// <param name="color">Color of Selection Area</param>
        public BackgroundHelper(Color color)
        {
            SetResolution();
            InitializeComponent();
            _color = color;
            Streamship_Screenshot_Tool.Business_Logic.ScreenShotFull screen = new Business_Logic.ScreenShotFull();
            this.BackgroundImage = screen.CaptureScreen() as Image;

        }
        /// <summary>
        /// A Helper in Selection of Area to be Capture
        /// </summary>
        /// <param name="e">Mouse Event Arguments</param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);


            if ((MouseButtons.Left == MouseButtons))
            {
                end = Cursor.Position;
                if (leftCount == 0)
                {
                    start = Cursor.Position;
                    _croppedArea.Location = start;
                    leftCount = 1;
                }

                else if (leftCount == 1)
                {

                    end = Cursor.Position;
                    _croppedArea.Width = end.X - start.X;
                    _croppedArea.Height = end.Y - start.Y;
                    if (_croppedArea.Height <= 0 || _croppedArea.Width <= 0)
                    {
                        leftCount = 1;
                    }
                    
                    ControlBox to = new Presentation.ControlBox();
                    Bitmap selectedImage = BackgroundImage as Bitmap;
                    try
                    {
                        to.selectedImage = (selectedImage).Clone(_croppedArea, selectedImage.PixelFormat);
                        to.selectedImage.Save(System.IO.Path.Combine(System.IO.Path.GetTempPath(),"StreamShip ScreenShot Tool","WASEEM.BMP"));
                        CropedImage = selectedImage;
                        leftCount = 2;
                        ///Open Editor
                        

                    }
                    catch
                    {
                        leftCount = 1;
                    }
                    
                    
                }


            }
           
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (leftCount > 0)
            {
                Graphics g = e.Graphics;
                {

                    Rectangle rect = new Rectangle(start, new Size(Cursor.Position.X - start.X, Cursor.Position.Y - start.Y));
                    Region re = new Region(Screen.PrimaryScreen.WorkingArea);
                    re.Exclude(rect);
                    SizeF StringSize = g.MeasureString(start.ToString(), this.Font);
                    PointF startString = new PointF(start.X - StringSize.Width, start.Y - StringSize.Height);
                    g.DrawString(start.ToString(), this.Font, new SolidBrush(_color), startString);
                    g.DrawString(Cursor.Position.ToString(), this.Font, new SolidBrush(_color), Cursor.Position);
                    g.DrawRectangle(new Pen(_color), rect);
                    
                }


            }
            this.Invalidate();
            this.DoubleBuffered = true;

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
