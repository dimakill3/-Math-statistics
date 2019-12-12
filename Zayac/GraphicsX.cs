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
    }
}
