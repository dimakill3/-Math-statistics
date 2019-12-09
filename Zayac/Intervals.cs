using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zayac
{
    class Intervals
    {

        private double first;
        private double second;
        private int n;
        private double average;
        private double heightPoligon;
        private double heightGist;
        private double func;

        Intervals()
        {
            first = 0;
            second = 0;
            n = 0;
            average = 0;
            heightPoligon = 0;
            heightGist = 0;
            func = 0;

        }
        
        public double getF()
        {
            return first;
        }

        public void setF(double first)
        {
            this.first = first;
        }
        public double getS()
        {
            return second;
        }

        public void setS(double second)
        {
            this.second = second;
        }    

        public void addN()
        {
            n++;
        }

        public int getN()
        {
            return n;
        }

        public void setA()
        {
            average = (first + second) / n;
        }

        public double getA()
        {
            return average;
        }

        public void setHP()
        {
            heightPoligon = n / Program.N;
        }

        public double getHP()
        {
            return heightPoligon;
        }

        public void setHG(int h)
        {
            heightGist = heightPoligon / h;
        }

        public double getHG()
        {
            return heightGist;
        }

        public void setFunc(int i, Intervals[] pred)
        {
            if (i == 0)
                func = 0;
            else
                if (i == 6)
                func = 1;
            else
            {
                for (int j = 0; j < i; j++)
                {
                    func += pred[j].func;
                }
                func += n / Program.N;
            }
        }

        public double getFunc()
        {
            return func;
        }

        
    }
}
