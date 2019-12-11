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
    }
}
