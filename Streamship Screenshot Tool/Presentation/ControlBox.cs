using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
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
            BackgroundHelper a = new BackgroundHelper();


            a.ShowDialog();
            selectedImage = a.CropedImage;
            a.Dispose();
            if (Properties.Settings.Default.ClipboardCopy && selectedImage != null)
            {
                Clipboard.SetImage(selectedImage);
            }
            if (Properties.Settings.Default.OpenEditor)
            {
                StreamshipEditor editor = new StreamshipEditor(selectedImage);
                editor.ShowDialog();
            }
            else
            {
                
                (selectedImage as Bitmap).Save(System.IO.Path.Combine(Properties.Settings.Default.Destination, DateTime.Now.ToLongTimeString().Replace(':', '2')+".bmp"));
            }
            this.Show();
        }

        private void FullScreenCapture_Clicked(object sender)
        {
            this.Hide();
            Streamship_Screenshot_Tool.Business_Logic.ScreenShotFull screen = new Business_Logic.ScreenShotFull();
            selectedImage = screen.CaptureScreen();
            if (Properties.Settings.Default.ClipboardCopy && selectedImage != null)
            {
                Clipboard.SetImage(selectedImage);
            }
            if (Properties.Settings.Default.OpenEditor)
            {
                using (StreamshipEditor ed = new StreamshipEditor())
                {
                    ShowDialog();

                }
            }
            else
            {
                (selectedImage as Bitmap).Save(System.IO.Path.Combine(Properties.Settings.Default.Destination, DateTime.Now.ToLongTimeString().Replace(':', '3')+".bmp"));
            }
            this.Show();
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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (Properties.Settings.Default.Destination.Length > 0)
            {
                GrantAccess(Properties.Settings.Default.Destination);
                
                if(selectedImage != null)
                    selectedImage.Save(System.IO.Path.Combine(Properties.Settings.Default.Destination,DateTime.Now.ToShortTimeString()).Replace(':','9'),System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        private void GrantAccess(string fullPath)
        {
            DirectoryInfo dInfo = new DirectoryInfo(fullPath);
            DirectorySecurity dSecurity = dInfo.GetAccessControl();
            dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
