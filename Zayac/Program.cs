using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zayac
{
    static class Program
    {
        const int N = 50;
        const int r = 7;
        static double[] masX = new double[N];
        static int[] masY = new int[N];

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string[] lines = File.ReadAllLines("Array.txt");

            string[] s = new string[2];

            //Чтение из файла
            for (int i = 0; i < lines.Length; i++)
            {
                s = lines[i].Split(' ');
                masX[i] = Convert.ToDouble(s[0]);
                masY[i] = Convert.ToInt32(s[1]);
            }

            double max_X, min_X;
            int max_Y, min_Y;

            Array.Sort(masX);
            Array.Sort(masY);

            min_X = masX[0];
            min_Y = masY[0];

            max_X = masX[masX.Length - 1];
            max_Y = masY[masY.Length - 1];

            double razryv_X = max_X - min_X;
            int razryv_Y = max_Y - min_Y;

            int h_X = (int)razryv_X / r + 1;
            int h_Y = (int)razryv_Y / r + 1;

            
        }
    }
}
