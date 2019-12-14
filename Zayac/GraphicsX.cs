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
    public partial class GraphicsX : Form
    {
        public GraphicsX()
        {
            InitializeComponent();
        }

        private void GraphicsX_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormGraphicsX = false;
        }

        private void GraphicsX_Load(object sender, EventArgs e)
        {
            gistX.Series["nᵢ / (n ∙ h)"].Points.DataBindXY(MainForm.calc.aver_X, MainForm.calc.height_X);
            gistX.ChartAreas["ChartArea1"].AxisX.Interval = MainForm.calc.h_X;
            gistX.ChartAreas["ChartArea1"].AxisX.IntervalOffset = MainForm.calc.h_X / 2;

            poligonX.Series["nᵢ / n"].Points.DataBindXY(MainForm.calc.aver_X, MainForm.calc.nums_X);
            poligonX.ChartAreas["ChartArea1"].AxisX.Interval = MainForm.calc.h_X;

            funcX.Series["∑(nᵢ / n)"].Points.DataBindXY(MainForm.calc.func_int_X, MainForm.calc.func_X);
            funcX.ChartAreas["ChartArea1"].AxisX.Interval = MainForm.calc.h_X;
        }
    }
}
