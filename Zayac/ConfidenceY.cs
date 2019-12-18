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
    public partial class ConfidenceY : Form
    {
        public ConfidenceY()
        {
            InitializeComponent();
        }

        private void ConfidenceY_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormDoverY = false;
        }

        private void ConfidenceY_Load(object sender, EventArgs e)
        {
            CustomToolTip[] tip = new CustomToolTip[10];
            for (int i = 0; i < 10; i++)
            {
                tip[i] = new CustomToolTip();
                tip[i].AutomaticDelay = 1000;
            }
            tip[0].SetCustomToolTip(this.pictureBox1, "довер_MY.png");
            tip[1].SetCustomToolTip(this.pictureBox2, "довер_DY.png");

            label_dover_MX_min.Text = String.Format("{0:0.00}", MainForm.calc.dover_inter_MY_min);
            label_dover_MX_max.Text = String.Format("{0:0.00}", MainForm.calc.dover_inter_MY_max);
            label_dover_DX_min.Text = String.Format("{0:0.00}", MainForm.calc.dover_inter_DY_min);
            label_dover_DX_max.Text = String.Format("{0:0.00}", MainForm.calc.dover_inter_DY_max);
            label1.Text = Convert.ToString(MainForm.calc.dover_P);
            label2.Text = Convert.ToString(1 - MainForm.calc.dover_P);

        }
    }
}
