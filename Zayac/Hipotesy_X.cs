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
            int k = 0;

            for (int i = 0; i < MainForm.calc.d_X; i++)
            {
                raspredX.Rows.Add();

                char count = MainForm.calc.flags_X[k];
                char step = (char)1;

                raspredX.Rows[i].Cells[0].Value = (k + 1).ToString();

                while (count != 0)
                {
                    raspredX.Rows[i].Cells[0].Value += ", " + (k + 1 + step++).ToString(); 
                    count--;
                }
                k += step;

                if (i == MainForm.calc.d_X - 1)
                {
                    raspredX.Rows[i].Cells[1].Value = "[" + MainForm.calc.new_inter_X[i].getF() + ";" + "+∞" + ")";
                }
                else
                    if (i == 0)
                {
                    raspredX.Rows[i].Cells[1].Value = "(" + "-∞" + ";" + MainForm.calc.new_inter_X[i].getS() + ")";
                }
                else
                    raspredX.Rows[i].Cells[1].Value = "[" + MainForm.calc.new_inter_X[i].getF() + ";" + MainForm.calc.new_inter_X[i].getS() + ")";

                raspredX.Rows[i].Cells[2].Value = MainForm.calc.new_inter_X[i].getN();

                raspredX.Rows[i].Cells[3].Value = String.Format("{0:0.00}", MainForm.calc.norm_vel_X[i]);

                raspredX.Rows[i].Cells[4].Value = String.Format("{0:0.00}", MainForm.calc.form_lap_X[i]);

                raspredX.Rows[i].Cells[5].Value = String.Format("{0:0.00}", MainForm.calc.ver_sob_X[i]);

                raspredX.Rows[i].Cells[6].Value = String.Format("{0:0.00}", MainForm.calc.teor_vel_X[i]);

                raspredX.Rows[i].Cells[7].Value = String.Format("{0:0.00}", MainForm.calc.dlya_stat_X[i]);
            }
            raspredX.Height = raspredX.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + raspredX.ColumnHeadersHeight;
        }
    }
}
