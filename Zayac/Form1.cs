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

                    raspredX.Rows[i].Cells[5].Value = String.Format("{0:0.0000}", calc.inter_X[i].getHG());
                    raspredY.Rows[i].Cells[5].Value = String.Format("{0:0.0000}", calc.inter_Y[i].getHG());

                    raspredX.Rows[i].Cells[6].Value = calc.inter_X[i].getFunc();
                    raspredY.Rows[i].Cells[6].Value = calc.inter_Y[i].getFunc();

                }

                //Вывод в общей информации в общую форму
                razmahX.Text = String.Format("{0:0.0000}", Convert.ToString(calc.razryv_X));
                razmahY.Text = String.Format("{0:0.0000}", Convert.ToString(calc.razryv_Y));
                countInterX.Text = String.Format("{0:0.0000}", Convert.ToString(Program.r));
                countInterY.Text = String.Format("{0:0.0000}", Convert.ToString(Program.r));
                LenghtInterX.Text = String.Format("{0:0.0000}", Convert.ToString(calc.h_X));
                LenghtInterY.Text = String.Format("{0:0.0000}", Convert.ToString(calc.h_Y));
                RashPromX.Text = String.Format("{0:0.0000}", Convert.ToString(calc.rashirenie_X));
                RashPromY.Text = String.Format("{0:0.0000}", Convert.ToString(calc.rashirenie_Y));



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
            CustomToolTip tip = new CustomToolTip();
            tip.AutomaticDelay = 1000;
            
            tip.SetCustomToolTip(this.ToGraphicsX, "b.png");

            tip.SetCustomToolTip(this.ToMarksX, "b.png");

            tip.SetCustomToolTip(this.labelRazmah, "b.png");

            tip.SetCustomToolTip(this.labelKolVoInter, "b.png");

            tip.SetCustomToolTip(this.labelLenghtInter, "b.png");

            tip.SetCustomToolTip(this.labelRash, "b.png");

            tip.SetCustomToolTip(this.labelRazmahY, "b.png");

            tip.SetCustomToolTip(this.labelKolVoInterY, "b.png");

            tip.SetCustomToolTip(this.labelLenghtInterY, "b.png");

            tip.SetCustomToolTip(this.labelRashY, "b.png");

            tip.SetCustomToolTip(this.ToGraphicsY, "b.png");

            tip.SetCustomToolTip(this.ToMarksY, "b.png");
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
    }
}
