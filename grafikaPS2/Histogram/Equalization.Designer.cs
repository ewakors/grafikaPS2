namespace grafikaPS2
{
    partial class Equalization
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartEquaization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartEquaization)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEquaization
            // 
            this.chartEquaization.BackColor = System.Drawing.Color.LemonChiffon;
            chartArea1.Name = "ChartArea1";
            this.chartEquaization.ChartAreas.Add(chartArea1);
            this.chartEquaization.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartEquaization.Legends.Add(legend1);
            this.chartEquaization.Location = new System.Drawing.Point(0, 0);
            this.chartEquaization.Name = "chartEquaization";
            this.chartEquaization.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.ForestGreen;
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.DodgerBlue;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.chartEquaization.Series.Add(series1);
            this.chartEquaization.Series.Add(series2);
            this.chartEquaization.Series.Add(series3);
            this.chartEquaization.Size = new System.Drawing.Size(502, 319);
            this.chartEquaization.TabIndex = 52;
            this.chartEquaization.Text = "chartEquaization";
            // 
            // Equalization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 319);
            this.Controls.Add(this.chartEquaization);
            this.Name = "Equalization";
            this.Text = "Equalization";
            ((System.ComponentModel.ISupportInitialize)(this.chartEquaization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEquaization;
    }
}