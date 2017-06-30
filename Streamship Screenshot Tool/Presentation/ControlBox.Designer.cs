namespace Streamship_Screenshot_Tool.Presentation
{
    partial class ControlBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlBox));
            this.SelectArea = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.lblSelectArea = new System.Windows.Forms.Label();
            this.FullScreenCapture = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.imageButton1 = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.imageButton2 = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectArea
            // 
            this.SelectArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectArea.BackgroundImage")));
            this.SelectArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectArea.Location = new System.Drawing.Point(12, 32);
            this.SelectArea.Name = "SelectArea";
            this.SelectArea.Size = new System.Drawing.Size(75, 67);
            this.SelectArea.TabIndex = 0;
            this.SelectArea.Clicked += new Streamship_Screenshot_Tool.Custom_Controls.ImageButton.ControlEventHandler(this.SelectArea_Clicked);
            // 
            // lblSelectArea
            // 
            this.lblSelectArea.AutoSize = true;
            this.lblSelectArea.Location = new System.Drawing.Point(15, 102);
            this.lblSelectArea.Name = "lblSelectArea";
            this.lblSelectArea.Size = new System.Drawing.Size(62, 13);
            this.lblSelectArea.TabIndex = 1;
            this.lblSelectArea.Text = "Select Area";
            // 
            // FullScreenCapture
            // 
            this.FullScreenCapture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullScreenCapture.BackgroundImage")));
            this.FullScreenCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FullScreenCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullScreenCapture.Location = new System.Drawing.Point(109, 32);
            this.FullScreenCapture.Name = "FullScreenCapture";
            this.FullScreenCapture.Size = new System.Drawing.Size(75, 67);
            this.FullScreenCapture.TabIndex = 2;
            this.FullScreenCapture.Clicked += new Streamship_Screenshot_Tool.Custom_Controls.ImageButton.ControlEventHandler(this.FullScreenCapture_Clicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Full Screen";
            // 
            // imageButton1
            // 
            this.imageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageButton1.BackgroundImage")));
            this.imageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageButton1.Location = new System.Drawing.Point(212, 32);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(75, 67);
            this.imageButton1.TabIndex = 4;
            this.imageButton1.Clicked += new Streamship_Screenshot_Tool.Custom_Controls.ImageButton.ControlEventHandler(this.imageButton1_Clicked);
            // 
            // imageButton2
            // 
            this.imageButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imageButton2.BackgroundImage")));
            this.imageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageButton2.Location = new System.Drawing.Point(311, 32);
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(75, 67);
            this.imageButton2.TabIndex = 5;
            this.imageButton2.Clicked += new Streamship_Screenshot_Tool.Custom_Controls.ImageButton.ControlEventHandler(this.imageButton2_Clicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Configurations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "About";
            // 
            // ControlBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 134);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imageButton2);
            this.Controls.Add(this.imageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullScreenCapture);
            this.Controls.Add(this.lblSelectArea);
            this.Controls.Add(this.SelectArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlBox";
            this.Text = "Streamship Screenshot Tool";
            this.Load += new System.EventHandler(this.ControlBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Controls.ImageButton SelectArea;
        private System.Windows.Forms.Label lblSelectArea;
        private Custom_Controls.ImageButton FullScreenCapture;
        private System.Windows.Forms.Label label1;
        private Custom_Controls.ImageButton imageButton1;
        private Custom_Controls.ImageButton imageButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}