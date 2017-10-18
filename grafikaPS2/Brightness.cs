using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace grafikaPS2
{
    public partial class Brightness : Form
    {
        Bitmap original;
        Bitmap appliedBr;
        Form1 parent;

        public Brightness(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void updateBrightness()
        {
            //if (trackBarBrightness.Value != 0)
            //    appliedBr = BrightnessBmp(appliedCtr, trackBarBrightness.Value);
            //else
            //    appliedBr = BrightnessBmp(original, trackBarBrightness.Value);

            //using (Graphics gdx = Graphics.FromImage(parent.Space.SelectedLayerW.LayerImage))
            //{
            //    gdx.DrawImage(appliedBr, new Point(0, 0));
            //}
            //parent.DrawUpdater(true);
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            //var ee = parent.color_bmp;

            //if (trackBarBrightness.Value > 0)
            //{
            //    for (var i = 0; i < ee.Width; i++)
            //    {
            //        for (var j = 0; j < ee.Height; j++)
            //        {

            //            Color pixel = ee.GetPixel(i, j);
            //            int r, g, b;


            //            r = pixel.R - trackBarBrightness.Value;
            //            if (r >= 255)
            //                r = 255;
            //            else if (r <= 0)
            //                r = 0;
            //            g = pixel.G - trackBarBrightness.Value;
            //            if (g >= 255)
            //                g = 255;
            //            else if (g <= 0)
            //                g = 0;
            //            b = pixel.B - trackBarBrightness.Value;
            //            if (b >= 255)
            //                b = 255;
            //            else if (b <= 0)
            //                b = 0;
            //            ee.SetPixel(i, j, Color.FromArgb(r, g, b));

            //        }
            //    }
            //}
            //else
            //{
            //    for (var i = 0; i < ee.Width; i++)
            //    {
            //        for (var j = 0; j < ee.Height; j++)
            //        {

            //            Color pixel = ee.GetPixel(i, j);
            //            int r, g, b;


            //            r = pixel.R - trackBarBrightness.Value;
            //            if (r >= 255)
            //                r = 255;
            //            else if (r <= 0)
            //                r = 0;
            //            g = pixel.G - trackBarBrightness.Value;
            //            if (g >= 255)
            //                g = 255;
            //            else if (g <= 0)
            //                g = 0;
            //            b = pixel.B - trackBarBrightness.Value;
            //            if (b >= 255)
            //                b = 255;
            //            else if (b <= 0)
            //                b = 0;
            //            ee.SetPixel(i, j, Color.FromArgb(r, g, b));

            //        }
            //    }
            //}
            //parent.pictureBox.Image = ee;
            
             parent.pictureBox.Image = BrightnessBmp((Bitmap)parent.pictureBox.Image, trackBarBrightness.Value);         
        }

        public static Bitmap BrightnessBmp(Bitmap original, int factor)
        {
            Bitmap bmp = (Bitmap)original.Clone();
            if (factor < -255) factor = -255;
            if (factor > 255) factor = 255;

            BitmapData bmpd = bmp.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelData = new byte[bmpd.Stride * original.Height];

            Marshal.Copy(bmpd.Scan0, pixelData, 0, pixelData.Length);
            bmp.UnlockBits(bmpd);

            double[] rgb = new double[] { 0, 0, 0 };

            for (int x = 0; x + 4 < pixelData.Length; x += 4)
            {
                rgb[0] = pixelData[x + 2] + factor;
                rgb[1] = pixelData[x + 1] + factor;
                rgb[2] = pixelData[x] + factor;

                if (rgb[0] < 0) rgb[0] = 1;
                else if (rgb[0] > 255) rgb[0] = 255;

                if (rgb[1] < 0) rgb[1] = 1;
                else if (rgb[1] > 255) rgb[1] = 255;

                if (rgb[2] < 0) rgb[2] = 1;
                else if (rgb[2] > 255) rgb[2] = 255;

                pixelData[x + 2] = (byte)rgb[0];
                pixelData[x + 1] = (byte)rgb[1];
                pixelData[x] = (byte)rgb[2];
            }

            BitmapData rbmpd = bmp.LockBits(new Rectangle(0, 0, original.Width, original.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(pixelData, 0, rbmpd.Scan0, pixelData.Length);
            bmp.UnlockBits(rbmpd);

            return bmp; ;
            //Bitmap TempBitmap = Image;

            //Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);

            //Graphics NewGraphics = Graphics.FromImage(NewBitmap);

            //float FinalValue = (float)Value / 255.0f;

            //float[][] FloatColorMatrix ={

            //         new float[] {1, 0, 0, 0, 0},

            //         new float[] {0, 1, 0, 0, 0},

            //         new float[] {0, 0, 1, 0, 0},

            //         new float[] {0, 0, 0, 1, 0},

            //         new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
            //     };

            //ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);

            //ImageAttributes Attributes = new ImageAttributes();

            //Attributes.SetColorMatrix(NewColorMatrix);

            //NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);

            //Attributes.Dispose();

            //NewGraphics.Dispose();

            //return NewBitmap;
        }

        private void Brightness_Load(object sender, EventArgs e)
        {
            //original = (Bitmap)parent
            //    Space.SelectedLayerW.LayerImage.Clone();
            //appliedBr = (Bitmap)original.Clone();
        }
    }
}
