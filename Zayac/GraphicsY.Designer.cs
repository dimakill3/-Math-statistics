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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.funcY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.poligonY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gistY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureFunc_Y = new System.Windows.Forms.PictureBox();
            this.picturePoligon_Y = new System.Windows.Forms.PictureBox();
            this.pictureGist_Y = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poligonY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gistY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFunc_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoligon_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGist_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // funcY
            // 
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.LineWidth = 2;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "bᵢ";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY.LineWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.funcY.ChartAreas.Add(chartArea1);
            this.funcY.Location = new System.Drawing.Point(499, 157);
            this.funcY.Name = "funcY";
            this.funcY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.funcY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.MarkerSize = 6;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "∑(mᵢ / n)";
            series1.YValuesPerPoint = 4;
            this.funcY.Series.Add(series1);
            this.funcY.Size = new System.Drawing.Size(446, 308);
            this.funcY.TabIndex = 6;
            this.funcY.Text = "chart1";
            // 
            // poligonY
            // 
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.Title = "y˟ᵢ";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.Name = "ChartArea1";
            this.poligonY.ChartAreas.Add(chartArea2);
            this.poligonY.Location = new System.Drawing.Point(48, 320);
            this.poligonY.Name = "poligonY";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.MarkerSize = 6;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "mᵢ / n";
            this.poligonY.Series.Add(series2);
            this.poligonY.Size = new System.Drawing.Size(388, 240);
            this.poligonY.TabIndex = 5;
            this.poligonY.Text = "chart3";
            // 
            // gistY
            // 
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisX.LineWidth = 2;
            chartArea3.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisX.Title = "bᵢ";
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.LineWidth = 2;
            chartArea3.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea3.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea3.Name = "ChartArea1";
            this.gistY.ChartAreas.Add(chartArea3);
            this.gistY.Location = new System.Drawing.Point(48, 44);
            this.gistY.Name = "gistY";
            this.gistY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series3.ChartArea = "ChartArea1";
            series3.CustomProperties = "DrawingStyle=Emboss, PointWidth=1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series3.Name = "mᵢ / (n ∙ h)";
            series3.YValuesPerPoint = 2;
            this.gistY.Series.Add(series3);
            this.gistY.Size = new System.Drawing.Size(388, 240);
            this.gistY.TabIndex = 4;
            this.gistY.Text = "gistX";
            // 
            // pictureFunc_Y
            // 
            this.pictureFunc_Y.Image = global::Zayac.Properties.Resources.Скриншот_13_12_2019_221408;
            this.pictureFunc_Y.Location = new System.Drawing.Point(499, 179);
            this.pictureFunc_Y.Name = "pictureFunc_Y";
            this.pictureFunc_Y.Size = new System.Drawing.Size(25, 40);
            this.pictureFunc_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFunc_Y.TabIndex = 9;
            this.pictureFunc_Y.TabStop = false;
            // 
            // picturePoligon_Y
            // 
            this.picturePoligon_Y.Image = global::Zayac.Properties.Resources.Скриншот_13_12_2019_221422;
            this.picturePoligon_Y.Location = new System.Drawing.Point(48, 334);
            this.picturePoligon_Y.Name = "picturePoligon_Y";
            this.picturePoligon_Y.Size = new System.Drawing.Size(25, 45);
            this.picturePoligon_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePoligon_Y.TabIndex = 8;
            this.picturePoligon_Y.TabStop = false;
            // 
            // pictureGist_Y
            // 
            this.pictureGist_Y.Image = global::Zayac.Properties.Resources.Скриншот_13_12_2019_221531;
            this.pictureGist_Y.Location = new System.Drawing.Point(26, 63);
            this.pictureGist_Y.Name = "pictureGist_Y";
            this.pictureGist_Y.Size = new System.Drawing.Size(40, 45);
            this.pictureGist_Y.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGist_Y.TabIndex = 7;
            this.pictureGist_Y.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Гистограмма:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(203, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Полигон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(564, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Эмпирическая функция распределения Fn(Y):";
            // 
            // GraphicsY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(957, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureFunc_Y);
            this.Controls.Add(this.picturePoligon_Y);
            this.Controls.Add(this.pictureGist_Y);
            this.Controls.Add(this.funcY);
            this.Controls.Add(this.poligonY);
            this.Controls.Add(this.gistY);
            this.Name = "GraphicsY";
            this.Text = "Графики для группированного ряда Y";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GraphicsY_FormClosed);
            this.Load += new System.EventHandler(this.GraphicsY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poligonY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gistY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFunc_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoligon_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGist_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart funcY;
        private System.Windows.Forms.DataVisualization.Charting.Chart poligonY;
        private System.Windows.Forms.DataVisualization.Charting.Chart gistY;
        private System.Windows.Forms.PictureBox pictureGist_Y;
        private System.Windows.Forms.PictureBox picturePoligon_Y;
        private System.Windows.Forms.PictureBox pictureFunc_Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}