namespace imgProc1
{
    partial class GSHistogram
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
            this.chartGSHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGSHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGSHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGSHistogram.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartGSHistogram.Legends.Add(legend1);
            this.chartGSHistogram.Location = new System.Drawing.Point(12, 12);
            this.chartGSHistogram.Name = "chartGSHistogram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGSHistogram.Series.Add(series1);
            this.chartGSHistogram.Size = new System.Drawing.Size(514, 284);
            this.chartGSHistogram.TabIndex = 0;
            this.chartGSHistogram.Text = "chartGSHistogram";
            // 
            // GSHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 305);
            this.Controls.Add(this.chartGSHistogram);
            this.Name = "GSHistogram";
            this.Text = "GSHistogram";
            ((System.ComponentModel.ISupportInitialize)(this.chartGSHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartGSHistogram;
    }
}