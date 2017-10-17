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
        Bitmap color_bmp;
        Color pointColor;

        public Form1(string path)
            : this()
        {
            LoadImage(path);
        }

        public Form1()
        {
            InitializeComponent();

            //var bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //for (var i = 0; i < pictureBox1.Width; i++)
            //{
            //    for (var j = 0; j < pictureBox1.Height; j++)
            //    {
            //        bitmap.SetPixel(i, j, Color.Red);
            //    }
            //}

            //pictureBox1.Image = bitmap;
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
            //string filename = Path.GetFileName(path);
            //string extension = Path.GetExtension(path);

            //PictureBox pictureBox = new PictureBox(filename);
            
            //PictureTabPage tab = new PictureTabPage(filename);
            //tabControl.TabPages.Add(tab);
            //tabControl.SelectedTab = tab;
            //tab.Cursor = Cursors.WaitCursor;

            //try
            //{
            //    Image image;
            //    if (extension == ".pbm" || extension == ".pgm" || extension == ".ppm")
            //    {
            //        image = await Anymap.LoadAsync(path);
            //    }
            //    else
            //    {
            //        image = Image.FromFile(path);
            //    }

            //    tab.Image = image;
            //    saveAsToolStripMenuItem.Enabled = true;
            //}
            //catch (Exception ex)
            //{
            //    tabControl.TabPages.Remove(tab);
            //    MessageBox.Show(string.Format("Error loading {0}!", path), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //tab.Cursor = Cursors.Default;
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
    }
}
