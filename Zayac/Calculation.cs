using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace Zayac
{
    public class Calculation
    {
        public double lap;

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
        public double[] height_X = new double[Program.r];

        public double[] verh_Y = new double[Program.r + 1];
        public double[] height_Y = new double[Program.r];

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

        public int index_X, index_Y;

        //Переход к условным величинам
        public double[] uslov_vel_X = new double[Program.r];
        public double[] uslov_vel_Y = new double[Program.r];

        public double[] sum_uslov_vel_X = new double[Program.r];
        public double[] sum_uslov_vel_Y = new double[Program.r];

        public double[] kv_sum_uslov_vel_X = new double[Program.r];
        public double[] kv_sum_uslov_vel_Y = new double[Program.r];

        public double all_average_uslov_X, all_average_uslov_Y;
        public double all_average_uslov_X_in_two, all_average_uslov_Y_in_two;
        public double dispers_uslov_X, dispers_uslov_Y;
        public double sred_kvadr_uslov_X, sred_kvadr_uslov_Y;

        public double all_average_uslov_X_vivod, all_average_uslov_Y_vivod;
        public double dispers_uslov_X_vivod, dispers_uslov_Y_vivod;
        public double sred_kvadr_uslov_X_vivod, sred_kvadr_uslov_Y_vivod;

        //Массив показателей объединения
        public char[] flags_X;
        public char[] flags_Y;

        public double[] norm_vel_X = new double[Program.r];
        public double[] norm_vel_Y = new double[Program.r];

        public double[] form_lap_X = new double[Program.r];
        public double[] form_lap_Y = new double[Program.r];

        public double[] ver_sob_X = new double[Program.r];
        public double[] ver_sob_Y = new double[Program.r];

        public double[] teor_znach_X = new double[Program.r];
        public double[] teor_znach_Y = new double[Program.r];

        public double[] teor_vel_X;
        public double[] teor_vel_Y;

        public Intervals[] new_inter_X;
        public Intervals[] new_inter_Y;

        public double[] dlya_stat_X;
        public double[] dlya_stat_Y;

        public double hi_X, hi_Y;
        public int d_X, d_Y;

        // Доверительный интервал
        public double dover_P = 0.95;
        public double dover_inter_MX_min;
        public double dover_inter_MX_max;

        public double dover_inter_MY_min;
        public double dover_inter_MY_max;

        public double dover_inter_DX_min;
        public double dover_inter_DX_max;

        public double dover_inter_DY_min;
        public double dover_inter_DY_max;


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

            hi_X = hi_Y = 0;

            lap = (1 / Math.Sqrt(2 * Math.PI));

            flags_X = new char[Program.r - 1] { (char)0, (char)0, (char)0, (char)0, (char)0, (char)0 };
            flags_Y = new char[Program.r - 1] { (char)0, (char)0, (char)0, (char)0, (char)0, (char)0 };
        }

        public double getQuant(int k, double p)
        {
            int index_p;
            if (p <= 0.005)
                index_p = 0;
            else if (p <= 0.01)
                index_p = 1;
            else if (p <= 0.025)
                index_p = 2;
            else if (p <= 0.05)
                index_p = 3;
            else if (p <= 0.1)
                index_p = 4;
            else if (p <= 0.9)
                index_p = 5;
            else if (p <= 0.95)
                index_p = 6;
            else if (p <= 0.975)
                index_p = 7;
            else if (p <= 0.99)
                index_p = 8;
            else if (p <= 0.995)
                index_p = 9;
            else
                index_p = 10;

            if (k > 30 && k < 35)
                k = 30;
            else if (k > 35 && k < 40)
                k = 31;
            else if (k > 40 && k < 45)
                k = 32;
            else if (k > 45 && k < 50)
                k = 33;
            else if (k > 50 && k < 75)
                k = 34;
            else if (k > 75 && k < 100)
                k = 35;

                using (FileStream fstream = File.OpenRead("tableQuant.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream.Length];
                // считываем данные
                fstream.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                string[] s = textFromFile.Split('\n');
                string[] s1 = s[k - 1].Split(' ');
                double x = Convert.ToDouble(s1[index_p]);
                return x;
            }
        }

        public double getQuantStud(double p, int k)
        {
            int index_p;
            if (p <= 0.55)
                index_p = 0;
            else if (p <= 0.60)
                index_p = 1;
            else if (p <= 0.65)
                index_p = 2;
            else if (p <= 0.7)
                index_p = 3;
            else if (p <= 0.75)
                index_p = 4;
            else if (p <= 0.8)
                index_p = 5;
            else if (p <= 0.85)
                index_p = 6;
            else if (p <= 0.9)
                index_p = 7;
            else if (p <= 0.95)
                index_p = 8;
            else if (p <= 0.975)
                index_p = 9;
            else if (p <= 0.99)
                index_p = 10;
            else if (p <= 0.995)
                index_p = 11;
            else if (p <= 0.9975)
                index_p = 12;
            else if (p <= 0.999)
                index_p = 13;
            else
                index_p = 14;


            using (FileStream fstream1 = File.OpenRead("tableQuantStud.txt"))
            {
                // преобразуем строку в байты
                byte[] array = new byte[fstream1.Length];
                // считываем данные
                fstream1.Read(array, 0, array.Length);
                // декодируем байты в строку
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                string[] s = textFromFile.Split('\n');
                string[] s1 = s[k - 1].Split('\t');
                string chislo = s1[index_p];
                double x = Convert.ToDouble(chislo);
                return x;
            }
        }


        public void Calculate(String[] fielRead)
        {
            getQuant(20, 0.05);
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
            begin_X = Math.Floor(masX[0]) - Math.Floor(rashirenie_X / 2);

            //Всегда целое значение, менять не нужно
            begin_Y = masY[0] - Math.Floor(rashirenie_Y / 2);

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

            index_X = 3; index_Y = 3;

            //Для таблицы условных величин
            for (int j = 0; j < Program.r; j++)
            {
                //Сами условные величины
                uslov_vel_X[j] = (inter_X[j].getA() - inter_X[index_X].getA()) / h_X;
                //Сумма всех одинаковых условных величин
                sum_uslov_vel_X[j] = uslov_vel_X[j] * inter_X[j].getN();
                //Квадрат суммы равных условных величин
                kv_sum_uslov_vel_X[j] = sum_uslov_vel_X[j] * uslov_vel_X[j];

                uslov_vel_Y[j] = (inter_Y[j].getA() - inter_Y[index_Y].getA()) / h_Y;
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
            #endregion

            //Подсчёт нормального распределения на каждом интервале, нахождение теоретических частот
            #region
            for (int j = 0; j < Program.r; j++)
            {
                
                    norm_vel_X[j] = (inter_X[j].getS() - all_average_X) / sred_kvadr_X;
                    norm_vel_Y[j] = (inter_Y[j].getS() - all_average_Y) / sred_kvadr_Y;

                if (j == 6)
                {
                    form_lap_X[j] = 0.5;
                    form_lap_Y[j] = 0.5;
                }
                else 
                {
                    Integral.Function int_lap = Integral.laplas;
                    form_lap_X[j] = Integral.Trapezoidal(int_lap, 0, norm_vel_X[j], Integral.iterasion);
                    form_lap_Y[j] = Integral.Trapezoidal(int_lap, 0, norm_vel_Y[j], Integral.iterasion);

                    form_lap_X[j] *= lap;
                    form_lap_Y[j] *= lap;
                }

                if (j == 0)
                {
                    ver_sob_X[j] = form_lap_X[j] + 0.5;
                    ver_sob_Y[j] = form_lap_Y[j] + 0.5;
                }
                else
                {
                    ver_sob_X[j] = form_lap_X[j] - form_lap_X[j - 1];
                    ver_sob_Y[j] = form_lap_Y[j] - form_lap_Y[j - 1];
                }

                teor_znach_X[j] = ver_sob_X[j] * Program.N;
                teor_znach_Y[j] = ver_sob_Y[j] * Program.N;

            }
            #endregion

            //Объединение интервалов
            #region
             d_X = 0;
             int k_X = 0;
        
             d_Y = 0;
             int k_Y = 0;

            for (int j = 0; j < Program.r; j++)
            {
                //Объединение для X
                if (teor_znach_X[d_X] < 5)
                {
                    if (d_X == 0)
                    {
                        flags_X[d_X]++;
                        teor_znach_X[d_X] += teor_znach_X[j + 1];
                        if (j == (Program.r - 2))
                        {
                            break;
                        }
                    }
                    else
                    {
                        flags_X[k_X]++;
                        teor_znach_X[k_X] += teor_znach_X[d_X];
                        d_X++;
                    }
                }
                else
                {
                    if (d_X != 0)
                        k_X = d_X;

                        d_X = j + 1;
                }

                //Объединение для Y
                if (teor_znach_Y[d_Y] < 5)
                {
                    if (d_Y == 0)
                    {
                        flags_Y[d_Y]++;
                        teor_znach_Y[d_Y] += teor_znach_Y[j + 1];

                        if (j == (Program.r - 2))
                        {
                            break;
                        }
                    }
                    else
                    {
                        flags_Y[k_Y]++;
                        teor_znach_Y[k_Y] += teor_znach_Y[d_Y];
                        d_Y++;
                    }
                }
                else
                {
                    if (d_Y != 0)
                        k_Y = d_Y;

                    d_Y = j + 1;
                }
            }
            
            d_X = 0;
            d_Y = 0;

            for (int j = 0; j < Program.r - 1; j++)
            {
                d_X += flags_X[j];
                d_Y += flags_Y[j];
            }

            d_X = Program.r - d_X;
            d_Y = Program.r - d_Y;

            new_inter_X = new Intervals[d_X];
            new_inter_Y = new Intervals[d_Y];

            teor_vel_X = new double[d_X];
            teor_vel_Y = new double[d_Y];

            for (int j = 0; j < d_X; j++)
            {
                new_inter_X[j] = new Intervals();
            }

            for (int j = 0; j < d_Y; j++)
            {
                new_inter_Y[j] = new Intervals();
            }

            new_inter_X[0].setF(inter_X[0].getF());
            new_inter_X[0].setN(inter_X[0].getN());
            new_inter_Y[0].setF(inter_Y[0].getF());
            new_inter_Y[0].setN(inter_Y[0].getN());

            //Объединение интервалов для X
            k_X = 0;

            for (int j = 0; j < d_X; j++)
            {
                if (j == 0)
                {
                    new_inter_X[j].setS(new_inter_X[j].getF() + h_X + flags_X[k_X] * h_X);
                    k_X += 1 + flags_X[k_X];
                }
                else
                {
                    new_inter_X[j].setF(new_inter_X[j - 1].getS());
                    new_inter_X[j].setS(new_inter_X[j].getF() + h_X + flags_X[k_X] * h_X);
                    k_X += 1 + flags_X[k_X];
                }
            }

            //Объединение интервалов для Y
            k_Y = 0;

            for (int j = 0; j < d_Y; j++)
            {
                if (j == 0)
                {
                    new_inter_Y[j].setS(new_inter_Y[j].getF() + h_Y + flags_Y[k_Y] * h_Y);
                    k_Y += 1 + flags_Y[k_Y];
                }
                else
                {
                    new_inter_Y[j].setF(new_inter_Y[j - 1].getS());
                    new_inter_Y[j].setS(new_inter_Y[j].getF() + h_Y + flags_Y[k_Y] * h_Y);
                    k_Y += 1 + flags_Y[k_Y];
                }
            }


            //Устанавливаем начальное количество выборочных данных для первого интервала
            //new_inter_Y[0].setF(inter_Y[0].getF());
            //new_inter_Y[0].setN(inter_Y[0].getN());

            //Подсчёт колличества выборочных данных на объединённых интервалах для X
            k_X = 0;
            for (int j = 0; j < d_X; j++)
            {
                char count = flags_X[k_X];
                char step = (char)1;
                
                if(j != 0)
                    new_inter_X[j].setN(inter_X[k_X].getN());

               
                    while (count != 0)
                    {
                        new_inter_X[j].setN(new_inter_X[j].getN() + inter_X[k_X + step++].getN());
                        count--;
                    }
                k_X += step;
            }

            //Подсчёт колличества выборочных данных на объединённых интервалах для Y
            k_Y = 0;
            for (int j = 0; j < d_Y; j++)
            {
                char count = flags_Y[k_Y];
                char step = (char)1;

                if (j != 0)
                    new_inter_Y[j].setN(inter_Y[k_Y].getN());


                while (count != 0)
                {
                    new_inter_Y[j].setN(new_inter_Y[j].getN() + inter_Y[k_Y + step++].getN());
                    count--;
                }
                k_Y += step;
            }

            #endregion

            //Вычисление хи-квадрат
            #region
            dlya_stat_X = new double[d_X];
            dlya_stat_Y = new double[d_Y];

            for (int j = 0; j < d_X; j++)
            {
                dlya_stat_X[j] = Math.Pow((new_inter_X[j].getN() - teor_vel_X[j]), 2) / teor_vel_X[j];
                hi_X += dlya_stat_X[j];

                dlya_stat_Y[j] = Math.Pow((new_inter_Y[j].getN() - teor_vel_Y[j]), 2) / teor_vel_Y[j];
                hi_Y += dlya_stat_Y[j];
            }
            #endregion

            #region Доверительный интервал
            dover_inter_MX_min = all_average_X - ((sred_kvadr_X / Math.Sqrt(Program.N)) * getQuantStud(1 - (1 - dover_P) / 2, Program.N - 1));
            dover_inter_MX_max = all_average_X + ((sred_kvadr_X / Math.Sqrt(Program.N)) * getQuantStud(1 - (1 - dover_P) / 2, Program.N - 1));

            dover_inter_MY_min = all_average_Y - ((sred_kvadr_Y / Math.Sqrt(Program.N)) * getQuantStud(1 - (1 - dover_P) / 2, Program.N - 1));
            dover_inter_MY_max = all_average_Y + ((sred_kvadr_Y / Math.Sqrt(Program.N)) * getQuantStud(1 - (1 - dover_P) / 2, Program.N - 1));

            dover_inter_DX_min = ((Program.N - 1) * dispers_X) / getQuant(Program.N - 1, 1 - (1 - dover_P) / 2);
            dover_inter_DX_max = ((Program.N - 1) * dispers_X) / getQuant(Program.N - 1, (1 - dover_P) / 2);

            dover_inter_DY_min = ((Program.N - 1) * dispers_Y) / getQuant(Program.N - 1, 1 - ((1 - dover_P) / 2));
            dover_inter_DY_max = ((Program.N - 1) * dispers_Y) / getQuant(Program.N - 1, ((1 - dover_P) / 2));


            #endregion
        }
    }
}
