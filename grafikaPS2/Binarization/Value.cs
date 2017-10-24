using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafikaPS2
{
    public partial class Value : Form
    {
        Form1 parent;

        public Value(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        public int[] imageValueHistogram(Bitmap bmp)
        {

            int[] histogram = new int[256];

            for (int i = 0; i < histogram.Length; i++)
            {
                histogram[i] = 0;
            }

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int red = (bmp.GetPixel(i, j)).R;
                    histogram[red]++;
                }
            }

            return histogram;

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Bitmap ee = parent.color_bmp;
            for (var i = 0; i < ee.Width; i++)
            {
                for (var j = 0; j < ee.Height; j++)
                {
                    int prog = int.Parse(valueTextBox.Text);

                    if (prog > 255 || prog <0)
                    {
                        MessageBox.Show("Invalide value");
                    }

                    Color pixel = ee.GetPixel(i, j);
                    int r, g, b;

                    if ((pixel.R + pixel.B + pixel.G) / 3 >= prog)
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
