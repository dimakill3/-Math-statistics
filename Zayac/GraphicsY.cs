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
            gistY.Series["mᵢ / (m∙h)"].Points.DataBindXY(MainForm.calc.verh_Y, MainForm.calc.height_Y);
            poligonY.Series["mᵢ / m"].Points.DataBindXY(MainForm.calc.aver_Y, MainForm.calc.nums_Y);
            funcY.Series["∑(mᵢ ∙ m)"].Points.DataBindXY(MainForm.calc.func_int_Y, MainForm.calc.func_Y);
        }
    }
}
