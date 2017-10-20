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
    public partial class Multiplication : Form
    {
        Form1 parent;
        public Multiplication(Form1 p)
        {
            parent = p;
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            var ee = (Bitmap)parent.pictureBox.Image;

            for (var i = 0; i < ee.Width; i++)
            {
                for (var j = 0; j < ee.Height; j++)
                {
                    int numer = int.Parse(multiTextBox.Text);
                    Color pixel = ee.GetPixel(i, j);
                    int r, g, b;

                    r = pixel.R * numer;
                    if (r >= 255)
                        r = 255;
                    else if (r <= 0)
                        r = 0;
                    g = pixel.G * numer;
                    if (g >= 255)
                        g = 255;
                    else if (g <= 0)
                        g = 0;
                    b = pixel.B * numer;
                    if (b >= 255)
                        b = 255;
                    else if (b <= 0)
                        b = 0;
                    ee.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            parent.pictureBox.Image = ee;
        }
    }
}
