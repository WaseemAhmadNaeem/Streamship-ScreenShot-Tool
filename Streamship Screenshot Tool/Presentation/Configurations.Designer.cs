namespace Streamship_Screenshot_Tool.Presentation
{
    partial class Configurations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboxClipBoardSnap = new System.Windows.Forms.CheckBox();
            this.cBoxPromptSave = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDestination);
            this.groupBox1.Controls.Add(this.cBoxPromptSave);
            this.groupBox1.Controls.Add(this.cboxClipBoardSnap);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // cboxClipBoardSnap
            // 
            this.cboxClipBoardSnap.AutoSize = true;
            this.cboxClipBoardSnap.Location = new System.Drawing.Point(7, 20);
            this.cboxClipBoardSnap.Name = "cboxClipBoardSnap";
            this.cboxClipBoardSnap.Size = new System.Drawing.Size(170, 17);
            this.cboxClipBoardSnap.TabIndex = 0;
            this.cboxClipBoardSnap.Text = "Always copy snips to clipboard";
            this.cboxClipBoardSnap.UseVisualStyleBackColor = true;
            // 
            // cBoxPromptSave
            // 
            this.cBoxPromptSave.AutoSize = true;
            this.cBoxPromptSave.Location = new System.Drawing.Point(7, 44);
            this.cBoxPromptSave.Name = "cBoxPromptSave";
            this.cBoxPromptSave.Size = new System.Drawing.Size(163, 17);
            this.cBoxPromptSave.TabIndex = 1;
            this.cBoxPromptSave.Text = "Prompt to save before exiting";
            this.cBoxPromptSave.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(144, 268);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.ImageKey = "(none)";
            this.btnDestination.Location = new System.Drawing.Point(7, 67);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(112, 23);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "Dentination Folder";
            this.btnDestination.UseVisualStyleBackColor = true;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(6, 19);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(112, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Change Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 296);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configurations";
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.Configurations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBoxPromptSave;
        private System.Windows.Forms.CheckBox cboxClipBoardSnap;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}