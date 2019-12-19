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
    public partial class HipotesyY : Form
    {
        public HipotesyY()
        {
            InitializeComponent();
        }

        private void Hipotesy_Y_Load(object sender, EventArgs e)
        {
            CustomToolTip[] tip = new CustomToolTip[10];
            for (int i = 0; i < 10; i++)
                tip[i] = new CustomToolTip();

            tip[0].SetCustomToolTip(pictureBox5, "hi_kvadr_Y.png");
            tip[1].SetCustomToolTip(pictureBox4, "hi_kvadr_Y.png");
            tip[2].SetCustomToolTip(pictureBox2, "kvantil.png");
            tip[3].SetCustomToolTip(pictureBox6, "laplas.png");
            tip[4].SetCustomToolTip(label1, "m_label.png");
            tip[5].SetCustomToolTip(label7, "a_label.png");
            tip[6].SetCustomToolTip(label2, "mk1_label.png");


            for (int i = 0; i < Program.r; i++)
            {
                raspredY.Rows.Add();

                raspredY.Rows[i].Cells[0].Value = i + 1;


                if (i == Program.r - 1)
                {
                    raspredY.Rows[i].Cells[1].Value = "[" + MainForm.calc.inter_Y[i].getF() + ";" + "+∞" + ")";
                }
                else
                    if (i == 0)
                {
                    raspredY.Rows[i].Cells[1].Value = "(" + "-∞" + ";" + MainForm.calc.inter_Y[i].getS() + ")";
                }
                else
                    raspredY.Rows[i].Cells[1].Value = "[" + MainForm.calc.inter_Y[i].getF() + ";" + MainForm.calc.inter_Y[i].getS() + ")";

                raspredY.Rows[i].Cells[2].Value = MainForm.calc.inter_Y[i].getN();

                raspredY.Rows[i].Cells[3].Value = String.Format("{0:0.00}", MainForm.calc.norm_vel_Y[i]);

                raspredY.Rows[i].Cells[4].Value = String.Format("{0:0.000}", MainForm.calc.form_lap_Y[i]);

                raspredY.Rows[i].Cells[5].Value = String.Format("{0:0.000}", MainForm.calc.ver_sob_Y[i]);

                raspredY.Rows[i].Cells[6].Value = String.Format("{0:0.00}", MainForm.calc.teor_chast_Y[i]);
            }

            double all_n = 0, all_teor_vel = 0;

            int k = 0;
            for (int i = 0; i < MainForm.calc.d_Y; i++)
            {
                raspredInitY.Rows.Add();

                char count = MainForm.calc.flags_Y[k];
                char step = (char)1;

                raspredInitY.Rows[i].Cells[0].Value = (k + 1).ToString();

                while (count != 0)
                {
                    raspredInitY.Rows[i].Cells[0].Value += ", " + (k + 1 + step++).ToString();
                    count--;
                }
                k += step;

                if (i == MainForm.calc.d_Y - 1)
                {
                    raspredInitY.Rows[i].Cells[1].Value = "[" + MainForm.calc.new_inter_Y[i].getF() + ";" + "+∞" + ")";
                }
                else
                    if (i == 0)
                {
                    raspredInitY.Rows[i].Cells[1].Value = "(" + "-∞" + ";" + MainForm.calc.new_inter_Y[i].getS() + ")";
                }
                else
                    raspredInitY.Rows[i].Cells[1].Value = "[" + MainForm.calc.new_inter_Y[i].getF() + ";" + MainForm.calc.new_inter_Y[i].getS() + ")";

                raspredInitY.Rows[i].Cells[2].Value = MainForm.calc.new_inter_Y[i].getN();

                raspredInitY.Rows[i].Cells[3].Value = String.Format("{0:0.00}", MainForm.calc.teor_vel_Y[i]);

                raspredInitY.Rows[i].Cells[4].Value = String.Format("{0:0.00}", MainForm.calc.dlya_stat_Y[i]);

                all_n += MainForm.calc.new_inter_Y[i].getN();
                all_teor_vel += MainForm.calc.teor_vel_Y[i];
            }

            raspredInitY.Rows.Add();
            raspredInitY.Rows[MainForm.calc.d_Y].Cells[0].Value = "∑";
            raspredInitY.Rows[MainForm.calc.d_Y].Cells[1].Value = "-";
            raspredInitY.Rows[MainForm.calc.d_Y].Cells[2].Value = all_n;
            raspredInitY.Rows[MainForm.calc.d_Y].Cells[3].Value = all_teor_vel;
            raspredInitY.Rows[MainForm.calc.d_Y].Cells[4].Value = String.Format("{0:0.00}", MainForm.calc.hi_vib_Y);

            raspredInitY.Height = raspredInitY.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + raspredInitY.ColumnHeadersHeight;

            interval.Text = Convert.ToString(MainForm.calc.d_Y);
            step_svobod.Text = Convert.ToString(MainForm.calc.step_svobodi_Y);
            hi.Text = String.Format("{0:0.00}", MainForm.calc.hi_vib_Y);
            hi_vivod.Text = String.Format("{0:0.00}", MainForm.calc.hi_vib_Y);
            quant.Text = String.Format("{0:0.00}", MainForm.calc.quant_hi_Y);
            svoboda.Text = "(" + Convert.ToString(MainForm.calc.step_svobodi_Y) + ") =";

            if (MainForm.calc.hi_vib_Y < MainForm.calc.quant_hi_Y)
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

        private void Hipotesy_Y_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormHipotesyY = false;
        }
    }
}
