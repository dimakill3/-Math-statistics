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
    public partial class Correlative : Form
    {

        private int count ;
        private int Sum_count;
        private double vibor_koef;
        private double uv;

        public Correlative()
        {
            InitializeComponent();
            count = 0;
            Sum_count = 0;
            uv = 0;
        }

        private void Correlative_Load(object sender, EventArgs e)
        {
            CustomToolTip tip = new CustomToolTip();
            tip.AutomaticDelay = 1000;
            tip.SetCustomToolTip(this.pictureBox1, "vibor_koef.png");

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

            for(int i = 0; i < Program.N; i++)
            {
                CorrTable.Rows[MainForm.calc.getInterX(MainForm.calc.masX_No_Sort[i])].Cells[MainForm.calc.getInterY(MainForm.calc.masY_No_Sort[i]) + 1].Value = Convert.ToString(Convert.ToInt32(CorrTable.Rows[MainForm.calc.getInterX(MainForm.calc.masX_No_Sort[i])].Cells[MainForm.calc.getInterY(MainForm.calc.masY_No_Sort[i]) + 1].Value) + 1);
            }

            for (int i = 0; i < Program.r; i++)
            {
                count = 0;
                for (int j = 1; j < Program.r + 1; j++)
                {
                    count += Convert.ToInt32(CorrTable.Rows[i].Cells[j].Value);
                }
                CorrTable.Rows[i].Cells[8].Value = Convert.ToString(count);
                Sum_count += count;
            }

            for (int i = 1; i < Program.r + 1; i++)
            {
                count = 0;
                for (int j = 0; j < Program.r; j++)
                {
                    count += Convert.ToInt32(CorrTable.Rows[j].Cells[i].Value);
                }
                CorrTable.Rows[7].Cells[i].Value = Convert.ToString(count);
            }

            CorrTable.Rows[7].Cells[8].Value = Convert.ToString(Sum_count);

            for (int i = 0; i < Program.r; i++)
            {
                for (int j = 0; j < Program.r; j++)
                {
                    uv += MainForm.calc.uslov_vel_X[i] * MainForm.calc.uslov_vel_Y[j] * Convert.ToInt32(CorrTable.Rows[i].Cells[j + 1].Value);
                }
            }

            uv /= Program.N;

            vibor_koef = (Program.N / (Program.N - 1)) * (uv - (MainForm.calc.all_average_uslov_X * MainForm.calc.all_average_uslov_Y)) / (Math.Sqrt(MainForm.calc.dispers_uslov_X) * Math.Sqrt(MainForm.calc.dispers_uslov_Y));
            label1.Text = Convert.ToString(String.Format("{0:0.00}", vibor_koef));
        }

        private void Correlative_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormCorrel = false;
        }
    }
}
