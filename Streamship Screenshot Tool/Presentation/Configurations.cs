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
    public partial class Configurations : Form
    {
        private string DefaultDestination;
        public Configurations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Configurations_Load(object sender, EventArgs e)
        {
            btnColor.BackColor = Properties.Settings.Default.InkColor;
            cBoxPromptSave.Checked = Properties.Settings.Default.PromptSave;
            cboxClipBoardSnap.Checked = Properties.Settings.Default.ClipboardCopy;
            DefaultDestination = Properties.Settings.Default.Destination;
            lblDestination.Text = DefaultDestination;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PromptSave = cBoxPromptSave.Checked;
            Properties.Settings.Default.ClipboardCopy = cboxClipBoardSnap.Checked;
            Properties.Settings.Default.Destination = DefaultDestination;
            Properties.Settings.Default.InkColor = btnColor.BackColor;
            Properties.Settings.Default.Save();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog1.Color;
            }
        }

        private void btnDestination_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton = true;
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DefaultDestination = folderBrowserDialog1.SelectedPath;
            }
        }
        
    }
}
