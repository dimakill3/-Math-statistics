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
    public partial class Confidence : Form
    {


        public Confidence()
        {
            InitializeComponent();
        }

        private void Confidence_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormDoverX = false;
        }

        private void Confidence_Load(object sender, EventArgs e)
        {
            CustomToolTip[] tip = new CustomToolTip[10];
            for (int i = 0; i < 10; i++)
            {
                tip[i] = new CustomToolTip();
                tip[i].AutomaticDelay = 1000;
            }
            tip[0].SetCustomToolTip(this.pictureBox1, "довер_MX.png");
            tip[1].SetCustomToolTip(this.pictureBox2, "довер_DX.png");

            label_dover_MX_min.Text = String.Format("{0:0.00}", MainForm.calc.dover_inter_MX_min);
            label_dover_MX_max.Text = String.Format("{0:0.00}", MainForm.calc.dover_inter_MX_max);
            label_dover_DX_min.Text = String.Format("{0:0.00}", MainForm.calc.dover_inter_DX_min);
            label_dover_DX_max.Text = String.Format("{0:0.00}", MainForm.calc.dover_inter_DX_max);

        }
    }
}
