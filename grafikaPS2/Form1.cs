using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace grafikaPS2
{
    public partial class Form1 : Form
    {
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
            if (tabControl.TabCount < 1) return;

            PictureTabPage tab = (PictureTabPage)tabControl.SelectedTab;
            Image image = tab.Image;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                string extension = Path.GetExtension(saveFileDialog.FileName);

                Cursor = Cursors.WaitCursor;

                try
                {
                    if (extension == ".pbm" || extension == ".pgm" || extension == ".ppm")
                    {
                        Anymap.Save(image, path);
                    }
                    else
                    {
                        image.Save(path);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(string.Format("Could not save file as {0}!", path), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Cursor = Cursors.Default;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void LoadImage(string path)
        {
            string filename = Path.GetFileName(path);
            string extension = Path.GetExtension(path);

            PictureTabPage tab = new PictureTabPage(filename);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            tab.Cursor = Cursors.WaitCursor;

            try
            {
                Image image;
                if (extension == ".pbm" || extension == ".pgm" || extension == ".ppm")
                {
                    image = await Anymap.LoadAsync(path);
                }
                else
                {
                    image = Image.FromFile(path);
                }

                tab.Image = image;
                saveAsToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                tabControl.TabPages.Remove(tab);
                MessageBox.Show(string.Format("Error loading {0}!", path), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tab.Cursor = Cursors.Default;
        }

        private void tabControl_TabClosed(object sender, EventArgs e)
        {
            if (tabControl.TabCount < 1)
            {
                saveAsToolStripMenuItem.Enabled = false;
            }
        }
    }
}
