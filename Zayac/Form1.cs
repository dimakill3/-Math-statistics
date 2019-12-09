using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zayac
{
    public partial class Form1 : Form
    {

        Calculation calc;
        public Form1()
        {
            InitializeComponent();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raspredX.Rows.Clear();
            raspredY.Rows.Clear();
            var filePath = string.Empty;
            var fileContent = string.Empty;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFile.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFile.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }

                String[] Content = fileContent.Split('\n');
                string[] s = new string[2];

                //Чтение из файла
                Calculation calc = new Calculation();
                calc.Calculate(Content);

                for (int i = 0; i < Program.r; i++)
                {
                    raspredX.Rows.Add();
                    raspredY.Rows.Add();

                    raspredX.Rows[i].Cells[0].Value = i + 1;
                    raspredY.Rows[i].Cells[0].Value = i + 1;

                    if (i == Program.r - 1)
                    {
                        raspredX.Rows[i].Cells[1].Value = "[" + calc.inter_X[i].getF() + ";" + calc.inter_X[i].getS() + "]";
                        raspredY.Rows[i].Cells[1].Value = "[" + calc.inter_Y[i].getF() + ";" + calc.inter_Y[i].getS() + "]";
                    }
                    else
                    {
                        raspredX.Rows[i].Cells[1].Value = "[" + calc.inter_X[i].getF() + ";" + calc.inter_X[i].getS() + ")";
                        raspredY.Rows[i].Cells[1].Value = "[" + calc.inter_Y[i].getF() + ";" + calc.inter_Y[i].getS() + ")";

                    }

                    raspredX.Rows[i].Cells[2].Value = calc.inter_X[i].getN();
                    raspredY.Rows[i].Cells[2].Value = calc.inter_Y[i].getN();

                    raspredX.Rows[i].Cells[3].Value = calc.inter_X[i].getA();
                    raspredY.Rows[i].Cells[3].Value = calc.inter_Y[i].getA();

                    raspredX.Rows[i].Cells[4].Value = calc.inter_X[i].getHP();
                    raspredY.Rows[i].Cells[4].Value = calc.inter_Y[i].getHP();

                    raspredX.Rows[i].Cells[5].Value = calc.inter_X[i].getHG();
                    raspredY.Rows[i].Cells[5].Value = calc.inter_Y[i].getHG();

                    raspredX.Rows[i].Cells[6].Value = calc.inter_X[i].getFunc();
                    raspredY.Rows[i].Cells[6].Value = calc.inter_Y[i].getFunc();

                }

            }
        }


    }
}
