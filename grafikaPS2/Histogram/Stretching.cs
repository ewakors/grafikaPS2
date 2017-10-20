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
    public partial class Stretching : Form
    {
        Form1 parent;
        public Stretching(Form1 p)
        {
            InitializeComponent();
            parent = p;
            HistogramStretching();
            HistogramStretching();
        }

        double[] LUTr = new double[256], LUTg = new double[256], LUTb = new double[256], LUTgray = new double[256];

        double[] UpdateLUTStretching(double a, int b, double[] LUT, int series)
        {
            int i;
            for (i = 0; i < 256; i++)
            {
                if ((a * (i + b)) > 255)
                    LUT[i] = 255;
                else if ((a * (i + b)) < 0)
                    LUT[i] = 0;
                else
                    LUT[i] = (a * (i + b));
            }
            return LUT;
        }

        void HistogramStretching()
        {

            var ee = parent.color_bmp;
            int i, j, rvalue, gvalue, bvalue;
            int rmin, gmin, bmin, graymin, rmax, gmax, bmax, graymax;
            double[] r = new double[256], g = new double[256], b = new double[256], gray = new double[256];
            Color color;

            for (i = 0; i < 256; i++)
            {
                r[i] = 0;
                g[i] = 0;
                b[i] = 0;
                gray[i] = 0;
            }

            //znajdz minimum i maksimum kazdej skladowej
            rmin = 255;
            gmin = 255;
            bmin = 255;
            graymin = 255;
            rmax = 1;
            gmax = 1;
            bmax = 1;
            graymax = 1;
            for (i = 0; i < ee.Width; i++)
                for (j = 0; j < ee.Height; j++)
                {
                    color = ee.GetPixel(i, j);
                    rvalue = color.R;
                    gvalue = color.G;
                    bvalue = color.B;
                    if (rvalue > rmax) rmax = rvalue;
                    if (gvalue > gmax) gmax = gvalue;
                    if (bvalue > bmax) bmax = bvalue;
                    if (rvalue < rmin) rmin = rvalue;
                    if (gvalue < gmin) gmin = gvalue;
                    if (bvalue < bmin) bmin = bvalue;
                }


            //przelicz tablice LUT, tak by rozciagnac histogram
            LUTr = UpdateLUTStretching(255.0 / (rmax - rmin), -rmin, LUTr, 1);
            LUTg = UpdateLUTStretching(255.0 / (gmax - gmin), -gmin, LUTg, 2);
            LUTb = UpdateLUTStretching(255.0 / (bmax - bmin), -bmin, LUTb, 3);
            LUTg = UpdateLUTStretching(255.0 / (graymax - graymin), -graymin, LUTgray, 4);


            for (i = 0; i < ee.Width; i++)
                for (j = 0; j < ee.Height; j++)
                {
                    color = ee.GetPixel(i, j);
                    rvalue = color.R;
                    gvalue = color.G;
                    bvalue = color.B;
                    //zmien wartosc wedlug tablicy LUT
                    color = Color.FromArgb((int)LUTr[rvalue] + ((int)LUTg[gvalue] << 8) + ((int)LUTb[bvalue] << 16));
                    //oblicz histogram
                    ee.SetPixel(i, j, color);

                    r[color.R]++;
                    g[color.G]++;
                    b[color.B]++;
                }

            for (i = 0; i < 256; i++)
            {

                chartStretching.Series["Red"].Points.AddXY(i, r[i]);
                chartStretching.Series["Green"].Points.AddXY(i, g[i]);
                chartStretching.Series["Blue"].Points.AddXY(i, b[i]);
            }

            for (var z = 0; z < ee.Width; z++)
            {
                for (var y = 0; y < ee.Height; y++)
                {
                    Color pixel = ee.GetPixel(z, y);
                    int rr, gg, bb;

                    rr = pixel.R;
                    gg = pixel.G;          
                    bb = pixel.B;

                    ee.SetPixel(z, y, Color.FromArgb(rr, gg, bb));
                }
            }
            parent.color_bmp = ee;

            parent.pictureBox.Image = ee;
        }
    }
}
