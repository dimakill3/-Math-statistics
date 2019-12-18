using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zayac
{
    public partial class MainForm : Form
    {

        public static Calculation calc = new Calculation();

        public MainForm()
        {
            InitializeComponent();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raspredX.Rows.Clear();
            raspredY.Rows.Clear();
            var filePath = string.Empty;
            var fileContent = string.Empty;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFile.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFile.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

                String[] Content = fileContent.Split('\n');
                string[] s = new string[2];

                //Чтение из файла
                calc.Calculate(Content);

                for (int i = 0; i < Program.r; i++)
                {
                        raspredX.Rows.Add();
                        raspredY.Rows.Add();

                    raspredX.Rows[i].Cells[0].Value = i + 1;
                    raspredY.Rows[i].Cells[0].Value = i + 1;

                    if (i == Program.r - 1)
                    {
                        raspredX.Rows[i].Cells[1].Value = "[" + calc.inter_X[i].getF() + ";" + calc.inter_X[i].getS() + "]";
                        raspredY.Rows[i].Cells[1].Value = "[" + calc.inter_Y[i].getF() + ";" + calc.inter_Y[i].getS() + "]";
                    }
                    else
                    {
                        raspredX.Rows[i].Cells[1].Value = "[" + calc.inter_X[i].getF() + ";" + calc.inter_X[i].getS() + ")";
                        raspredY.Rows[i].Cells[1].Value = "[" + calc.inter_Y[i].getF() + ";" + calc.inter_Y[i].getS() + ")";

                    }

                    raspredX.Rows[i].Cells[2].Value = calc.inter_X[i].getN();
                    raspredY.Rows[i].Cells[2].Value = calc.inter_Y[i].getN();

                    raspredX.Rows[i].Cells[3].Value = calc.inter_X[i].getA();
                    raspredY.Rows[i].Cells[3].Value = calc.inter_Y[i].getA();

                    raspredX.Rows[i].Cells[4].Value = calc.inter_X[i].getHP();
                    raspredY.Rows[i].Cells[4].Value = calc.inter_Y[i].getHP();

                    raspredX.Rows[i].Cells[5].Value = String.Format("{0:0.000}", calc.inter_X[i].getHG());
                    raspredY.Rows[i].Cells[5].Value = String.Format("{0:0.000}", calc.inter_Y[i].getHG());

                    raspredX.Rows[i].Cells[6].Value = calc.inter_X[i].getFunc();
                    raspredY.Rows[i].Cells[6].Value = calc.inter_Y[i].getFunc();

                }

                //Вывод в общей информации в общую форму
                razmahX.Text = String.Format("{0:0.00}", Convert.ToString(calc.razryv_X));
                razmahY.Text = String.Format("{0:0.00}", Convert.ToString(calc.razryv_Y));
                countInterX.Text = String.Format("{0:0.00}", Convert.ToString(Program.r));
                countInterY.Text = String.Format("{0:0.00}", Convert.ToString(Program.r));
                LenghtInterX.Text = String.Format("{0:0.00}", Convert.ToString(calc.h_X));
                LenghtInterY.Text = String.Format("{0:0.00}", Convert.ToString(calc.h_Y));
                RashPromX.Text = String.Format("{0:0.00}", Convert.ToString(calc.rashirenie_X));
                RashPromY.Text = String.Format("{0:0.00}", Convert.ToString(calc.rashirenie_Y));

                // Корелляционная таблица
                CorrTable.Columns[1].HeaderText = "[" + Convert.ToString(MainForm.calc.inter_Y[0].getF()) + ";" + Convert.ToString(MainForm.calc.inter_Y[0].getS()) + ")";
                CorrTable.Columns[2].HeaderText = "[" + Convert.ToString(MainForm.calc.inter_Y[1].getF()) + ";" + Convert.ToString(MainForm.calc.inter_Y[1].getS()) + ")";
                CorrTable.Columns[3].HeaderText = "[" + Convert.ToString(MainForm.calc.inter_Y[2].getF()) + ";" + Convert.ToString(MainForm.calc.inter_Y[2].getS()) + ")";
                CorrTable.Columns[4].HeaderText = "[" + Convert.ToString(MainForm.calc.inter_Y[3].getF()) + ";" + Convert.ToString(MainForm.calc.inter_Y[3].getS()) + ")";
                CorrTable.Columns[5].HeaderText = "[" + Convert.ToString(MainForm.calc.inter_Y[4].getF()) + ";" + Convert.ToString(MainForm.calc.inter_Y[4].getS()) + ")";
                CorrTable.Columns[6].HeaderText = "[" + Convert.ToString(MainForm.calc.inter_Y[5].getF()) + ";" + Convert.ToString(MainForm.calc.inter_Y[5].getS()) + ")";
                CorrTable.Columns[7].HeaderText = "[" + Convert.ToString(MainForm.calc.inter_Y[6].getF()) + ";" + Convert.ToString(MainForm.calc.inter_Y[6].getS()) + "]";

                CorrTable.Rows.Add();
                CorrTable.Rows[0].Cells[0].Value = "[" + Convert.ToString(MainForm.calc.inter_X[0].getF()) + ";"
                                                       + Convert.ToString(MainForm.calc.inter_X[0].getS()) + ")";
                CorrTable.Rows.Add();
                CorrTable.Rows[1].Cells[0].Value = "[" + Convert.ToString(MainForm.calc.inter_X[1].getF()) + ";"
                                                       + Convert.ToString(MainForm.calc.inter_X[1].getS()) + ")";
                CorrTable.Rows.Add();
                CorrTable.Rows[2].Cells[0].Value = "[" + Convert.ToString(MainForm.calc.inter_X[2].getF()) + ";"
                                                       + Convert.ToString(MainForm.calc.inter_X[2].getS()) + ")";
                CorrTable.Rows.Add();
                CorrTable.Rows[3].Cells[0].Value = "[" + Convert.ToString(MainForm.calc.inter_X[3].getF()) + ";"
                                                       + Convert.ToString(MainForm.calc.inter_X[3].getS()) + ")";
                CorrTable.Rows.Add();
                CorrTable.Rows[4].Cells[0].Value = "[" + Convert.ToString(MainForm.calc.inter_X[4].getF()) + ";"
                                                       + Convert.ToString(MainForm.calc.inter_X[4].getS()) + ")";
                CorrTable.Rows.Add();
                CorrTable.Rows[5].Cells[0].Value = "[" + Convert.ToString(MainForm.calc.inter_X[5].getF()) + ";"
                                                       + Convert.ToString(MainForm.calc.inter_X[5].getS()) + ")";
                CorrTable.Rows.Add();
                CorrTable.Rows[6].Cells[0].Value = "[" + Convert.ToString(MainForm.calc.inter_X[6].getF()) + ";"
                                                       + Convert.ToString(MainForm.calc.inter_X[6].getS()) + "]";
                CorrTable.Rows[7].Cells[0].Value = "nj";

                for (int i = 0; i < Program.N; i++)
                {
                    CorrTable.Rows[MainForm.calc.getInterX(MainForm.calc.masX_No_Sort[i])].Cells[MainForm.calc.getInterY(MainForm.calc.masY_No_Sort[i]) + 1].Value = Convert.ToString(Convert.ToInt32(CorrTable.Rows[MainForm.calc.getInterX(MainForm.calc.masX_No_Sort[i])].Cells[MainForm.calc.getInterY(MainForm.calc.masY_No_Sort[i]) + 1].Value) + 1);
                }

                label1.Text = String.Format("{0:0.00}", calc.getViborKoef(CorrTable));


                //Выбборочные уравнения
                calc.setViborUrav(); 
                if (calc.vibor_urav_const_X > 0)
                    label2.Text = "y = " + String.Format("{0:0.00}", calc.vibor_urav_koef_X) + "x + " + String.Format("{0:0.00}", calc.vibor_urav_const_X);
                else if (calc.vibor_urav_const_X < 0)
                    label2.Text = "y = " + String.Format("{0:0.00}", calc.vibor_urav_koef_X) + "x - " + String.Format("{0:0.00}", Math.Abs(calc.vibor_urav_const_X));
                else
                    label2.Text = "y = " + String.Format("{0:0.00}", calc.vibor_urav_koef_X) + "x";
                ///////\\\\\\\
                if (calc.vibor_urav_const_Y > 0)
                    label3.Text = "x = " + String.Format("{0:0.00}", calc.vibor_urav_koef_Y) + "y + " + String.Format("{0:0.00}", calc.vibor_urav_const_Y);
                else if (calc.vibor_urav_const_Y < 0)
                    label3.Text = "x = " + String.Format("{0:0.00}", calc.vibor_urav_koef_Y) + "y - " + String.Format("{0:0.00}", Math.Abs(calc.vibor_urav_const_Y));
                else
                    label3.Text = "x = " + String.Format("{0:0.00}", calc.vibor_urav_koef_Y) + "y";


                //Координаты точки пересечения
                double peres_X = calc.all_average_X;
                double peres_Y = calc.all_average_Y;

                // Получаем нужные интервалы для функции
                double xX0 = peres_X - 30;
                double xX1 = peres_X + 30;
                double yX0 = calc.vibor_urav_koef_X * xX0 + calc.vibor_urav_const_X;
                double yX1 = calc.vibor_urav_koef_X * xX1 + calc.vibor_urav_const_X;


                double xY0 = peres_X - 30;
                double xY1 = peres_X + 30;
                double yY0 = (xY0 - calc.vibor_urav_const_Y) / calc.vibor_urav_koef_Y;
                double yY1 = (xY1 - calc.vibor_urav_const_Y) / calc.vibor_urav_koef_Y;


                chart1.Series[0].BorderWidth = 1;
                chart1.Series[0].Points.AddXY(xX0, yX0);
                chart1.Series[0].Points.AddXY(xX1, yX1);

                chart1.Series[1].BorderWidth = 1;
                chart1.Series[1].Color = Color.Gray;
                chart1.Series[1].Points.AddXY(xY0, yY0);
                chart1.Series[1].Points.AddXY(xY1, yY1);


                chart1.Series[2].BorderWidth = 1;

                for (int i = 0; i < Program.N - 1; i++)
                    chart1.Series[2].Points.AddXY(calc.masX_No_Sort[i], calc.masY_No_Sort[i]);



                if (calc.vibor_urav_const_X > 0)
                    chart1.Series[0].LegendText = "y = " + String.Format("{0:0.00}", calc.vibor_urav_koef_X) + "x + " + String.Format("{0:0.00}", calc.vibor_urav_const_X);
                else if (calc.vibor_urav_const_X < 0)
                    chart1.Series[0].LegendText = "y = " + String.Format("{0:0.00}", calc.vibor_urav_koef_X) + "x - " + String.Format("{0:0.00}", Math.Abs(calc.vibor_urav_const_X));
                else
                    chart1.Series[0].LegendText = "y = " + String.Format("{0:0.00}", calc.vibor_urav_koef_X) + "x";
                ///////\\\\\\\
                if (calc.vibor_urav_const_Y > 0)
                    chart1.Series[1].LegendText = "x = " + String.Format("{0:0.00}", calc.vibor_urav_koef_Y) + "y + " + String.Format("{0:0.00}", calc.vibor_urav_const_Y);
                else if (calc.vibor_urav_const_Y < 0)
                    chart1.Series[1].LegendText = "x = " + String.Format("{0:0.00}", calc.vibor_urav_koef_Y) + "y - " + String.Format("{0:0.00}", Math.Abs(calc.vibor_urav_const_Y));
                else
                    chart1.Series[1].LegendText = "x = " + String.Format("{0:0.00}", calc.vibor_urav_koef_Y) + "y";



            }
        }

        private void LenghtInterX_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToMarksX_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormMarksX)
            {
                GlobalVars.FormMarksX = !GlobalVars.FormMarksX;
                Marks_X MX = new Marks_X();
                MX.Show();
            }
        }

        private void ToMarksY_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormMarksY)
            {
                GlobalVars.FormMarksY = !GlobalVars.FormMarksY;
                Marks_Y MY = new Marks_Y();
                MY.Show();
            }
        }

        private void ToGraphicsY_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormGraphicsY)
            {
                GlobalVars.FormGraphicsY = !GlobalVars.FormGraphicsY;
                GraphicsY GY = new GraphicsY();
                GY.Show();
            }
        }

        private void ToGraphicsX_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormGraphicsX)
            {
                GlobalVars.FormGraphicsX = !GlobalVars.FormGraphicsX;
                GraphicsX GX = new GraphicsX();
                GX.Show();
            }
        }

        private void RazmahY_TextChanged(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {

        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            CustomToolTip[] tip = new CustomToolTip[10];
            for (int i = 0; i < 10; i++)
            {
                tip[i] = new CustomToolTip();
                tip[i].AutomaticDelay = 1000;
            }
            tip[0].SetCustomToolTip(this.labelRash, "расширение_X.png");
            tip[1].SetCustomToolTip(this.labelLenghtInter, "длина_интервала_Y.png");
            tip[2].SetCustomToolTip(this.labelRashY, "расширение_Y.png");
            tip[3].SetCustomToolTip(this.labelLenghtInterY, "длина_интервала_X.png");
            tip[4].SetCustomToolTip(this.pictureBox1, "vibor_koef.png");


        }
        /*
        static void SetRoundedShape(CustomToolTip control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.getImageWidth() - radius, 0);
            path.AddArc(control.getImageWidth() - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.getImageWidth(), radius, control.getImageWidth(), control.getImageHeight() - radius);
            path.AddArc(control.getImageWidth() - radius, control.getImageHeight() - radius, radius, radius, 0, 90);
            path.AddLine(control.getImageWidth() - radius, control.getImageHeight(), radius, control.getImageHeight());
            path.AddArc(0, control.getImageHeight() - radius, radius, radius, 90, 90);
            path.AddLine(0, control.getImageHeight() - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            //control.Region = new Region(path);
        }
        */

        private void RashPromX_TextChanged(object sender, EventArgs e)
        {

        }

        private void RashPromX_MouseHover(object sender, EventArgs e)
        {

        }

        private void ToMarksX_MouseHover(object sender, EventArgs e)
        {
        }

        private void RaspredX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HipotesyX_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormHipotesyX)
            {
                GlobalVars.FormHipotesyX = !GlobalVars.FormHipotesyX;
                HipotesyX HX = new HipotesyX();
                HX.Show();
            }
        }

        private void HipotesyY_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormHipotesyY)
            {
                GlobalVars.FormHipotesyY = !GlobalVars.FormHipotesyY;
                HipotesyY HY = new HipotesyY();
                HY.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormDoverX)
            {
                GlobalVars.FormDoverX = !GlobalVars.FormDoverX;
                HipotesyY DX = new HipotesyY();
                DX.Show();
            }
        }

        private void Button_Dover_Y_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button_doverX_Click(object sender, EventArgs e)
        {

        }

        private void ButtonDoverX_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormDoverX)
            {
                GlobalVars.FormDoverX = !GlobalVars.FormDoverX;
                Confidence DX = new Confidence();
                DX.Show();
            }

        }

        private void ButtonDoverY_Click(object sender, EventArgs e)
        {
            if (!GlobalVars.FormDoverY)
            {
                GlobalVars.FormDoverY = !GlobalVars.FormDoverY;
                ConfidenceY DY = new ConfidenceY();
                DY.Show();
            }

        }



        private void CorrTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Vibor_urav_Paint(object sender, PaintEventArgs e)
        {
            //
            //ГРАФИК>
            //

            Graphics graph = e.Graphics;
            //Карандашы
            Pen bold_pen = new Pen(Brushes.Black, 3);
            Pen middle_pen = new Pen(Brushes.Black, 2);
            Pen middle_pen_red = new Pen(Brushes.Red, 2);
            Pen think_pen = new Pen(Brushes.Black, 1);

            //Масштаб
            float scale = calc.Height / calc.grids;

            //начало координат
            Point X0Y0 = new Point(0, 0);

            //Ось Х и Y
            graph.DrawLine(bold_pen, new PointF(calc.pre_Width, calc.Height - calc.Height / calc.grids), new PointF(calc.Width + calc.pre_Width, calc.Height - calc.Height / calc.grids));
            graph.DrawLine(bold_pen, new PointF(calc.Width / calc.grids + calc.pre_Width, 0), new PointF(calc.Width / calc.grids + calc.pre_Width, calc.Height));

            for (int i = 0; i <= calc.grids; i++)
            {
                graph.DrawLine(think_pen, new PointF(calc.pre_Width, i * scale), new PointF(calc.Width + calc.pre_Width, i * scale));
            }

            for (int i = 0; i <= calc.grids; i++)
            {
                graph.DrawLine(think_pen, new PointF(i * scale + calc.pre_Width, 0), new PointF(i * scale + calc.pre_Width, calc.Height));
            }
            //
            //
            //Координаты точки пересечения
            float peres_X = calc.getCoordX(Convert.ToSingle(calc.all_average_X));
            float peres_Y = calc.getCoordY(Convert.ToSingle(calc.all_average_Y));

            // Получаем нужные интервалы для функции
            float xX0 = peres_X - 150;
            float xX1 = peres_X + 150;
            float yX0 = calc.Height - Convert.ToSingle(calc.vibor_urav_koef_X * xX0 + calc.vibor_urav_const_X - calc.pre_Width - calc.size_grids);
            float yX1 = calc.Height - Convert.ToSingle(calc.vibor_urav_koef_X * xX1 + calc.vibor_urav_const_X - calc.pre_Width - calc.size_grids);


            float xY0 = peres_X - 150;
            float xY1 = peres_X + 150;
            float yY0 = calc.Height - Convert.ToSingle((xY0 - calc.vibor_urav_const_Y - calc.pre_Width - calc.size_grids) / calc.vibor_urav_koef_Y);
            float yY1 = calc.Height - Convert.ToSingle((xY1 - calc.vibor_urav_const_Y - calc.pre_Width - calc.size_grids) / calc.vibor_urav_koef_Y);


            PointF pointX1 = new PointF(xX0, yX0);
            PointF pointX2 = new PointF(xX1, yX1);

            PointF pointY1 = new PointF(xY0, yY0);
            PointF pointY2 = new PointF(xY1, yY1);

            graph.DrawLine(middle_pen, pointX1, pointX2);
            graph.DrawLine(middle_pen_red, pointY1, pointY2);

            for (int i = 0; i < Program.N - 1; i++)
            {
                graph.DrawRectangle(bold_pen, calc.getCoordX(Convert.ToSingle(calc.masX_No_Sort[i])), calc.getCoordY(Convert.ToSingle(calc.masY_No_Sort[i])) , 1, 1);
            }

            /*
            Label labelqqq = new Label();
            labelqqq.Location = new Point(200, 200);
            labelqqq.Text = "labelqqq";
            vibor_urav.Controls.Add(labelqqq);
            */
        }
    }
}
