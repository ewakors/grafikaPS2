using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafikaPS2.Binarization
{
    public partial class PercentBlackSelection : Form
    {
        Form1 parent;

        public PercentBlackSelection(Form1 p)
        {
            parent =p;
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            int min = 0, max = 0, value, r, g, b;
            double procent = 0;
            Bitmap ee = parent.color_bmp;
            Color pixel;
            
            for (var i =0; i<ee.Width;i++)
            {
                for (var j =0; j<ee.Height;j++)
                {
                    pixel = ee.GetPixel(i, j);
                    value = ((pixel.R + pixel.G + pixel.B) / 3);
                    if (value >= max)
                    {
                        max = value;
                    }
                    if (value <= min)
                    {
                        min = value;
                    }
                }
            }

            procent = (max - min) * (double.Parse(percentBlack.Text)/100);

            for (var i = 0; i < ee.Width; i++)
            {
                for (var j = 0; j < ee.Height; j++)
                {
                    pixel = ee.GetPixel(i, j);
                    value = ((pixel.R + pixel.G + pixel.B) / 3);
                    if (value >= procent)
                    {
                        r = g = b = 255;
                    }
                    else
                    {
                        r = g = b = 0;
                    }
                    ee.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            parent.color_bmp = ee;
            parent.pictureBox.Image = ee;
        }
    }
}
