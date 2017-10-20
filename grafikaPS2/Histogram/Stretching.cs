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
    }
}
