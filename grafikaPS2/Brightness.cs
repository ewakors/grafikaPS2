using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Input;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

namespace grafikaPS2
{
    public partial class Brightness : Form
    {
        Form1 parent;
        public Brightness(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            parent.pictureBox.Image = BrightnessBmp(parent.color_bmp, trackBarBrightness.Value);         
        }

        public static Bitmap BrightnessBmp(Bitmap image, int factor)
        {
            Bitmap TempBitmap = image;
            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);
            Graphics NewGraphics = Graphics.FromImage(NewBitmap);

            float FinalValue = (float)factor / 255.0f;

            float[][] FloatColorMatrix ={

                     new float[] {1, 0, 0, 0, 0},
                     new float[] {0, 1, 0, 0, 0},
                     new float[] {0, 0, 1, 0, 0},
                     new float[] {0, 0, 0, 1, 0},
                     new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                 };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes Attributes = new ImageAttributes();

            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();

            return NewBitmap;
        }
    }
}
