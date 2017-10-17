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
    }
}
