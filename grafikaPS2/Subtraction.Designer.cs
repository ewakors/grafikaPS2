namespace grafikaPS2
{
    partial class Subtraction
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
            this.subtractTextBox = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subtractTextBox
            // 
            this.subtractTextBox.Location = new System.Drawing.Point(35, 47);
            this.subtractTextBox.Name = "subtractTextBox";
            this.subtractTextBox.Size = new System.Drawing.Size(73, 20);
            this.subtractTextBox.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(132, 47);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Subtraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 107);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.subtractTextBox);
            this.Name = "Subtraction";
            this.Text = "Subtraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subtractTextBox;
        private System.Windows.Forms.Button ok;
    }
}