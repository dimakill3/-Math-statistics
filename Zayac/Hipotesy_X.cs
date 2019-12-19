using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zayac
{
    public partial class HipotesyX : Form
    {
        public HipotesyX()
        {
            InitializeComponent();
        }

        private void HipotesyX_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormHipotesyX = false;
        }

        private void Hipotesy_X_Load(object sender, EventArgs e)
        {

            CustomToolTip[] tip = new CustomToolTip[10];
            for (int i = 0; i < 10; i++)
                tip[i] = new CustomToolTip();

            tip[0].SetCustomToolTip(pictureBox5, "hi_kvadr.png");
            tip[1].SetCustomToolTip(pictureBox4, "hi_kvadr.png");
            tip[2].SetCustomToolTip(pictureBox2, "kvantil.png");
            tip[3].SetCustomToolTip(pictureBox6, "laplas_X.png");
            tip[4].SetCustomToolTip(label1, "m_label.png");
            tip[5].SetCustomToolTip(label7, "a_label.png");
            tip[6].SetCustomToolTip(label2, "mk1_label.png");

            for (int i = 0; i < Program.r ; i++)
            {
                raspredX.Rows.Add();

                raspredX.Rows[i].Cells[0].Value = i + 1;


                if (i == Program.r - 1)
                {
                    raspredX.Rows[i].Cells[1].Value = "[" + MainForm.calc.inter_X[i].getF() + ";" + "+∞" + ")";
                }
                else
                    if (i == 0)
                {
                    raspredX.Rows[i].Cells[1].Value = "(" + "-∞" + ";" + MainForm.calc.inter_X[i].getS() + ")";
                }
                else
                    raspredX.Rows[i].Cells[1].Value = "[" + MainForm.calc.inter_X[i].getF() + ";" + MainForm.calc.inter_X[i].getS() + ")";

                raspredX.Rows[i].Cells[2].Value = MainForm.calc.inter_X[i].getN();

                raspredX.Rows[i].Cells[3].Value = String.Format("{0:0.00}", MainForm.calc.norm_vel_X[i]);

                raspredX.Rows[i].Cells[4].Value = String.Format("{0:0.000}", MainForm.calc.form_lap_X[i]);

                raspredX.Rows[i].Cells[5].Value = String.Format("{0:0.000}", MainForm.calc.ver_sob_X[i]);

                raspredX.Rows[i].Cells[6].Value = String.Format("{0:0.00}", MainForm.calc.teor_chast_X[i]);
            }


            double all_n = 0, all_teor_vel = 0;

            int k = 0;
            for (int i = 0; i < MainForm.calc.d_X; i++)
            {
                raspredInitX.Rows.Add();

                char count = MainForm.calc.flags_X[k];
                char step = (char)1;
                raspredInitX.Rows[i].Cells[0].Value = (k + 1).ToString();

                while (count != 0)
                {
                    raspredInitX.Rows[i].Cells[0].Value += ", " + (k + 1 + step++).ToString(); 
                    count--;
                }
                k += step;

                if (i == MainForm.calc.d_X - 1)
                {
                    raspredInitX.Rows[i].Cells[1].Value = "[" + MainForm.calc.new_inter_X[i].getF() + ";" + "+∞" + ")";
                }
                else
                    if (i == 0)
                {
                    raspredInitX.Rows[i].Cells[1].Value = "(" + "-∞" + ";" + MainForm.calc.new_inter_X[i].getS() + ")";
                }
                else
                    raspredInitX.Rows[i].Cells[1].Value = "[" + MainForm.calc.new_inter_X[i].getF() + ";" + MainForm.calc.new_inter_X[i].getS() + ")";

                raspredInitX.Rows[i].Cells[2].Value = MainForm.calc.new_inter_X[i].getN();

                raspredInitX.Rows[i].Cells[3].Value = String.Format("{0:0.00}", MainForm.calc.teor_vel_X[i]);

                raspredInitX.Rows[i].Cells[4].Value = String.Format("{0:0.00}", MainForm.calc.dlya_stat_X[i]);

                all_n += MainForm.calc.new_inter_X[i].getN();
                all_teor_vel += MainForm.calc.teor_vel_X[i];
            }

            //
            raspredInitX.Rows.Add();
            raspredInitX.Rows[MainForm.calc.d_X].Cells[0].Value = "∑";
            raspredInitX.Rows[MainForm.calc.d_X].Cells[1].Value = "-";
            raspredInitX.Rows[MainForm.calc.d_X].Cells[2].Value = all_n;
            raspredInitX.Rows[MainForm.calc.d_X].Cells[3].Value = all_teor_vel;
            raspredInitX.Rows[MainForm.calc.d_X].Cells[4].Value = String.Format("{0:0.00}", MainForm.calc.hi_vib_X);

            //
            raspredInitX.Height = raspredInitX.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + raspredInitX.ColumnHeadersHeight;

            interval.Text = Convert.ToString(MainForm.calc.d_X);
            step_svobod.Text = Convert.ToString(MainForm.calc.step_svobodi_X);
            hi.Text = String.Format("{0:0.00}", MainForm.calc.hi_vib_X);
            hi_vivod.Text = String.Format("{0:0.00}", MainForm.calc.hi_vib_X);
            quant.Text = String.Format("{0:0.00}", MainForm.calc.quant_hi_X);
            svoboda.Text = "(" + Convert.ToString(MainForm.calc.step_svobodi_X) + ") =";

            if (MainForm.calc.hi_vib_X < MainForm.calc.quant_hi_X)
            {
                znak.Text = "<";
                uslovie.Text = "не противоречит";
            }
            else
            {
                znak.Text = ">";
                uslovie.Text = "противоречит";
            }
        }
    }
}
