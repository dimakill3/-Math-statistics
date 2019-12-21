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
using System.Data.OleDb;
using Word = Microsoft.Office.Interop.Excel;

namespace Zayac
{
    public partial class MainForm : Form
    {

        public static Calculation calc;
        public static double[] masX1 = new double[Program.N];
        public static double[] masY1 = new double[Program.N];
        public static double[] masX_temp = new double[Program.N];
        public static double[] masY_temp = new double[Program.N];


        public MainForm()
        {
            InitializeComponent();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raspredX.DataSource = null;
            raspredX.Rows.Clear();

            raspredY.DataSource = null;
            raspredY.Rows.Clear();

            CorrTable.DataSource = null;
            CorrTable.Rows.Clear();

            mainTable.DataSource = null;
            mainTable.Rows.Clear();

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();


            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Taблицы Excel'2007 (*.xlsx)|*.xlsx| Таблицы Excel'97 (*.xls)|*.xls|Текстовый документ (*.txt)|*.txt|All files (*.*)|*.*";
            opf.RestoreDirectory = false;

            if (opf.ShowDialog() == DialogResult.OK)
            {
                string txtPath = opf.FileName;
                string ext = Path.GetExtension(txtPath);
                if (ext == ".xlsx" || ext == ".xls")
                {

                    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
                    Microsoft.Office.Interop.Excel.Range ExcelRange;

                    try
                    {
                        string str;

                        ExcelWorkBook = ExcelApp.Workbooks.Open(txtPath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                        ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                        ExcelRange = ExcelWorkSheet.UsedRange;

                        int k = 0;
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < Program.N / 5; j++, k++)
                            {
                                if (i == 0) mainTable.Rows.Add();
                                str = Convert.ToString((ExcelRange.Cells[k + 1, 1] as Microsoft.Office.Interop.Excel.Range).Value2);
                                mainTable.Rows[j].Cells[2 * i].Value = str;
                                masX1[k] = Convert.ToDouble(str);
                                masX_temp[k] = Convert.ToDouble(str);

                                str = Convert.ToString((ExcelRange.Cells[k + 1, 2] as Microsoft.Office.Interop.Excel.Range).Value2);
                                mainTable.Rows[j].Cells[2 * i + 1].Value = str;
                                masY1[k] = Convert.ToDouble(str);
                                masY_temp[k] = Convert.ToDouble(str);

                            }
                        }
                    }
                    catch
                    {

                    }
                }
                else if (ext == ".txt")
                {
                    String[] Content = File.ReadAllText(opf.FileName).Split('\n');

                    string[] s = new string[2];

                    for (int i = 0; i < Content.Length && i < Program.N; i++)
                    {
                        s = Content[i].Split(' ');

                        //Массив для веса
                        masX1[i] = Convert.ToDouble(s[0]);
                        masX_temp[i] = Convert.ToDouble(s[0]);

                        //Массив для роста
                        masY1[i] = Convert.ToDouble(s[1]);
                        masY_temp[i] = Convert.ToDouble(s[1]);

                    }


                    int k = 0;
                    for (int i = 0; i < Program.N / 5; i += 2)
                    {
                        for (int j = 0; j < Program.N / 5; j++, k++)
                        {
                            if (i == 0) mainTable.Rows.Add();
                            mainTable.Rows[j].Cells[i].Value = Convert.ToString(masX1[k]);
                            mainTable.Rows[j].Cells[i + 1].Value = Convert.ToString(masY1[k]);

                        }
                    }

                }

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
            tip[5].SetCustomToolTip(pictureBox2, "info_X.png");
            tip[6].SetCustomToolTip(pictureBox3, "info_Y.png");
            tip[7].SetCustomToolTip(pictureBox4, "vibor_urav.png");

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

        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            ToMarksX.Enabled = true;
            ToGraphicsX.Enabled = true;
            HipotesyX.Enabled = true;
            buttonDoverX.Enabled = true;

            ToMarksY.Enabled = true;
            ToGraphicsY.Enabled = true;
            HipotesyY.Enabled = true;
            buttonDoverY.Enabled = true;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            raspredX.DataSource = null;
            raspredX.Rows.Clear();

            raspredY.DataSource = null;
            raspredY.Rows.Clear();

            CorrTable.DataSource = null;
            CorrTable.Rows.Clear();

            mainTable.DataSource = null;
            mainTable.Rows.Clear();

            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
        }

