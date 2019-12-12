using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zayac
{
    class Integral
    {
        public delegate double Function(double x);

        public static double Trapezoidal(Function f, double a, double b, int n)
        {
            double sum = 0.0;
            double h = (b - a) / n;
            for (int i = 0; i < n; i++)
            {
                sum += 0.5 * h * (f(a + i * h) + f(a + (i + 1) * h));
            }
            return sum;
        }

        static double laplas(double x)
        {
            x = Math.Pow(x, 2);
            x /= -2;

            return Math.Pow(Math.E, x);
        }

    }
}
