namespace Zayac
{
    partial class GraphicsX
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gistX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.poligonX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.funcX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.gistX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poligonX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcX)).BeginInit();
            this.SuspendLayout();
            // 
            // gistX
            // 
            chartArea1.Name = "ChartArea1";
            this.gistX.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gistX.Legends.Add(legend1);
            this.gistX.Location = new System.Drawing.Point(12, 44);
            this.gistX.Name = "gistX";
            this.gistX.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.Name = "nᵢ / (n∙h)";
            series1.YValuesPerPoint = 2;
            this.gistX.Series.Add(series1);
            this.gistX.Size = new System.Drawing.Size(388, 240);
            this.gistX.TabIndex = 1;
            this.gistX.Text = "gistX";
            // 
            // poligonX
            // 
            chartArea2.Name = "ChartArea1";
            this.poligonX.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.poligonX.Legends.Add(legend2);
            this.poligonX.Location = new System.Drawing.Point(12, 320);
            this.poligonX.Name = "poligonX";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "nᵢ / n";
            this.poligonX.Series.Add(series2);
            this.poligonX.Size = new System.Drawing.Size(388, 240);
            this.poligonX.TabIndex = 2;
            this.poligonX.Text = "chart3";
            // 
            // funcX
            // 
            chartArea3.Name = "ChartArea1";
            this.funcX.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.funcX.Legends.Add(legend3);
            this.funcX.Location = new System.Drawing.Point(451, 157);
            this.funcX.Name = "funcX";
            this.funcX.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.funcX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "∑(nᵢ ∙ n)";
            series3.YValuesPerPoint = 4;
            this.funcX.Series.Add(series3);
            this.funcX.Size = new System.Drawing.Size(446, 308);
            this.funcX.TabIndex = 3;
            this.funcX.Text = "chart1";
            // 
            // GraphicsX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 572);
            this.Controls.Add(this.funcX);
            this.Controls.Add(this.poligonX);
            this.Controls.Add(this.gistX);
            this.Name = "GraphicsX";
            this.Text = "GraphicsX";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphicsX_FormClosed);
            this.Load += new System.EventHandler(this.GraphicsX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gistX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poligonX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart gistX;
        private System.Windows.Forms.DataVisualization.Charting.Chart poligonX;
        private System.Windows.Forms.DataVisualization.Charting.Chart funcX;
    }
}