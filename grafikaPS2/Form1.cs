using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Threading;

namespace grafikaPS2
{
    public partial class Form1 : Form
    {
        private Image image;
        private int r = 0, g = 0, b = 0, c = 0, m = 0, y = 0, k = 100;
        bool ChooseState = false;
        private Bitmap color_bmp;
        Color pointColor;

        public Form1(string path)
            : this()
        {
            LoadImage(path);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string path in openFileDialog.FileNames)
                {
                    LoadImage(path);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (tabControl.TabCount < 1) return;

            //PictureTabPage tab = (PictureTabPage)tabControl.SelectedTab;
            //Image image = tab.Image;

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    string path = saveFileDialog.FileName;
            //    string extension = Path.GetExtension(saveFileDialog.FileName);

            //    Cursor = Cursors.WaitCursor;

            //    try
            //    {
            //        if (extension == ".pbm" || extension == ".pgm" || extension == ".ppm")
            //        {
            //            Anymap.Save(image, path);
            //        }
            //        else
            //        {
            //            image.Save(path);
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show(string.Format("Could not save file as {0}!", path), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    Cursor = Cursors.Default;
            //}
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void LoadImage(string path)
        {
            string filename = Path.GetFileName(path);
            string extension = Path.GetExtension(path);

            try
            {
                if (extension == ".pbm" || extension == ".pgm" || extension == ".ppm")
                {
                    pictureBox1.Image = await Anymap.LoadAsync(path);
                    color_bmp = (Bitmap)pictureBox1.Image;
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(path);
                    color_bmp = (Bitmap)pictureBox1.Image;
                }

                saveAsToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error loading {0}!", path), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void redValue_ValueChanged(object sender, EventArgs e)
        {
           // pointColor = re
            Refresh();
        }

        private void convert_Click(object sender, EventArgs e)
        {
            double R, G, B;
            double C, M, Y, K;
            c = int.Parse(cyanValue.Text);
            m = int.Parse(magentaValue.Text);
            y = int.Parse(yellowValue.Text);
            k = int.Parse(blackValue.Text);
            C = (double)c;
            M = (double)m;
            Y = (double)y;
            K = (double)k;

            C = C / 100.00;
            M = M / 100.00;
            Y = Y / 100.00;
            K = K / 100.00;

            R = 1 - Math.Min(1, C * (1 - K) + K);
            G = 1 - Math.Min(1, M * (1 - K) + K);
            B = 1 - Math.Min(1, Y * (1 - K) + K);

            R = R * 255.0;
            G = G * 255.0;
            B = B * 255.0;

            r = Convert.ToInt32(R);
            g = Convert.ToInt32(G);
            b = Convert.ToInt32(B);

            redValue.Text = r.ToString();
            greenValue.Text = g.ToString();
            blueValue.Text = b.ToString();

            var bmp = pictureBox1.Image == null ? new Bitmap(pictureBox1.Width, pictureBox1.Height) : new Bitmap(pictureBox1.Image);
            
            for (int j = 0; j < pictureBox1.Width; j++)
            {
                for (int i = 0; i < pictureBox1.Height; i++)
                {
                    if ( i < pictureBox1.Height && j < pictureBox1.Width)
                    {
                        bmp.SetPixel(j, i, Color.FromArgb(r, g, b));
                    }
                }
            }

            pictureBox1.Image = bmp;
            showBackColor.Image = bmp;
        }

        private void convertToCMYK_Click(object sender, EventArgs e)
        {
            r = int.Parse(redValue.Text);
            g = int.Parse(greenValue.Text);
            b = int.Parse(blueValue.Text);

            var bmp = pictureBox1.Image == null ? new Bitmap(pictureBox1.Width, pictureBox1.Height) : new Bitmap(pictureBox1.Image);
            for (int j = 0; j < pictureBox1.Width; j++)
            {
                for (int i = 0; i < pictureBox1.Height; i++)
                {
                    if (i < pictureBox1.Height && j < pictureBox1.Width)
                    {
                        bmp.SetPixel(j, i, Color.FromArgb(r, g, b));
                    }
                }
            }

            calculateToCMYK();
            pictureBox1.Image = bmp;
            showBackColor.Image = bmp;          
        }

        private void createRGBCube_Click(object sender, EventArgs e)
        {
            var bmp = pictureBox1.Image == null ? new Bitmap(pictureBox1.Width, pictureBox1.Height) : new Bitmap(pictureBox1.Image);

            Graphics gc = Graphics.FromImage(bmp);
            gc.DrawLine(Pens.Black, 0, 127, 255, 127); //gora przod
            gc.DrawLine(Pens.Black, 127, 0, 382, 0); // gora tyl
            gc.DrawLine(Pens.Black, 0, 127, 127, 0); // laczenie gora lewa
            gc.DrawLine(Pens.Black, 255, 127, 382, 0); // laczenie gora prawa
            gc.DrawLine(Pens.Black, 0, 382, 0, 127); // laczenie lewy bok przod
            gc.DrawLine(Pens.Black, 0, 382, 255, 382); // laczenie dol		
            gc.DrawLine(Pens.Black, 255, 127, 255, 382); // laczenie prawy bok przod
            gc.DrawLine(Pens.Black, 382, 255, 382, 0); // laczenie prawy bok tyl
            gc.DrawLine(Pens.Black, 255, 382, 382, 255); // laczenie dol prawy
            pictureBox1.Image = bmp;

            // rozowy
            int R = 255, G = 1, B = 255;

            // przedni
            for (int j = 128; j < 382; j++)
            {
                for (int i = 1; i < 255; i++)
                {
                    // Draw the line with the wide green pen.
                    bmp.SetPixel(i, j, Color.FromArgb(255, R, G, B));

                    // Draw the line with the thin black pen.
                    G++;
                }
                R--;
                G = 1;
            }
            // czerwony
            R = 255;
            G = 1;
            B = 1;
            int x = 127;
            // górny
            for (int i = 1; i < 127; i++)
            {
                for (int j = 0; j < 254; j++)
                {
                    bmp.SetPixel(j + x, i, Color.FromArgb(255, R, G, B));
                    G++;
                }
                B = B + 2;
                G = 1;
                x--;
            }

            // bialy
            G = 255;
            R = 255;
            B = 255;
            x = 127;
            int x1 = 255;
            // prawy
            for (int i = 1; i < 127; i++)
            {
                for (int j = 0; j < 254; j++)
                {
                    bmp.SetPixel(i + x1, j + x, Color.FromArgb(255, R, G, B));
                    R--;
                }
                x--;
                B = B - 2;
                R = 255;
            }
        }

        private void tabControl_TabClosed(object sender, EventArgs e)
        {
            //if (tabControl.TabCount < 1)
            //{
            //    saveAsToolStripMenuItem.Enabled = false;
            //}
        }

        private void colorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            ChooseState = true;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                pictureBox1.BackColor = pointColor;
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                pictureBox1.BackColor = Color.Transparent;
        }

        private void colorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            if (ChooseState == false)
            {
                color_bmp = (Bitmap)colorPicker.Image.Clone();
                if (e.X < color_bmp.Width && e.Y < color_bmp.Height)
                {
                    pointColor = color_bmp.GetPixel(e.X, e.Y);
                    redValue.Value = pointColor.R;
                    greenValue.Value = pointColor.G;
                    blueValue.Value = pointColor.B;
                    showBackColor.BackColor = pointColor;
                    calculateToCMYK();
                } 
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Focus();
        }

        private void colorPicker_MouseUp(object sender, MouseEventArgs e)
        {
            ChooseState = false;
        }

        private void calculateToCMYK()
        {
            double  R , G, B;
            double C, M, Y, K;
            r = int.Parse(redValue.Text);
            g = int.Parse(greenValue.Text);
            b = int.Parse(blueValue.Text);

            R = (double)r;
            G = (double)g;
            B = (double)b;

            R = (R / 255.0);
            G = (G / 255.0);
            B = (B / 255.0);

            K = Math.Min(1 - R, 1 - G);
            K = Math.Min(K, 1 - B);
            if (K == 1)
            {
                C = 0;
                M = 0;
                Y = 0;
            }
            else
            {
                C = (1.0 - R - K) / (1.0 - K);
                M = (1.0 - G - K) / (1.0 - K);
                Y = (1.0 - B - K) / (1.0 - K);
            }

            C = (C * 100);
            M = (M * 100);
            Y = (Y * 100);
            K = (K * 100);

            c = (int)(C);
            m = (int)(M);
            y = (int)(Y);
            k = (int)(K);

            cyanValue.Text = c.ToString();
            magentaValue.Text = m.ToString();
            yellowValue.Text = y.ToString();
            blackValue.Text = k.ToString();
        }

        #region Colors
        private void grayscale1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ee = color_bmp;


            for (var i = 0; i < ee.Width; i++)
            {
                for (var j = 0; j < ee.Height; j++)
                {
                    Color pixel = ee.GetPixel(i, j);
                    int r, g, b;

                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    r = (int)(0.21 * r + 0.71 * g + 0.07 * b);

                    ee.SetPixel(i, j, Color.FromArgb(r, r, r));
                }
            }
            pictureBox1.Image = ee;
        }
        private void grayscale2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ee = color_bmp;

            for (var i = 0; i < ee.Width; i++)
            {
                for (var j = 0; j < ee.Height; j++)
                {
                    Color pixel = ee.GetPixel(i, j);
                    int r, g, b;

                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;
                    int k = (int)(0.299 * r + 0.587 * g + 0.114 * b);

                    ee.SetPixel(i, j, Color.FromArgb(k, k, k));
                }
            }
            pictureBox1.Image = ee;
        }
        #endregion

        #region Filters

        int smoothingFilterSize = 3;
        int gaussFilterSize = 3;
        private int Size = 3;
        int[,] red, green, blue, gray;
        private int Norm;
        private Filters currentFilter;

        int[] smoothingFilter = {1, 1, 1,
                                 1, 1, 1,
                                 1, 1, 1};
        int[] sobelFilter = { 1,  2,  1,
                              0,  0,  0,
                             -1, -2, -1};
        int[] highPassFilter = { 0, -1,  0,
                                -1,  20, -1,
                                 0, -1,  0};
        int[] gaussFilter = {1, 2, 1,
                             2, 4, 2,
                             1, 2, 1};

        private void smoothingFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinearFiltr(smoothingFilter);
            LinearFiltr(smoothingFilter);
        }

