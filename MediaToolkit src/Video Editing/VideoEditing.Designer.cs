
namespace Video_Editing
{
    partial class VideoEditing
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.videoEditingUC1 = new Video_Editing.UC.VideoEditingUC();
            this.youtubeManagerUC1 = new Video_Editing.UC.YoutubeManagerUC();
            this.utilityOperationUC1 = new Video_Editing.UC.UtilityOperationUC();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1222, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.videoEditingUC1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1214, 643);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video Editing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.youtubeManagerUC1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1214, 643);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Youtube Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.utilityOperationUC1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1214, 643);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tools";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // videoEditingUC1
            // 
            this.videoEditingUC1.Location = new System.Drawing.Point(6, 6);
            this.videoEditingUC1.Name = "videoEditingUC1";
            this.videoEditingUC1.Size = new System.Drawing.Size(1200, 625);
            this.videoEditingUC1.TabIndex = 0;
            // 
            // youtubeManagerUC1
            // 
            this.youtubeManagerUC1.Location = new System.Drawing.Point(7, 9);
            this.youtubeManagerUC1.Name = "youtubeManagerUC1";
            this.youtubeManagerUC1.Size = new System.Drawing.Size(1200, 625);
            this.youtubeManagerUC1.TabIndex = 0;
            // 
            // utilityOperationUC1
            // 
            this.utilityOperationUC1.Location = new System.Drawing.Point(6, 9);
            this.utilityOperationUC1.Name = "utilityOperationUC1";
            this.utilityOperationUC1.Size = new System.Drawing.Size(1200, 625);
            this.utilityOperationUC1.TabIndex = 0;
            // 
            // VideoEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 689);
            this.Controls.Add(this.tabControl1);
            this.Name = "VideoEditing";
            this.Text = "Video Editing";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private UC.VideoEditingUC videoEditingUC1;
        private System.Windows.Forms.TabPage tabPage2;
        private UC.YoutubeManagerUC youtubeManagerUC1;
        private System.Windows.Forms.TabPage tabPage3;
        private UC.UtilityOperationUC utilityOperationUC1;
    }
}

