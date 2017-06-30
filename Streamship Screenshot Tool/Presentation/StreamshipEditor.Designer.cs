namespace Streamship_Screenshot_Tool.Presentation
{
    partial class StreamshipEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreamshipEditor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editorImage = new System.Windows.Forms.PictureBox();
            this.btnSave = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.btnCancel = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.btnBlur = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.btnPencil = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.btnSquare = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.btnCircle = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.btnLine = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.btnErasor = new Streamship_Screenshot_Tool.Custom_Controls.ImageButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editorImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnErasor);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnPencil);
            this.panel1.Controls.Add(this.btnBlur);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(675, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editorImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 405);
            this.panel2.TabIndex = 1;
            // 
            // editorImage
            // 
            this.editorImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorImage.Location = new System.Drawing.Point(0, 0);
            this.editorImage.Name = "editorImage";
            this.editorImage.Size = new System.Drawing.Size(675, 405);
            this.editorImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.editorImage.TabIndex = 0;
            this.editorImage.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSave.Location = new System.Drawing.Point(4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 48);
            this.btnSave.TabIndex = 0;
            this.btnSave.Clicked += new Streamship_Screenshot_Tool.Custom_Controls.ImageButton.ControlEventHandler(this.btnSave_Clicked);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCancel.Location = new System.Drawing.Point(619, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(53, 48);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Clicked += new Streamship_Screenshot_Tool.Custom_Controls.ImageButton.ControlEventHandler(this.btnCancel_Clicked);
            // 
            // btnBlur
            // 
            this.btnBlur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlur.BackgroundImage")));
            this.btnBlur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBlur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBlur.Location = new System.Drawing.Point(122, 4);
            this.btnBlur.Name = "btnBlur";
            this.btnBlur.Size = new System.Drawing.Size(53, 48);
            this.btnBlur.TabIndex = 2;
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPencil.BackgroundImage")));
            this.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPencil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnPencil.Location = new System.Drawing.Point(181, 4);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(53, 48);
            this.btnPencil.TabIndex = 3;
            // 
            // btnSquare
            // 
            this.btnSquare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSquare.BackgroundImage")));
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSquare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSquare.Location = new System.Drawing.Point(240, 4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(53, 48);
            this.btnSquare.TabIndex = 4;
            this.btnSquare.Clicked += new Streamship_Screenshot_Tool.Custom_Controls.ImageButton.ControlEventHandler(this.btnSquare_Clicked);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCircle.BackgroundImage")));
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCircle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCircle.Location = new System.Drawing.Point(299, 4);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(53, 48);
            this.btnCircle.TabIndex = 5;
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLine.BackgroundImage")));
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLine.Location = new System.Drawing.Point(358, 4);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(53, 48);
            this.btnLine.TabIndex = 6;
            // 
            // btnErasor
            // 
            this.btnErasor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnErasor.BackgroundImage")));
            this.btnErasor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnErasor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnErasor.Location = new System.Drawing.Point(63, 4);
            this.btnErasor.Name = "btnErasor";
            this.btnErasor.Size = new System.Drawing.Size(53, 48);
            this.btnErasor.TabIndex = 7;
            // 
            // StreamshipEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StreamshipEditor";
            this.Text = "Streamship Editor";
            this.Load += new System.EventHandler(this.StreamshipEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editorImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox editorImage;
        private Custom_Controls.ImageButton btnSave;
        private Custom_Controls.ImageButton btnBlur;
        private Custom_Controls.ImageButton btnCancel;
        private Custom_Controls.ImageButton btnCircle;
        private Custom_Controls.ImageButton btnSquare;
        private Custom_Controls.ImageButton btnPencil;
        private Custom_Controls.ImageButton btnLine;
        private Custom_Controls.ImageButton btnErasor;
    }
}