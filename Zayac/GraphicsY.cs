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
    public partial class GraphicsY : Form
    {
        public GraphicsY()
        {
            InitializeComponent();
        }

        private void GraphicsY_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVars.FormGraphicsY = false;
        }

        private void GraphicsY_Load(object sender, EventArgs e)
        {
            gistY.Series["mᵢ / (n ∙ h)"].Points.DataBindXY(MainForm.calc.aver_Y, MainForm.calc.height_Y);
            gistY.ChartAreas["ChartArea1"].AxisX.Interval = MainForm.calc.h_Y;
            gistY.ChartAreas["ChartArea1"].AxisX.IntervalOffset = MainForm.calc.h_Y / 2;

            poligonY.Series["mᵢ / n"].Points.DataBindXY(MainForm.calc.aver_Y, MainForm.calc.nums_Y);
            poligonY.ChartAreas["ChartArea1"].AxisX.Interval = MainForm.calc.h_Y;

            funcY.Series["∑(mᵢ / n)"].Points.DataBindXY(MainForm.calc.func_int_Y, MainForm.calc.func_Y);
            funcY.ChartAreas["ChartArea1"].AxisX.Interval = MainForm.calc.h_Y;
        }
    }
}
