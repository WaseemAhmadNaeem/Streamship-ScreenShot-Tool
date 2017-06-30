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
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnDestination = new System.Windows.Forms.Button();
            this.cBoxPromptSave = new System.Windows.Forms.CheckBox();
            this.cboxClipBoardSnap = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cBoxOpenEditor = new System.Windows.Forms.CheckBox();
            this.penWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxOpenEditor);
            this.groupBox1.Controls.Add(this.lblDestination);
            this.groupBox1.Controls.Add(this.btnDestination);
            this.groupBox1.Controls.Add(this.cBoxPromptSave);
            this.groupBox1.Controls.Add(this.cboxClipBoardSnap);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(6, 120);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(35, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "label1";
            // 
            // btnDestination
            // 
            this.btnDestination.ImageKey = "(none)";
            this.btnDestination.Location = new System.Drawing.Point(7, 94);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(112, 23);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "Dentination Folder";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.penWidth);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(173, 19);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(112, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Change Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
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
            // cBoxOpenEditor
            // 
            this.cBoxOpenEditor.AutoSize = true;
            this.cBoxOpenEditor.Location = new System.Drawing.Point(7, 68);
            this.cBoxOpenEditor.Name = "cBoxOpenEditor";
            this.cBoxOpenEditor.Size = new System.Drawing.Size(135, 17);
            this.cBoxOpenEditor.TabIndex = 5;
            this.cBoxOpenEditor.Text = "Open Editor After Snap";
            this.cBoxOpenEditor.UseVisualStyleBackColor = true;
            // 
            // penWidth
            // 
            this.penWidth.Location = new System.Drawing.Point(173, 48);
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(112, 20);
            this.penWidth.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pen Width:";
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
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).EndInit();
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.CheckBox cBoxOpenEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown penWidth;
    }
}