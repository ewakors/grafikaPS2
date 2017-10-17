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
            this.redValue = new System.Windows.Forms.NumericUpDown();
            this.greenValue = new System.Windows.Forms.NumericUpDown();
            this.blueValue = new System.Windows.Forms.NumericUpDown();
            this.RedLabel = new System.Windows.Forms.Label();
            this.GreenLabel = new System.Windows.Forms.Label();
            this.BlueLabel = new System.Windows.Forms.Label();
            this.showBackColor = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBackColor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
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
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
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
            this.colorPicker.Location = new System.Drawing.Point(490, 27);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 427);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // redValue
            // 
            this.redValue.Location = new System.Drawing.Point(597, 196);
            this.redValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(60, 20);
            this.redValue.TabIndex = 2;
            // 
            // greenValue
            // 
            this.greenValue.Location = new System.Drawing.Point(597, 222);
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
            this.blueValue.Location = new System.Drawing.Point(597, 249);
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
            this.RedLabel.Location = new System.Drawing.Point(552, 198);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(30, 13);
            this.RedLabel.TabIndex = 5;
            this.RedLabel.Text = "Red:";
            // 
            // GreenLabel
            // 
            this.GreenLabel.AutoSize = true;
            this.GreenLabel.Location = new System.Drawing.Point(552, 224);
            this.GreenLabel.Name = "GreenLabel";
            this.GreenLabel.Size = new System.Drawing.Size(39, 13);
            this.GreenLabel.TabIndex = 6;
            this.GreenLabel.Text = "Green:";
            // 
            // BlueLabel
            // 
            this.BlueLabel.AutoSize = true;
            this.BlueLabel.Location = new System.Drawing.Point(552, 251);
            this.BlueLabel.Name = "BlueLabel";
            this.BlueLabel.Size = new System.Drawing.Size(31, 13);
            this.BlueLabel.TabIndex = 7;
            this.BlueLabel.Text = "Blue:";
            // 
            // showBackColor
            // 
            this.showBackColor.Location = new System.Drawing.Point(490, 198);
            this.showBackColor.Name = "showBackColor";
            this.showBackColor.Size = new System.Drawing.Size(54, 66);
            this.showBackColor.TabIndex = 8;
            this.showBackColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 456);
            this.Controls.Add(this.showBackColor);
            this.Controls.Add(this.BlueLabel);
            this.Controls.Add(this.GreenLabel);
            this.Controls.Add(this.RedLabel);
            this.Controls.Add(this.blueValue);
            this.Controls.Add(this.greenValue);
            this.Controls.Add(this.redValue);
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
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showBackColor)).EndInit();
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
        private System.Windows.Forms.NumericUpDown redValue;
        private System.Windows.Forms.NumericUpDown greenValue;
        private System.Windows.Forms.NumericUpDown blueValue;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Label GreenLabel;
        private System.Windows.Forms.Label BlueLabel;
        private System.Windows.Forms.PictureBox showBackColor;
    }
}

