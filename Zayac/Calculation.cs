using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zayac
{
    class Calculation
    {

        public const int N = 50;
        public const int r = 7;

        static double[] masX = new double[N];
        static int[] masY = new int[N];


        public void Calculate()
        {
            string[] lines = File.ReadAllLines("Array.txt");
            string[] s = new string[2];

            //Чтение из файла
            for (int i = 0; i < lines.Length; i++)
            {
                s = lines[i].Split(' ');

                //Массив для веса
                masX[i] = Convert.ToDouble(s[0]);

                //Массив для роста
                masY[i] = Convert.ToInt32(s[1]);
            }

            double max_X, min_X;
            int max_Y, min_Y;

            //Сортировка массивов
            Array.Sort(masX);
            Array.Sort(masY);

            min_X = masX[0];
            min_Y = masY[0];

            max_X = masX[masX.Length - 1];
            max_Y = masY[masY.Length - 1];

            //Разница между максимальным и минимальным
            double razryv_X = max_X - min_X;
            int razryv_Y = max_Y - min_Y;

            //Шаг(длина интервала)
            int h_X = (int)Math.Ceiling(razryv_X / r);
            int h_Y = (int)Math.Ceiling((double)(razryv_Y / r));

            //На всякий случай расширение промежутка разбиения
            double rashirenie_X = (h_X - (razryv_X / r)) * r;
            double rashirenie_Y = (h_Y - (razryv_Y / r)) * r;

            Intervals[] inter_X = new Intervals[r];
            Intervals[] inter_Y = new Intervals[r];

            //Изменённое начало первого интервала для X (Оно может быть не целым, поэтому округляем в меньшую сторону)
            int begin_X = (int)Math.Floor(masX[0]);
            //Всегда целое значение, менять не нужно
            int begin_Y = masY[0];

            for (int j = 0; j < r; j++)
            {
                //Установление интервала для X
                inter_X[j].setF(begin_X);
                inter_X[j].setS(begin_X + h_X);

                //Среднее значение интервала для X
                inter_X[j].setA();

                //Начало следующего интервала для X
                begin_X += h_X;

                //Установление интервала для Y
                inter_Y[j].setF(begin_Y);
                inter_Y[j].setS(begin_Y + h_Y);

                //Среднее значение интервала для Y
                inter_Y[j].setA();

                //Начало следующего интервала для Y
                begin_Y += h_Y;
            }

            for (int j = 0; j < r; j++)
                for (int i = 0; i < N; i++)
                {
                    //Находим сколько элементов принадлежат интервалу r по X
                    if (masX[i] >= inter_X[j].getF() && masX[i] < inter_X[j].getS())
                        inter_X[j].addN();

                    //Находим сколько элементов принадлежат интервалу r по Y
                    if (masY[i] >= inter_Y[j].getF() && masY[i] < inter_Y[j].getS())
                        inter_Y[j].addN();
                }

            for (int j = 0; j < r; j++)
            {
                //Задаём высоты для полигона, гистограммы и функцию распределения для X
                inter_X[j].setHP();
                inter_X[j].setHG(h_X);
                inter_X[j].setFunc(j, inter_X);

                //Задаём высоты для полигона, гистограммы и функцию распределения для Y
                inter_Y[j].setHP();
                inter_Y[j].setHG(h_Y);
                inter_Y[j].setFunc(j, inter_Y);
            }


            //Подготовка массивов для полигона
            double[] aver_X = new double[r];
            double[] nums_X = new double[r];

            double[] aver_Y = new double[r];
            double[] nums_Y = new double[r];

            for (int j = 0; j < r; j++)
            {
                aver_X[j] = inter_X[j].getA();
                aver_Y[j] = inter_Y[j].getA();

                nums_X[j] = inter_X[j].getHP();
                nums_Y[j] = inter_Y[j].getHP();
            }


            //Подготовка массивов для гистограммы
            double[] verh_X = new double[r + 1];
            double[] height_X = new double[r];

            double[] verh_Y = new double[r + 1];
            double[] height_Y = new double[r];



            for (int j = 0; j < r; j++)
            {

                verh_X[j] = inter_X[j].getF();
                verh_Y[j] = inter_Y[j].getF();
                if (j == 6)
                {
                    verh_X[j + 1] = inter_X[j].getS();
                    verh_Y[j + 1] = inter_Y[j].getS();
                }

                height_X[j] = inter_X[j].getHG();
                height_Y[j] = inter_Y[j].getHG();

            }
        }
    }
}
