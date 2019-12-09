﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zayac
{
    class Calculation
    {

        double[] masX = new double[Program.N];
        double[] masY = new double[Program.N];
        double max_X, min_X, max_Y, min_Y;
        double razryv_X, razryv_Y;
        double h_X, h_Y;
        double rashirenie_X, rashirenie_Y;
        Intervals[] inter_X = new Intervals[Program.r];
        Intervals[] inter_Y = new Intervals[Program.r];

        double begin_X, begin_Y;
        double[] aver_X = new double[Program.r];
        double[] nums_X = new double[Program.r];

        double[] aver_Y = new double[Program.r];
        double[] nums_Y = new double[Program.r];

        double[] verh_X = new double[Program.r + 1];
        double[] height_X = new double[Program.r];

        double[] verh_Y = new double[Program.r + 1];
        double[] height_Y = new double[Program.r];

        //X с чертой(математическое ожидание X)
        double all_average_X;
        //Y с чертой(математическое ожидание Y)
        double all_average_Y;

        //Математическое ожидание от X^2
        double all_average_X_in_degree_two;
        //Математическое ожидание от Y^2
        double all_average_Y_in_degree_two;

        //Дисперсия для X
        double dispers_X;
        //Дисперсия для Y
        double dispers_Y;

        //Средне-квадратичное отклонение X
        double sred_kvadr_X;

        //Средне-квадратичное отклонение Y
        double sred_kvadr_Y;


        public Calculation()
        {
            all_average_X = 0;
            all_average_Y = 0;
            //dispers_X = 0;
            //dispers_Y = 0;
            //sred_kvadr_X = 0;
            //sred_kvadr_Y = 0;
        }

        public void Calculate(String[] fielRead)
        {
            string[] s = new string[2];

            for (int i = 0; i < fielRead.Length; i++)
            {
                s = fielRead[i].Split(' ');

                //Массив для веса
                masX[i] = Convert.ToDouble(s[0]);

                //Массив для роста
                masY[i] = Convert.ToDouble(s[1]);

            }

            //Сортировка массивов
            Array.Sort(masX);
            Array.Sort(masY);

            min_X = masX[0];
            min_Y = masY[0];

            max_X = masX[masX.Length - 1];
            max_Y = masY[masY.Length - 1];

            //Разница между максимальным и минимальным
            razryv_X = max_X - min_X;
            razryv_Y = max_Y - min_Y;

            //Шаг(длина интервала)
            h_X = Math.Ceiling(razryv_X / Program.r);
            h_Y = Math.Ceiling(razryv_Y / Program.r);

            //На всякий случай расширение промежутка разбиения
            rashirenie_X = (h_X - (razryv_X / Program.r)) * Program.r;
            rashirenie_Y = (h_Y - (razryv_Y / Program.r)) * Program.r;


            //Изменённое начало первого интервала для X (Оно может быть не целым, поэтому округляем в меньшую сторону)
            begin_X = Math.Floor(masX[0]);

            //Всегда целое значение, менять не нужно
            begin_Y = masY[0];

            //Установление интервалов
            #region
            for (int j = 0; j < Program.r; j++)
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
            #endregion

            //Нахождение количества элементов, пренадлежащих определённому интервалу
            #region
            for (int j = 0; j < Program.r; j++)
                for (int i = 0; i < Program.N; i++)
                {
                    //Находим сколько элементов принадлежат интервалу r по X
                    if (masX[i] >= inter_X[j].getF() && masX[i] < inter_X[j].getS())
                        inter_X[j].addN();

                    //Находим сколько элементов принадлежат интервалу r по Y
                    if (masY[i] >= inter_Y[j].getF() && masY[i] < inter_Y[j].getS())
                        inter_Y[j].addN();
                }
            #endregion

            //Высоты и функция
            #region
            for (int j = 0; j < Program.r; j++)
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
            #endregion

            //Замолняем массив для полигона
            #region
            for (int j = 0; j < Program.r; j++)
            {
                aver_X[j] = inter_X[j].getA();
                aver_Y[j] = inter_Y[j].getA();

                nums_X[j] = inter_X[j].getHP();
                nums_Y[j] = inter_Y[j].getHP();
            }
            #endregion

            //Заполняем массив для гистограммы
            #region
            for (int j = 0; j < Program.r; j++)
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
            #endregion

            //Нахождение математического ожидания(точечная оценка)
            #region 
            for (int j = 0; j < Program.r; j++)
            {
                all_average_X += inter_X[j].getA() * inter_X[j].getN();
                all_average_Y += inter_Y[j].getA() * inter_Y[j].getN();
            }

            all_average_X /= Program.N;
            all_average_Y /= Program.N;
            #endregion

            //Находим математическое ожидание от X^2
            #region
            for (int j = 0; j < Program.r; j++)
            {
                all_average_X_in_degree_two += Math.Pow(inter_X[j].getA(), 2) * inter_X[j].getN();
                all_average_Y_in_degree_two += Math.Pow(inter_Y[j].getA(), 2) * inter_Y[j].getN();
            }
            #endregion

            //Дисперсия для X
            dispers_X = ((all_average_X_in_degree_two - Math.Pow(all_average_X, 2)) * Program.N) / (Program.N - 1);

            //Дисперсия для Y
            dispers_Y = ((all_average_Y_in_degree_two - Math.Pow(all_average_Y, 2)) * Program.N) / (Program.N - 1);

            //Средне-квадратичное отклонение X
            sred_kvadr_X = Math.Sqrt(dispers_X);

            //Средне-квадратичное отклонение Y
            sred_kvadr_Y = Math.Sqrt(dispers_Y);


        }
    }
}
