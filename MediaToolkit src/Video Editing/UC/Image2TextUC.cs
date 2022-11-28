using Google.Cloud.Vision.V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Editing.UC
{
    public partial class Image2TextUC : UserControl
    {
        public Image2TextUC()
        {
            InitializeComponent();
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
            else
            {
                MessageBox.Show("Please select image file");
                return;
            }
            var image = System.Drawing.Image.FromFile(txtFilePath.Text);// new Bitmap(txtFilePath.Text);
            pictureBox.Image = image.GetThumbnailImage(pictureBox.Width,pictureBox.Height,()=>false,IntPtr.Zero);
            //pictureBox.Size = image.Size;
        }
        private void ProcessFile()
        {

        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if(txtFilePath.Text==string.Empty)
            {
                MessageBox.Show("Please first select image file");
                return;
            }
            var client = ImageAnnotatorClient.Create();
            new ImageAnnotatorSettings() { };
            var img = Image.FromFile(txtFilePath.Text);
            var textAnnotations = client.DetectText(img);
            //foreach(var txt in textAnnotations)
            //{
            //    txtOutput.Text = txt.Description;
            //}
            var allText=textAnnotations.Select(x => x.Description).ToArray();
            txtOutput.Text = string.Join("", allText);
        }
    }
}
