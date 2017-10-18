namespace grafikaPS2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greenValue = new System.Windows.Forms.NumericUpDown();
            this.blueValue = new System.Windows.Forms.NumericUpDown();
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.showBackColor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cyanValue = new System.Windows.Forms.TextBox();
            this.magentaValue = new System.Windows.Forms.TextBox();
            this.yellowValue = new System.Windows.Forms.TextBox();
            this.blackValue = new System.Windows.Forms.TextBox();
            this.redValue = new System.Windows.Forms.NumericUpDown();
            this.convert = new System.Windows.Forms.Button();
            this.convertToCMYK = new System.Windows.Forms.Button();
            this.createRGBCube = new System.Windows.Forms.Button();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.colorsToolStripMenuItem,
            this.effectsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg";
            // 
            // colorPicker
            // 
            this.colorPicker.Image = global::grafikaPS2.Properties.Resources.color_wheel_260x2601;
            this.colorPicker.Location = new System.Drawing.Point(752, 47);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(167, 163);
            this.colorPicker.TabIndex = 1;
            this.colorPicker.TabStop = false;
            this.colorPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseDown);
            this.colorPicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseMove);
            this.colorPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(734, 439);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // greenValue
            // 
            this.greenValue.Location = new System.Drawing.Point(859, 242);
            this.greenValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(60, 20);
            this.greenValue.TabIndex = 3;
            // 
            // blueValue
            // 
            this.blueValue.Location = new System.Drawing.Point(859, 269);
            this.blueValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(60, 20);
            this.blueValue.TabIndex = 4;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Location = new System.Drawing.Point(814, 218);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(30, 13);
            this.RedLabel.TabIndex = 5;
            this.RedLabel.Text = "Red:";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(814, 244);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(39, 13);
            this.GreenLabel.TabIndex = 6;
            this.GreenLabel.Text = "Green:";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(814, 271);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(31, 13);
            this.BlueLabel.TabIndex = 7;
            this.BlueLabel.Text = "Blue:";
            // 
            // showBackColor
            // 
            this.showBackColor.Location = new System.Drawing.Point(752, 218);
            this.showBackColor.Name = "showBackColor";
            this.showBackColor.Size = new System.Drawing.Size(54, 66);
            this.showBackColor.TabIndex = 8;
            this.showBackColor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(755, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cyan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Magenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(755, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yellow:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Black:";
            // 
            // cyanValue
            // 
            this.cyanValue.Location = new System.Drawing.Point(817, 300);
            this.cyanValue.Name = "cyanValue";
            this.cyanValue.Size = new System.Drawing.Size(48, 20);
            this.cyanValue.TabIndex = 18;
            // 
            // magentaValue
            // 
            this.magentaValue.Location = new System.Drawing.Point(817, 327);
            this.magentaValue.Name = "magentaValue";
            this.magentaValue.Size = new System.Drawing.Size(48, 20);
            this.magentaValue.TabIndex = 19;
            // 
            // yellowValue
            // 
            this.yellowValue.Location = new System.Drawing.Point(817, 353);
            this.yellowValue.Name = "yellowValue";
            this.yellowValue.Size = new System.Drawing.Size(48, 20);
            this.yellowValue.TabIndex = 20;
            // 
            // blackValue
            // 
            this.blackValue.Location = new System.Drawing.Point(817, 379);
            this.blackValue.Name = "blackValue";
            this.blackValue.Size = new System.Drawing.Size(48, 20);
            this.blackValue.TabIndex = 21;
            // 
            // redValue
            // 
            this.redValue.Location = new System.Drawing.Point(859, 216);
            this.redValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(60, 20);
            this.redValue.TabIndex = 22;
            this.redValue.ValueChanged += new System.EventHandler(this.redValue_ValueChanged);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(758, 405);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(107, 23);
            this.convert.TabIndex = 23;
            this.convert.Text = "Convert to RGB";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // convertToCMYK
            // 
            this.convertToCMYK.Location = new System.Drawing.Point(758, 434);
            this.convertToCMYK.Name = "convertToCMYK";
            this.convertToCMYK.Size = new System.Drawing.Size(107, 23);
            this.convertToCMYK.TabIndex = 24;
            this.convertToCMYK.Text = "Convert to CMYK";
            this.convertToCMYK.UseVisualStyleBackColor = true;
            this.convertToCMYK.Click += new System.EventHandler(this.convertToCMYK_Click);
            // 
            // createRGBCube
            // 
            this.createRGBCube.Location = new System.Drawing.Point(758, 463);
            this.createRGBCube.Name = "createRGBCube";
            this.createRGBCube.Size = new System.Drawing.Size(107, 23);
            this.createRGBCube.TabIndex = 25;
            this.createRGBCube.Text = "Create RGB-Cube";
            this.createRGBCube.UseVisualStyleBackColor = true;
            this.createRGBCube.Click += new System.EventHandler(this.createRGBCube_Click);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // effectsToolStripMenuItem
            // 
            this.effectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothingFilterToolStripMenuItem,
            this.medianFilterToolStripMenuItem});
            this.effectsToolStripMenuItem.Name = "effectsToolStripMenuItem";
            this.effectsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.effectsToolStripMenuItem.Text = "Filters";
            // 
            // smoothingFilterToolStripMenuItem
            // 
            this.smoothingFilterToolStripMenuItem.Name = "smoothingFilterToolStripMenuItem";
            this.smoothingFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.smoothingFilterToolStripMenuItem.Text = "Smoothing";
            this.smoothingFilterToolStripMenuItem.Click += new System.EventHandler(this.smoothingFilterToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.medianFilterToolStripMenuItem.Text = "Median";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 499);
            this.Controls.Add(this.createRGBCube);
            this.Controls.Add(this.convertToCMYK);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.redValue);
            this.Controls.Add(this.blackValue);
            this.Controls.Add(this.yellowValue);
            this.Controls.Add(this.magentaValue);
            this.Controls.Add(this.cyanValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showBackColor);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.greenValue);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.NumericUpDown greenValue;
        private System.Windows.Forms.NumericUpDown blueValue;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.PictureBox showBackColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cyanValue;
        private System.Windows.Forms.TextBox magentaValue;
        private System.Windows.Forms.TextBox yellowValue;
        private System.Windows.Forms.TextBox blackValue;
        private System.Windows.Forms.NumericUpDown redValue;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button convertToCMYK;
        private System.Windows.Forms.Button createRGBCube;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
    }
}

