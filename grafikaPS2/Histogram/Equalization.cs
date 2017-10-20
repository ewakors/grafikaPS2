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
    public partial class Equalization : Form
    {
        Form1 parent;

        double[] LUTr = new double[256], LUTg = new double[256], LUTb = new double[256], LUTgray = new double[256];

        public Equalization(Form1 p)
        {
            InitializeComponent();
            parent = p;
            EqualizationHistogram();
        }

        double[] UpdateLUTEqualization(double[] D, double[] LUT, int series)
        {
            int i;
            double D0min;
            //znajdz pierwszą niezerową wartosc dystrybuanty
            i = 0;
            while (D[i] == 0) i++;
            D0min = D[i];

            for (i = 0; i < 256; i++)
                LUT[i] = (((D[i] - D0min) / (1 - D0min)) * (256 - 1));

            return LUT;
        }
        
        void EqualizationHistogram()
        {
            var ee = parent.color_bmp;
            int i, j, rvalue, gvalue, bvalue, grayvalue;
            double sumR, sumG, sumB, sumGray, numberOfPixels;
            double[] r = new double[256], g = new double[256], b = new double[256], gray = new double[256];
            double[] Dr = new double[256], Dg = new double[256], Db = new double[256], Dgray = new double[256];
            Color color;

            for (i = 0; i < 256; i++)
            {
                r[i] = 0;
                g[i] = 0;
                b[i] = 0;
                gray[i] = 0;
            }

            //oblicz dystrybuante
            for (i = 0; i < ee.Width; i++)
                for (j = 0; j < ee.Height; j++)
                {
                    color = ee.GetPixel(i, j);
                    r[color.R]++;
                    g[color.G]++;
                    b[color.B]++;

                }
            for (int z = 0; z < LUTr.Length; z++)
            {
                chartEquaization.Series["Red"].Points.AddXY(z, r[z]);
                chartEquaization.Series["Green"].Points.AddXY(z, g[z]);
                chartEquaization.Series["Blue"].Points.AddXY(z, b[z]);
            }

            numberOfPixels = (ee.Width) * (ee.Height);
            sumR = 0;
            sumG = 0;
            sumB = 0;
            sumGray = 0;
            for (i = 0; i < 256; i++)
            {
                sumR += (r[i] / numberOfPixels);
                sumG += (g[i] / numberOfPixels);
                sumB += (b[i] / numberOfPixels);
                //sumGray += (gray[i]/numberOfPixels);

                Dr[i] += sumR;
                Dg[i] += sumG;
                Db[i] += sumB;
                Dgray[i] += sumGray;
            }

            //przelicz tablice LUT, tak by wyrownac histogram
            LUTr = UpdateLUTEqualization(Dr, LUTr, 1);
            LUTg = UpdateLUTEqualization(Dg, LUTg, 2);
            LUTb = UpdateLUTEqualization(Db, LUTb, 3);
            //LUTgray= (Dgray, LUTgray, 0);

            for (i = 0; i < 256; i++)
            {
                r[i] = 0;
                g[i] = 0;
                b[i] = 0;
                gray[i] = 0;
            }

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

            for (var z = 0; z < ee.Width; z++)
            {
                for (var y = 0; y < ee.Height; y++)
                {
                    Color pixel = ee.GetPixel(z, y);
                    int a, rr, gg, bb;

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