        private void GoToCalc_Click(object sender, EventArgs e)
        {
            if (mainTable.RowCount == 10)
            {
                for (int i = 0; i < Program.N / 5; i++)
                    for (int j = 0; j < mainTable.ColumnCount; j++)
                    {
                        if (Convert.ToString(mainTable.Rows[i].Cells[j].Value) == "")
                        {
                            MessageBox.Show("Имеются пустые значения\nХотите продолдить?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

                        }
                    }
            } else
                MessageBox.Show("Таблица не заполнена\nЗаполните таблицу", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

            ToMarksX.Enabled = true;
            ToGraphicsX.Enabled = true;
            HipotesyX.Enabled = true;
            buttonDoverX.Enabled = true;

            ToMarksY.Enabled = true;
            ToGraphicsY.Enabled = true;
            HipotesyY.Enabled = true;
            buttonDoverY.Enabled = true;

            calc = new Calculation();
            calc.setHiA(Convert.ToDouble(hipoteza_a.Text));
            calc.Calculate();

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
            X_min.Text = String.Format("{0:0.00}", Convert.ToString(calc.min_X));
            X_max.Text = String.Format("{0:0.00}", Convert.ToString(calc.max_X));
            Ymin.Text = String.Format("{0:0.00}", Convert.ToString(calc.min_Y));
            Ymax.Text = String.Format("{0:0.00}", Convert.ToString(calc.max_Y));
            razmahX.Text = String.Format("{0:0.00}", Convert.ToString(calc.razryv_X));
            razmahY.Text = String.Format("{0:0.00}", Convert.ToString(calc.razryv_Y));
            countInterX.Text = String.Format("{0:0.00}", Convert.ToString(Program.r));
            countInterY.Text = String.Format("{0:0.00}", Convert.ToString(Program.r));
            LenghtInterX.Text = String.Format("{0:0.00}", Convert.ToString(calc.h_X));
            LenghtInterY.Text = String.Format("{0:0.00}", Convert.ToString(calc.h_Y));
            RashPromX.Text = String.Format("{0:0.00}", Convert.ToString(calc.rashirenie_X));
            RashPromY.Text = String.Format("{0:0.00}", Convert.ToString(calc.rashirenie_Y));

            // Корелляционная таблица
            CorrTable.Columns[1].HeaderText = "[" + Convert.ToString(calc.inter_Y[0].getF()) + ";" + Convert.ToString(calc.inter_Y[0].getS()) + ")";
            CorrTable.Columns[2].HeaderText = "[" + Convert.ToString(calc.inter_Y[1].getF()) + ";" + Convert.ToString(calc.inter_Y[1].getS()) + ")";
            CorrTable.Columns[3].HeaderText = "[" + Convert.ToString(calc.inter_Y[2].getF()) + ";" + Convert.ToString(calc.inter_Y[2].getS()) + ")";
            CorrTable.Columns[4].HeaderText = "[" + Convert.ToString(calc.inter_Y[3].getF()) + ";" + Convert.ToString(calc.inter_Y[3].getS()) + ")";
            CorrTable.Columns[5].HeaderText = "[" + Convert.ToString(calc.inter_Y[4].getF()) + ";" + Convert.ToString(calc.inter_Y[4].getS()) + ")";
            CorrTable.Columns[6].HeaderText = "[" + Convert.ToString(calc.inter_Y[5].getF()) + ";" + Convert.ToString(calc.inter_Y[5].getS()) + ")";
            CorrTable.Columns[7].HeaderText = "[" + Convert.ToString(calc.inter_Y[6].getF()) + ";" + Convert.ToString(calc.inter_Y[6].getS()) + "]";

            CorrTable.Rows.Add();
            CorrTable.Rows[0].Cells[0].Value = "[" + Convert.ToString(calc.inter_X[0].getF()) + ";"
                                                   + Convert.ToString(calc.inter_X[0].getS()) + ")";
            CorrTable.Rows.Add();
            CorrTable.Rows[1].Cells[0].Value = "[" + Convert.ToString(calc.inter_X[1].getF()) + ";"
                                                   + Convert.ToString(calc.inter_X[1].getS()) + ")";
            CorrTable.Rows.Add();
            CorrTable.Rows[2].Cells[0].Value = "[" + Convert.ToString(calc.inter_X[2].getF()) + ";"
                                                   + Convert.ToString(calc.inter_X[2].getS()) + ")";
            CorrTable.Rows.Add();
            CorrTable.Rows[3].Cells[0].Value = "[" + Convert.ToString(calc.inter_X[3].getF()) + ";"
                                                   + Convert.ToString(calc.inter_X[3].getS()) + ")";
            CorrTable.Rows.Add();
            CorrTable.Rows[4].Cells[0].Value = "[" + Convert.ToString(calc.inter_X[4].getF()) + ";"
                                                   + Convert.ToString(calc.inter_X[4].getS()) + ")";
            CorrTable.Rows.Add();
            CorrTable.Rows[5].Cells[0].Value = "[" + Convert.ToString(calc.inter_X[5].getF()) + ";"
                                                   + Convert.ToString(calc.inter_X[5].getS()) + ")";
            CorrTable.Rows.Add();
            CorrTable.Rows[6].Cells[0].Value = "[" + Convert.ToString(calc.inter_X[6].getF()) + ";"
                                                   + Convert.ToString(calc.inter_X[6].getS()) + "]";
            CorrTable.Rows.Add();
            CorrTable.Rows[7].Cells[0].Value = "nj";

            for (int i = 0; i < Program.N; i++)
            {
                CorrTable.Rows[calc.getInterX(masX1[i])].Cells[calc.getInterY(masY1[i]) + 1].Value = Convert.ToString(Convert.ToInt32(CorrTable.Rows[calc.getInterX(masX1[i])].Cells[calc.getInterY(masY1[i]) + 1].Value) + 1);
            }

            label1.Text = String.Format("{0:0.00}", calc.getViborKoef(CorrTable));


            //Выбборочные уравнения
            calc.setViborUrav();

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


            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 10;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 10;

            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = Math.Floor(xX0);
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = Math.Floor(yX0);


            chart1.Series[0].Points.AddXY(xX0, yX0);
            chart1.Series[0].Points.AddXY(xX1, yX1);

            chart1.Series[1].Color = Color.Gray;
            chart1.Series[1].Points.AddXY(xY0, yY0);
            chart1.Series[1].Points.AddXY(xY1, yY1);

            chart1.Series[3].Points.AddXY(Math.Floor(xX0), peres_Y);
            chart1.Series[3].Points.AddXY(peres_X, Math.Floor(yX0));
            // chart1.Series[3].Points.AddXY(peres_X, peres_Y);


            chart1.Series[2].BorderWidth = 1;

            for (int i = 0; i < Program.N - 1; i++)
                chart1.Series[2].Points.AddXY(masX1[i], masY1[i]);



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

            double qqq = (calc.sred_kvadr_X * calc.sred_kvadr_Y) / (calc.dispers_X + calc.dispers_Y) * (1 - Math.Pow(calc.getViborKoef(CorrTable), 2)) / (calc.getViborKoef(CorrTable));
            label6.Text = Convert.ToString(String.Format("{0:0.00}", qqq));
            label8.Text = Convert.ToString(String.Format("{0:0.00}", (Math.Atan(qqq) * 180) / Math.PI));
            label11.Text = "(" + Convert.ToString(calc.all_average_X) + " ; " + Convert.ToString(calc.all_average_Y) + ")";



            XandY.SelectedIndex = 1;
        }
    }
}
