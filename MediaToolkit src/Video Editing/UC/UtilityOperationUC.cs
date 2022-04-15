using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Video_Editing.Code;

namespace Video_Editing.UC
{
    public partial class UtilityOperationUC : UserControl
    {
        public UtilityOperationUC()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var image = GenerateImage();
            pictureBox1.Image = image;
        }
        private Image GenerateImage()
        {

            var size = new Size((int)numWidth.Value, (int)numHeight.Value);
            var font = new Font(txtInput.Font.Name, label1.Font.Size * 5f, txtInput.Font.Style, label1.Font.Unit);
            var image = UtilityMethods.DrawText(txtInput.Text,
                 font
                 , Color.Black, Color.White, size);
            return image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var image = GenerateImage();
            saveFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
