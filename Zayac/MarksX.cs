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

            mat_ojid_X.Text = String.Format("{0:0.00}", MainForm.calc.all_average_X);
            disp_X.Text = String.Format("{0:0.00}", MainForm.calc.dispers_X);
            sred_kv_X.Text = String.Format("{0:0.00}", MainForm.calc.sred_kvadr_X);

            sum_all_usl_u_vivod.Text = String.Format("{0:0.00}", MainForm.calc.all_average_uslov_X_vivod);
            disp_usl_u_vivod.Text = String.Format("{0:0.00}", MainForm.calc.dispers_uslov_X_vivod);
            sred_kv_usl_u_vivod.Text = String.Format("{0:0.00}", MainForm.calc.sred_kvadr_uslov_X_vivod);

        }
        private void Marks_X_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormMarksX = false;
        }
    }
}
