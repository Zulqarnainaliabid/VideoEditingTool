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
           var image= UtilityMethods.DrawText(txtInput.Text, 
                new Font(label1.Font.Name,label1.Font.Size,label1.Font.Style,label1.Font.Unit)
                , Color.Black, Color.White);
            pictureBox1.Image = image;
        }
    }
}
