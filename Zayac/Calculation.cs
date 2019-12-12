﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zayac
{
    public class Calculation
    {
        double lap;

        public double[] masX = new double[Program.N];
        public double[] masY = new double[Program.N];
        public double max_X, min_X, max_Y, min_Y;
        public double razryv_X, razryv_Y;
        public double h_X, h_Y;
        public double rashirenie_X, rashirenie_Y;
        public Intervals[] inter_X = new Intervals[Program.r];
        public Intervals[] inter_Y = new Intervals[Program.r];


        public double begin_X, begin_Y;

        public double[] aver_X = new double[Program.r];
        public double[] nums_X = new double[Program.r];

        public double[] aver_Y = new double[Program.r];
        public double[] nums_Y = new double[Program.r];

        public double[] verh_X = new double[Program.r + 1];
        public double[] height_X = new double[Program.r + 1];

        public double[] verh_Y = new double[Program.r + 1];
        public double[] height_Y = new double[Program.r + 1];

        public double[] func_X = new double[Program.r + 2];
        public double[] func_Y = new double[Program.r + 2];

        public double[] func_int_X = new double[Program.r + 2];
        public double[] func_int_Y = new double[Program.r + 2];

        //X с чертой(математическое ожидание X)
        public double all_average_X;
        //Y с чертой(математическое ожидание Y)
        public double all_average_Y;

        //Математическое ожидание от X^2
        public double all_average_X_in_degree_two;
        //Математическое ожидание от Y^2
        public double all_average_Y_in_degree_two;

        //Дисперсия для X
        public double dispers_X;
        //Дисперсия для Y
        public double dispers_Y;

        //Средне-квадратичное отклонение X
        public double sred_kvadr_X;

        //Средне-квадратичное отклонение Y
        public double sred_kvadr_Y;

        public int maxN_X, maxN_Y;
        public int index_X, index_Y;

        //Переход к условным величинам
        public double[] uslov_vel_X = new double[Program.r];
        public double[] uslov_vel_Y = new double[Program.r];

        public double[] sum_uslov_vel_X = new double[Program.r];
        public double[] sum_uslov_vel_Y = new double[Program.r];

        public double[] kv_sum_uslov_vel_X = new double[Program.r];
        public double[] kv_sum_uslov_vel_Y = new double[Program.r];

        double all_average_uslov_X, all_average_uslov_Y;
        double all_average_uslov_X_in_two, all_average_uslov_Y_in_two;
        double dispers_uslov_X, dispers_uslov_Y;
        double sred_kvadr_uslov_X, sred_kvadr_uslov_Y;

        double all_average_uslov_X_vivod, all_average_uslov_Y_vivod;
        double dispers_uslov_X_vivod, dispers_uslov_Y_vivod;
        double sred_kvadr_uslov_X_vivod, sred_kvadr_uslov_Y_vivod;


        public Calculation()
        {
            all_average_X = 0;
            all_average_Y = 0;

            all_average_X_in_degree_two = 0;
            all_average_Y_in_degree_two = 0;

            all_average_uslov_X = 0; 
            all_average_uslov_Y = 0;

            all_average_uslov_X_in_two = 0;
            all_average_uslov_Y_in_two = 0;

            lap = (1 / Math.Sqrt(2 * Math.PI));
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
                inter_X[j] = new Intervals();
                inter_Y[j] = new Intervals();
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
                    if (j == 6)
                    {
                        if (masX[i] >= inter_X[j].getF() && masX[i] <= inter_X[j].getS())
                            inter_X[j].addN();

                        //Находим сколько элементов принадлежат интервалу r по Y
                        if (masY[i] >= inter_Y[j].getF() && masY[i] <= inter_Y[j].getS())
                            inter_Y[j].addN();
                    }
                    else
                    {
                        //Находим сколько элементов принадлежат интервалу r по X
                        if (masX[i] >= inter_X[j].getF() && masX[i] < inter_X[j].getS())
                            inter_X[j].addN();

                        //Находим сколько элементов принадлежат интервалу r по Y
                        if (masY[i] >= inter_Y[j].getF() && masY[i] < inter_Y[j].getS())
                            inter_Y[j].addN();
                    }
                  
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

                    height_X[j + 1] = inter_X[j].getHG();
                    height_Y[j + 1] = inter_Y[j].getHG();
                }

                height_X[j] = inter_X[j].getHG();
                height_Y[j] = inter_Y[j].getHG();
            }
            #endregion

            //Заполняем массивы для функции
            #region
            for (int j = 0; j < Program.r + 2; j++)
            {
                if (j == 0)
                {
                    func_X[j] = 0;
                    func_int_X[j] = inter_X[j].getF() - h_X;

                    func_Y[j] = 0;
                    func_int_Y[j] = inter_Y[j].getF() - h_Y;
                }
                else
                {
                    if (j == 8)
                    {
                        func_X[j] = func_X[j - 1];
                        func_int_X[j] = verh_X[j - 1];

                        func_Y[j] = func_Y[j - 1];
                        func_int_Y[j] = verh_Y[j - 1];
                    }
                    else
                    {
                        func_X[j] = inter_X[j - 1].getFunc();
                        func_int_X[j] = verh_X[j - 1];

                        func_Y[j] = inter_Y[j - 1].getFunc();
                        func_int_Y[j] = verh_Y[j - 1];
                    }
                }

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
            all_average_X_in_degree_two /= Program.N;
            all_average_Y_in_degree_two /= Program.N;
            #endregion

            //Дисперсия для X
            dispers_X = ((all_average_X_in_degree_two - Math.Pow(all_average_X, 2)) * Program.N) / (Program.N - 1);

            //Дисперсия для Y
            dispers_Y = ((all_average_Y_in_degree_two - Math.Pow(all_average_Y, 2)) * Program.N) / (Program.N - 1);

            //Средне-квадратичное отклонение X
            sred_kvadr_X = Math.Sqrt(dispers_X);

            //Средне-квадратичное отклонение Y
            sred_kvadr_Y = Math.Sqrt(dispers_Y);

            //Точеченые оценки с помощью перехода
            #region
            maxN_X = 0; maxN_Y = 0;
            index_X = 0; index_Y = 0;

            //Нахожу среднее значение интервала, у которого максимальное количество элементов
            for (int j = 0; j < Program.r; j++)
            {
                if (inter_X[j].getN() > maxN_X)
                {
                    maxN_X = inter_X[j].getN();
                    index_X = j;
                }

                if (inter_Y[j].getN() > maxN_Y)
                {
                    maxN_Y = inter_Y[j].getN();
                    index_Y = j;
                }
            }

            //Для таблицы условных величин
            for (int j = 0; j < Program.r; j++)
            {
                //Сами условные величины
                uslov_vel_X[j] = (inter_X[j].getA() - inter_X[index_X].getA()) / 2;
                //Сумма всех одинаковых условных величин
                sum_uslov_vel_X[j] = uslov_vel_X[j] * inter_X[j].getN();
                //Квадрат суммы равных условных величин
                kv_sum_uslov_vel_X[j] = sum_uslov_vel_X[j] * uslov_vel_X[j];

                uslov_vel_Y[j] = (inter_Y[j].getA() - inter_X[index_Y].getA()) / 2;
                sum_uslov_vel_Y[j] = uslov_vel_Y[j] * inter_Y[j].getN();
                kv_sum_uslov_vel_Y[j] = sum_uslov_vel_Y[j] * uslov_vel_Y[j];
            }


            for (int j = 0; j < Program.r; j++)
            {
                all_average_uslov_X += sum_uslov_vel_X[j];
                all_average_uslov_X_in_two += kv_sum_uslov_vel_X[j];

                all_average_uslov_Y += sum_uslov_vel_Y[j];
                all_average_uslov_Y_in_two += kv_sum_uslov_vel_Y[j];
            }
            //Мат ожидание
            all_average_uslov_X /= Program.N;
            all_average_uslov_Y /= Program.N;

            //Мат ожидание квадратов
            all_average_uslov_X_in_two /= Program.N;
            all_average_uslov_Y_in_two /= Program.N;

            //Дисперсия
            dispers_uslov_X = ((all_average_uslov_X_in_two - Math.Pow(all_average_uslov_X, 2)) * Program.N) / (Program.N - 1);
            dispers_uslov_Y = ((all_average_uslov_Y_in_two - Math.Pow(all_average_uslov_Y, 2)) * Program.N) / (Program.N - 1);

            //Средне-квадратичное отклонение
            sred_kvadr_uslov_X = Math.Sqrt(dispers_uslov_X);
            sred_kvadr_uslov_Y = Math.Sqrt(dispers_uslov_Y);

            //Переход от условных к нормальным
            all_average_uslov_X_vivod = h_X * all_average_uslov_X + inter_X[index_X].getA();
            dispers_uslov_X_vivod = Math.Pow(h_X, 2) * dispers_uslov_X;
            sred_kvadr_uslov_X_vivod = Math.Sqrt(dispers_uslov_X_vivod);

            all_average_uslov_Y_vivod = h_Y * all_average_uslov_Y + inter_Y[index_Y].getA();
            dispers_uslov_Y_vivod = Math.Pow(h_Y, 2) * dispers_uslov_Y;
            sred_kvadr_uslov_Y_vivod = Math.Sqrt(dispers_uslov_Y_vivod);
        }
        #endregion

            
    }
}
