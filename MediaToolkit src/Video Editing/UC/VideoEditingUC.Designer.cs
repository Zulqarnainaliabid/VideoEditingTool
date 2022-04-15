
namespace Video_Editing.UC
{
    partial class VideoEditingUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseInputFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImageFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseImageFile = new System.Windows.Forms.Button();
            this.txtAllFramesInfo = new System.Windows.Forms.TextBox();
            this.btnAddFrame = new System.Windows.Forms.Button();
            this.numStartHH = new System.Windows.Forms.NumericUpDown();
            this.numStartMM = new System.Windows.Forms.NumericUpDown();
            this.numStartSS = new System.Windows.Forms.NumericUpDown();
            this.numEndSS = new System.Windows.Forms.NumericUpDown();
            this.numEndMM = new System.Windows.Forms.NumericUpDown();
            this.numEndHH = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 49);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(176, 60);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(597, 22);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Text = "F:\\others\\islamic\\tozeeh sistani audio\\توضيح المسائل  18.mpeg";
            // 
            // btnBrowseInputFile
            // 
            this.btnBrowseInputFile.Location = new System.Drawing.Point(779, 59);
            this.btnBrowseInputFile.Name = "btnBrowseInputFile";
            this.btnBrowseInputFile.Size = new System.Drawing.Size(44, 23);
            this.btnBrowseInputFile.TabIndex = 3;
            this.btnBrowseInputFile.Text = "...";
            this.btnBrowseInputFile.UseVisualStyleBackColor = true;
            this.btnBrowseInputFile.Click += new System.EventHandler(this.btnBrowseInputFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "HH:MM:SS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "All Frames";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Image file";
            // 
            // txtImageFilePath
            // 
            this.txtImageFilePath.Location = new System.Drawing.Point(502, 157);
            this.txtImageFilePath.Name = "txtImageFilePath";
            this.txtImageFilePath.Size = new System.Drawing.Size(271, 22);
            this.txtImageFilePath.TabIndex = 10;
            // 
            // btnBrowseImageFile
            // 
            this.btnBrowseImageFile.Location = new System.Drawing.Point(779, 157);
            this.btnBrowseImageFile.Name = "btnBrowseImageFile";
            this.btnBrowseImageFile.Size = new System.Drawing.Size(44, 23);
            this.btnBrowseImageFile.TabIndex = 11;
            this.btnBrowseImageFile.Text = "...";
            this.btnBrowseImageFile.UseVisualStyleBackColor = true;
            this.btnBrowseImageFile.Click += new System.EventHandler(this.btnBrowseImageFile_Click);
            // 
            // txtAllFramesInfo
            // 
            this.txtAllFramesInfo.Location = new System.Drawing.Point(176, 248);
            this.txtAllFramesInfo.MaxLength = 9999999;
            this.txtAllFramesInfo.Multiline = true;
            this.txtAllFramesInfo.Name = "txtAllFramesInfo";
            this.txtAllFramesInfo.Size = new System.Drawing.Size(647, 238);
            this.txtAllFramesInfo.TabIndex = 12;
            // 
            // btnAddFrame
            // 
            this.btnAddFrame.Location = new System.Drawing.Point(855, 143);
            this.btnAddFrame.Name = "btnAddFrame";
            this.btnAddFrame.Size = new System.Drawing.Size(101, 51);
            this.btnAddFrame.TabIndex = 13;
            this.btnAddFrame.Text = "Add Frame";
            this.btnAddFrame.UseVisualStyleBackColor = true;
            this.btnAddFrame.Click += new System.EventHandler(this.btnAddFrame_Click);
            // 
            // numStartHH
            // 
            this.numStartHH.Location = new System.Drawing.Point(219, 153);
            this.numStartHH.Name = "numStartHH";
            this.numStartHH.Size = new System.Drawing.Size(57, 22);
            this.numStartHH.TabIndex = 14;
            // 
            // numStartMM
            // 
            this.numStartMM.Location = new System.Drawing.Point(285, 153);
            this.numStartMM.Name = "numStartMM";
            this.numStartMM.Size = new System.Drawing.Size(57, 22);
            this.numStartMM.TabIndex = 15;
            // 
            // numStartSS
            // 
            this.numStartSS.Location = new System.Drawing.Point(351, 153);
            this.numStartSS.Name = "numStartSS";
            this.numStartSS.Size = new System.Drawing.Size(57, 22);
            this.numStartSS.TabIndex = 16;
            // 
            // numEndSS
            // 
            this.numEndSS.Location = new System.Drawing.Point(351, 192);
            this.numEndSS.Name = "numEndSS";
            this.numEndSS.Size = new System.Drawing.Size(57, 22);
            this.numEndSS.TabIndex = 19;
            // 
            // numEndMM
            // 
            this.numEndMM.Location = new System.Drawing.Point(285, 192);
            this.numEndMM.Name = "numEndMM";
            this.numEndMM.Size = new System.Drawing.Size(57, 22);
            this.numEndMM.TabIndex = 18;
            // 
            // numEndHH
            // 
            this.numEndHH.Location = new System.Drawing.Point(219, 192);
            this.numEndHH.Name = "numEndHH";
            this.numEndHH.Size = new System.Drawing.Size(57, 22);
            this.numEndHH.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "End";
            // 
            // VideoEditingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numEndSS);
            this.Controls.Add(this.numEndMM);
            this.Controls.Add(this.numEndHH);
            this.Controls.Add(this.numStartSS);
            this.Controls.Add(this.numStartMM);
            this.Controls.Add(this.numStartHH);
            this.Controls.Add(this.btnAddFrame);
            this.Controls.Add(this.txtAllFramesInfo);
            this.Controls.Add(this.btnBrowseImageFile);
            this.Controls.Add(this.txtImageFilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseInputFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "VideoEditingUC";
            this.Size = new System.Drawing.Size(1200, 625);
            ((System.ComponentModel.ISupportInitialize)(this.numStartHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnBrowseInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImageFilePath;
        private System.Windows.Forms.Button btnBrowseImageFile;
        private System.Windows.Forms.TextBox txtAllFramesInfo;
        private System.Windows.Forms.Button btnAddFrame;
        private System.Windows.Forms.NumericUpDown numStartHH;
        private System.Windows.Forms.NumericUpDown numStartMM;
        private System.Windows.Forms.NumericUpDown numStartSS;
        private System.Windows.Forms.NumericUpDown numEndSS;
        private System.Windows.Forms.NumericUpDown numEndMM;
        private System.Windows.Forms.NumericUpDown numEndHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
