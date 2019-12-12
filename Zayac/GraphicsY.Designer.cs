namespace Zayac
{
    partial class GraphicsY
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
            this.funcY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.poligonY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gistY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.funcY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poligonY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gistY)).BeginInit();
            this.SuspendLayout();
            // 
            // funcY
            // 
            chartArea1.Name = "ChartArea1";
            this.funcY.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.funcY.Legends.Add(legend1);
            this.funcY.Location = new System.Drawing.Point(451, 157);
            this.funcY.Name = "funcY";
            this.funcY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.funcY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "∑(mᵢ ∙ m)";
            series1.YValuesPerPoint = 4;
            this.funcY.Series.Add(series1);
            this.funcY.Size = new System.Drawing.Size(446, 308);
            this.funcY.TabIndex = 6;
            this.funcY.Text = "chart1";
            // 
            // poligonY
            // 
            chartArea2.Name = "ChartArea1";
            this.poligonY.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.poligonY.Legends.Add(legend2);
            this.poligonY.Location = new System.Drawing.Point(12, 321);
            this.poligonY.Name = "poligonY";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "mᵢ / m";
            this.poligonY.Series.Add(series2);
            this.poligonY.Size = new System.Drawing.Size(388, 240);
            this.poligonY.TabIndex = 5;
            this.poligonY.Text = "chart3";
            // 
            // gistY
            // 
            chartArea3.Name = "ChartArea1";
            this.gistY.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.gistY.Legends.Add(legend3);
            this.gistY.Location = new System.Drawing.Point(12, 46);
            this.gistY.Name = "gistY";
            this.gistY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Legend = "Legend1";
            series3.Name = "mᵢ / (m∙h)";
            series3.YValuesPerPoint = 2;
            this.gistY.Series.Add(series3);
            this.gistY.Size = new System.Drawing.Size(388, 240);
            this.gistY.TabIndex = 4;
            this.gistY.Text = "gistX";
            // 
            // GraphicsY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 572);
            this.Controls.Add(this.funcY);
            this.Controls.Add(this.poligonY);
            this.Controls.Add(this.gistY);
            this.Name = "GraphicsY";
            this.Text = "GraphicsY";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphicsY_FormClosed);
            this.Load += new System.EventHandler(this.GraphicsY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poligonY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gistY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart funcY;
        private System.Windows.Forms.DataVisualization.Charting.Chart poligonY;
        private System.Windows.Forms.DataVisualization.Charting.Chart gistY;
    }
}