using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Editing.Code
{
    public static class UtilityMethods
    {

        public static Image DrawText(String text, Font font, Color textColor, Color backColor,Size size)
        {
            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, font);

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap(size.Width, size.Height);

            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(backColor);

            //create a brush for the text
            Brush textBrush = new SolidBrush(textColor);
            var siz = new SizeF(size.Width,size.Height);
            var pointf = new PointF(0, 0);
            var layout = new RectangleF(pointf, siz);
            drawing.DrawString(text, font, textBrush, layout,new StringFormat());

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            return img;

        }
    }
}
