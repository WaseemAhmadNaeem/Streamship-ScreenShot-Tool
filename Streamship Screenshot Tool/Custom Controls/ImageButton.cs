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
    [DefaultEvent("Clicked")]
    public partial class ImageButton : UserControl
    {
        
        public delegate void ControlEventHandler(object sender);
        public event ControlEventHandler Clicked;
        public event ControlEventHandler ImageChanged;
        public event ControlEventHandler ButtonPused;
        public event ControlEventHandler ButtonReleased;
        /// <summary>
        /// Image to Show on Button
        /// </summary>
        
        protected override void OnBackgroundImageChanged(EventArgs e)
        {
            base.OnBackgroundImageChanged(e);
            
            this.Invalidate();
        }
        /// <summary>
        /// No Argument contructor
        /// </summary>
        public ImageButton()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            
        }
        /// <summary>
        /// Tells what to do when this button is clicked
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Clicked?.Invoke(this);
        }
        /// <summary>
        /// Change border of button when clicked so user can visulize that button is pressed
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.BorderStyle = BorderStyle.Fixed3D;
            ButtonPused?.Invoke(this);
        }
        /// <summary>
        /// when use release button the button should regain its orginial shape
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.BorderStyle = BorderStyle.FixedSingle;
            ButtonReleased?.Invoke(this);
        }

    }
}