        private void medianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianaFilter();
            MedianaFilter();
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinearFiltr(gaussFilter);
            LinearFiltr(gaussFilter);
        }      

        private void highpassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinearFiltr(highPassFilter);
            LinearFiltr(highPassFilter);
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinearFiltr(sobelFilter);
            LinearFiltr(sobelFilter);
        }

        enum Filters { Smoothing, Median, Sobel, Gurnoprzepustowywyostrzajacy, Gauss, SplotMaski }

        private void SetFilter(Filters f)
        {
            currentFilter = f;
        }

        void setRGBG()
        {
            red = new int[color_bmp.Width + 1, color_bmp.Height + 1];
            green = new int[color_bmp.Width + 1, color_bmp.Height + 1];
            blue = new int[color_bmp.Width + 1, color_bmp.Height + 1];
            gray = new int[color_bmp.Width + 1, color_bmp.Height + 1];

            for (var i = 0; i < color_bmp.Width; i++)
            {
                for (var j = 0; j < color_bmp.Height; j++)
                {
                    //int numer = int.Parse(textBox4.Text);
                    Color pixel = color_bmp.GetPixel(i, j);
                    //    int a, r, g, b;
                    red[i, j] = pixel.R;
                    green[i, j] = pixel.G;
                    blue[i, j] = pixel.B;
                }
            }
        }
        // obliczanie mediany
        int partition(int[] c, int a, int b)
        {
            int e, tmp;
            a = a;
            b = b;
            e = c[a];        //elemennt dzielacy
            while (a < b)
            {
                while ((a < b) && (c[b] >= e)) b--;
                while ((a < b) && (c[a] < e)) a++;
                if (a < b)
                {
                    tmp = c[a];
                    c[a] = c[b];
                    c[b] = tmp;
                }
            }
            return a;
        }

        //obliczanie mediany
        int mediana(int[] c, int size)
        {
            //algorytm Hoare'a
            int i = 0;
            int j = size - 1;
            int w = j / 2;
            int k;
            while (i != j)
            {
                k = partition(c, i, j);
                k = k - i + 1;
                if (k >= w)
                    j = i + k - 1;
                if (k < w)
                {
                    w -= k;
                    i += k;
                }
            }
            return c[i];
        }

        private void LinearFiltr(int[] Filter)
        {
            setRGBG();
            int rsume, gsume, bsume, graysume;
            var ee = color_bmp;
            int margin = ((Size - 1) / 2);
            Norm = 0;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    Norm += Filter[i + 3 * j];

            if (Norm == 0) Norm = 1;
            //filtr dla obrazu kolorowego
            for (int i = margin; i < ee.Width; i++)
                for (int j = margin; j < ee.Height; j++)
                {
                    rsume = 0;
                    gsume = 0;
                    bsume = 0;
                    for (int k = 0; k < Size; k++)
                        for (int l = 0; l < Size; l++)
                        {
                            rsume += Filter[k * Size + l] * red[i + k - margin, j + l - margin];
                            gsume += Filter[k * Size + l] * green[i + k - margin, j + l - margin];
                            bsume += Filter[k * Size + l] * blue[i + k - margin, j + l - margin];
                        }
                    rsume /= Norm;
                    gsume /= Norm;
                    bsume /= Norm;

                    if (rsume > 255) rsume = 255;
                    else if (rsume < 0) rsume = 0;
                    if (gsume > 255) gsume = 255;
                    else if (gsume < 0) gsume = 0;
                    if (bsume > 255) bsume = 255;
                    else if (bsume < 0) bsume = 0;

                    ee.SetPixel(i, j, Color.FromArgb(rsume + (gsume << 8) + (bsume << 16)));
                }
            color_bmp = ee;

            for (var i = 0; i < ee.Width; i++)
            {
                for (var j = 0; j < ee.Height; j++)
                {
                    Color pixel = ee.GetPixel(i, j);
                    int a, r, g, b;

                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;

                    ee.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox1.Image = ee;
        }

        private void MedianaFilter()
        {
            var ee = color_bmp;

            setRGBG();

            int m;
            int[] rval = new int[9], gval = new int[9], bval = new int[9], grayval = new int[9];
            Size = 3;
            int margin = ((Size - 1) / 2);

            //filtr dla obrazu kolorowego
            for (int i = margin; i < ee.Width; i++)
                for (int j = margin; j < ee.Height; j++)
                {
                    m = 0;
                    for (int k = 0; k < Size; k++)
                        for (int l = 0; l < Size; l++)
                        {
                            rval[m] = red[i + k - margin, j + l - margin];
                            gval[m] = green[i + k - margin, j + l - margin];
                            bval[m] = blue[i + k - margin, j + l - margin];
                            m++;
                        }
                    ee.SetPixel(i, j, Color.FromArgb(mediana(rval, 9) + (mediana(gval, 9) << 8) + (mediana(bval, 9) << 16)));
                }
            color_bmp = ee;

            for (var i = 0; i < ee.Width; i++)
            {
                for (var j = 0; j < ee.Height; j++)
                {
                    Color pixel = ee.GetPixel(i, j);
                    int a, r, g, b;
             
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;

                    ee.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox1.Image = ee;
        }

        #endregion
    }
}
