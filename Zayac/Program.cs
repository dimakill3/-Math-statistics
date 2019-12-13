using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Zayac
{

    class Program
    {

        //количество данных
        public const int N = 50;
        //количество интервалов
        public const int r = 7;
        //число неизвестных в нормальном распределении
        public const int л = 2;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }


    }
}
