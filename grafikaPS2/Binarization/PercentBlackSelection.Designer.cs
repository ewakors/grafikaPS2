namespace grafikaPS2.Binarization
{
    partial class PercentBlackSelection
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
            this.percentBlack = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // percentBlack
            // 
            this.percentBlack.Location = new System.Drawing.Point(39, 53);
            this.percentBlack.Name = "percentBlack";
            this.percentBlack.Size = new System.Drawing.Size(100, 20);
            this.percentBlack.TabIndex = 0;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(170, 53);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // PercentBlackSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 121);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.percentBlack);
            this.Name = "PercentBlackSelection";
            this.Text = "PercentBlackSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox percentBlack;
        private System.Windows.Forms.Button ok;
    }
}