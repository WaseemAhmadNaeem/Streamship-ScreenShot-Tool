using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Streamship_Screenshot_Tool.Presentation
{
    public partial class BackgroundHelper : Form
    {

        /// <summary>
        /// Delegates
        /// </summary>
        

        //Fields
        Point start, end;
        int leftCount = 0;
        Color _color;
        Rectangle _croppedArea = new Rectangle();

        /// <summary>
        /// P/Invokes
        /// </summary>
        
        [DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSource, int xSrc, int ySrc, CopyPixelOperation rop);
        [DllImport("user32.dll")]
        static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);
        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteDC(IntPtr hDc);
        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteObject(IntPtr hDc);
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateCompatibleDC(IntPtr hdc);
        [DllImport("gdi32.dll")]
        static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr ptr);
        /// <summary>
        /// Simple no Argument Constructor
        /// </summary>
        public BackgroundHelper()
        {
            SetResolution();
            InitializeComponent();
            _color = Color.Black;
            Size sz = Screen.PrimaryScreen.Bounds.Size;
            IntPtr hDesk = GetDesktopWindow();
            IntPtr hSrce = GetWindowDC(hDesk);
            IntPtr hDest = CreateCompatibleDC(hSrce);
            IntPtr hBmp = CreateCompatibleBitmap(hSrce, sz.Width, sz.Height);
            IntPtr hOldBmp = SelectObject(hDest, hBmp);
            bool b = BitBlt(hDest, 0, 0, sz.Width, sz.Height, hSrce, 0, 0, CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt);
            Bitmap bmp = Bitmap.FromHbitmap(hBmp);
            SelectObject(hDest, hOldBmp);
            DeleteObject(hBmp);
            DeleteDC(hDest);
            ReleaseDC(hDesk, hSrce);
            this.BackgroundImage = bmp as Image;
            
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
            Size sz = Screen.PrimaryScreen.Bounds.Size;
            IntPtr hDesk = GetDesktopWindow();
            IntPtr hSrce = GetWindowDC(hDesk);
            IntPtr hDest = CreateCompatibleDC(hSrce);
            IntPtr hBmp = CreateCompatibleBitmap(hSrce, sz.Width, sz.Height);
            IntPtr hOldBmp = SelectObject(hDest, hBmp);
            bool b = BitBlt(hDest, 0, 0, sz.Width, sz.Height, hSrce, 0, 0, CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt);
            Bitmap bmp = Bitmap.FromHbitmap(hBmp);
            SelectObject(hDest, hOldBmp);
            DeleteObject(hBmp);
            DeleteDC(hDest);
            ReleaseDC(hDesk, hSrce);
            this.BackgroundImage = bmp as Image;
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
                        leftCount = 2;
                        ///Open Editor
                        this.Hide();

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
