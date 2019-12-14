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
    public partial class Marks_Y : Form
    {
        public Marks_Y()
        {
            InitializeComponent();
        }

        private void Marks_Y_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormMarksY = false;
        }

        private void Marks_Y_Load(object sender, EventArgs e)
        {
            CustomToolTip tip = new CustomToolTip();
            tip.AutomaticDelay = 1000;

            tip.SetCustomToolTip(this.pictureBox1, "Выборочное_среднее_V.png");

            tip.SetCustomToolTip(this.pictureBox2, "Выборочное_среднее_квадратов_V.png");

            tip.SetCustomToolTip(this.pictureBox3, "дисперсия_V.png");

            tip.SetCustomToolTip(this.pictureBox4, "мат_ожид_Y.png");

            tip.SetCustomToolTip(this.pictureBox5, "дисперсия_Y.png");

            tip.SetCustomToolTip(this.pictureBox6, "среднеквадр_Y.png");

            tip.SetCustomToolTip(this.pictureBox7, "мат_ожид_усл_Y.png");

            tip.SetCustomToolTip(this.pictureBox8, "дисп_услов_Y.png");

            tip.SetCustomToolTip(this.pictureBox9, "среднеквадр_услов_Y.png");

            for (int i = 0; i < Program.r; i++)
            {
                raspredY.Rows.Add();

                raspredY.Rows[i].Cells[0].Value = i + 1;

                raspredY.Rows[i].Cells[1].Value = MainForm.calc.uslov_vel_Y[i];

                raspredY.Rows[i].Cells[2].Value = MainForm.calc.inter_Y[i].getN();

                raspredY.Rows[i].Cells[3].Value = MainForm.calc.sum_uslov_vel_Y[i];

                raspredY.Rows[i].Cells[4].Value = MainForm.calc.kv_sum_uslov_vel_Y[i];
            }

            sum_all_usl_v.Text = String.Format("{0:0.00}", MainForm.calc.all_average_uslov_Y);
            all_sum_usl_in_2_v.Text = String.Format("{0:0.00}", MainForm.calc.all_average_uslov_Y_in_two);
            disp_usl_v.Text = String.Format("{0:0.00}", MainForm.calc.dispers_uslov_Y);

            mat_ojid_Y.Text = String.Format("{0:0.00}", MainForm.calc.all_average_Y);
            disp_Y.Text = String.Format("{0:0.00}", MainForm.calc.dispers_Y);
            sred_kv_Y.Text = String.Format("{0:0.00}", MainForm.calc.sred_kvadr_Y);

            sum_all_usl_v_vivod.Text = String.Format("{0:0.00}", MainForm.calc.all_average_uslov_Y_vivod);
            disp_usl_v_vivod.Text = String.Format("{0:0.00}", MainForm.calc.dispers_uslov_Y_vivod);
            sred_kv_usl_v_vivod.Text = String.Format("{0:0.00}", MainForm.calc.sred_kvadr_uslov_Y_vivod);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
