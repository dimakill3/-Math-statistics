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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gistX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.poligonX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.funcX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureFunc_X = new System.Windows.Forms.PictureBox();
            this.picturePoligon_X = new System.Windows.Forms.PictureBox();
            this.pictureGist_X = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gistX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poligonX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFunc_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoligon_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGist_X)).BeginInit();
            this.SuspendLayout();
            // 
            // gistX
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "aᵢ";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.Name = "ChartArea1";
            this.gistX.ChartAreas.Add(chartArea1);
            this.gistX.Location = new System.Drawing.Point(48, 44);
            this.gistX.Name = "gistX";
            this.gistX.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.Name = "nᵢ / (n ∙ h)";
            series1.YValuesPerPoint = 2;
            this.gistX.Series.Add(series1);
            this.gistX.Size = new System.Drawing.Size(388, 240);
            this.gistX.TabIndex = 1;
            this.gistX.Text = "gistX";
            // 
            // poligonX
            // 
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.Title = "x˟ᵢ";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.poligonX.ChartAreas.Add(chartArea2);
            this.poligonX.Location = new System.Drawing.Point(48, 320);
            this.poligonX.Name = "poligonX";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "nᵢ / n";
            this.poligonX.Series.Add(series2);
            this.poligonX.Size = new System.Drawing.Size(388, 240);
            this.poligonX.TabIndex = 2;
            this.poligonX.Text = "chart3";
            // 
            // funcX
            // 
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisX.Title = "aᵢ";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.Name = "ChartArea1";
            this.funcX.ChartAreas.Add(chartArea3);
            this.funcX.Location = new System.Drawing.Point(499, 157);
            this.funcX.Name = "funcX";
            this.funcX.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.funcX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.MarkerColor = System.Drawing.Color.Red;
            series3.MarkerSize = 6;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "∑(nᵢ / n)";
            series3.YValuesPerPoint = 4;
            this.funcX.Series.Add(series3);
            this.funcX.Size = new System.Drawing.Size(446, 308);
            this.funcX.TabIndex = 3;
            this.funcX.Text = "chart1";
            // 
            // pictureFunc_X
            // 
            this.pictureFunc_X.Image = global::Zayac.Properties.Resources.Скриншот_13_12_2019_221132;
            this.pictureFunc_X.Location = new System.Drawing.Point(499, 179);
            this.pictureFunc_X.Name = "pictureFunc_X";
            this.pictureFunc_X.Size = new System.Drawing.Size(20, 40);
            this.pictureFunc_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFunc_X.TabIndex = 6;
            this.pictureFunc_X.TabStop = false;
            // 
            // picturePoligon_X
            // 
            this.picturePoligon_X.Image = global::Zayac.Properties.Resources.Скриншот_13_12_2019_220913;
            this.picturePoligon_X.Location = new System.Drawing.Point(48, 334);
            this.picturePoligon_X.Name = "picturePoligon_X";
            this.picturePoligon_X.Size = new System.Drawing.Size(21, 41);
            this.picturePoligon_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePoligon_X.TabIndex = 5;
            this.picturePoligon_X.TabStop = false;
            // 
            // pictureGist_X
            // 
            this.pictureGist_X.Image = global::Zayac.Properties.Resources.Скриншот_13_12_2019_220427;
            this.pictureGist_X.Location = new System.Drawing.Point(26, 63);
            this.pictureGist_X.Name = "pictureGist_X";
            this.pictureGist_X.Size = new System.Drawing.Size(40, 40);
            this.pictureGist_X.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGist_X.TabIndex = 4;
            this.pictureGist_X.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Гистограмма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(203, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Полигон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(564, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Эмпирическая функция распределения Fn(X):";
            // 
            // GraphicsX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(957, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureFunc_X);
            this.Controls.Add(this.picturePoligon_X);
            this.Controls.Add(this.pictureGist_X);
            this.Controls.Add(this.funcX);
            this.Controls.Add(this.poligonX);
            this.Controls.Add(this.gistX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GraphicsX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Графики для группированного ряда X";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphicsX_FormClosed);
            this.Load += new System.EventHandler(this.GraphicsX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gistX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poligonX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFunc_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoligon_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGist_X)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart gistX;
        private System.Windows.Forms.DataVisualization.Charting.Chart poligonX;
        private System.Windows.Forms.DataVisualization.Charting.Chart funcX;
        private System.Windows.Forms.PictureBox pictureGist_X;
        private System.Windows.Forms.PictureBox picturePoligon_X;
        private System.Windows.Forms.PictureBox pictureFunc_X;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}