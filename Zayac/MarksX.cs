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
    public partial class Marks_X : Form
    {
        public Marks_X()
        {
            InitializeComponent();
        }

        private void Marks_X_Load(object sender, EventArgs e)
        {

            CustomToolTip[] tip = new CustomToolTip[20];
            for (int i = 0; i < 20; i++)
            {
                tip[i] = new CustomToolTip();
                tip[i].AutomaticDelay = 1000;
            }
            tip[0].SetCustomToolTip(this.pictureBox1, "Выборочное_среднее_U.png");
            tip[1].SetCustomToolTip(this.pictureBox2, "Выборочное_среднее_квадратов_U.png");
            tip[2].SetCustomToolTip(this.pictureBox3, "дисперсия_U.png");

            tip[3].SetCustomToolTip(this.pictureBox4, "мат_ожид_X.png");
            tip[4].SetCustomToolTip(this.pictureBox5, "дисперсия_X.png");
            tip[5].SetCustomToolTip(this.pictureBox6, "среднеквадр_X.png");

            tip[6].SetCustomToolTip(this.pictureBox9, "среднеквадр_услов_X.png"); 
             tip[7].SetCustomToolTip(this.pictureBox8, "дисп_услов_X.png");
            tip[8].SetCustomToolTip(this.pictureBox7, "мат_ожид_усл_Y.png");


            for (int i = 0; i < Program.r; i++)
            {
                raspredX.Rows.Add();

                raspredX.Rows[i].Cells[0].Value = i + 1;

                raspredX.Rows[i].Cells[1].Value = MainForm.calc.uslov_vel_X[i];

                raspredX.Rows[i].Cells[2].Value = MainForm.calc.inter_X[i].getN();

                raspredX.Rows[i].Cells[3].Value = MainForm.calc.sum_uslov_vel_X[i];

                raspredX.Rows[i].Cells[4].Value = MainForm.calc.kv_sum_uslov_vel_X[i];
            }

            sum_all_usl_u.Text = String.Format("{0:0.00}", MainForm.calc.all_average_uslov_X);
            all_sum_usl_in_2_u.Text = String.Format("{0:0.00}", MainForm.calc.all_average_uslov_X_in_two);
            disp_usl_u.Text = String.Format("{0:0.00}", MainForm.calc.dispers_uslov_X);

            mat_ojid_X.Text = String.Format("{0:0.000000}", MainForm.calc.all_average_X);
            disp_X.Text = String.Format("{0:0.000000}", MainForm.calc.dispers_X);
            sred_kv_X.Text = String.Format("{0:0.00}", MainForm.calc.sred_kvadr_X);

            sum_all_usl_u_vivod.Text = String.Format("{0:0.000000}", MainForm.calc.all_average_uslov_X_vivod);
            disp_usl_u_vivod.Text = String.Format("{0:0.000000}", MainForm.calc.dispers_uslov_X_vivod);
            sred_kv_usl_u_vivod.Text = String.Format("{0:0.00}", MainForm.calc.sred_kvadr_uslov_X_vivod);

        }
        private void Marks_X_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormMarksX = false;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Disp_X_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sum_all_usl_u_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
