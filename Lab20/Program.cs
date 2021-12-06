using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
             -длину окружности по формуле D = 2 * π * R;
             -площадь круга по формуле S = π * R²;
             -объем шара.Формула V = 4 / 3 * π * R³.
            */

            Console.WriteLine("Калькулятор расчета геометрических фигур по радиусу!\n\nВведите радиус:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите код операции:\n1. Вычисление длины окружности\n2. Вычисление площади круга\n3. Вычисление объема шара");
            int operation = Convert.ToInt32(Console.ReadLine());
            if (operation == 1)
            {
                Func<double, double> calcCircumFerence = Metod1;
                double answer = calcCircumFerence(r);
                Console.WriteLine("Ответ: {0:f2}", answer);
            }
            else
            {
                if (operation == 2)
                {
                    Func<double, double> calcCircumSquare = Metod2;
                    double answer = calcCircumSquare(r);
                    Console.WriteLine("Ответ: {0:f2}", answer);
                }
                else
                {
                    if (operation == 3)
                    {
                        Func<double, double> calcSphereVolume = Metod3;
                        double answer = calcSphereVolume(r);
                        Console.WriteLine("Ответ: {0:f2}", answer);
                    }
                    else
                    {
                        Console.WriteLine("Введен недопустимый номер операции");
                    }

                }

            }
            Console.ReadKey();
        }
        static double Metod1(double R)
        {
            return 2 * Math.PI * R;
        }
        static double Metod2(double R)
        {
            return Math.PI * Math.Pow(R, 2);
        }
        static double Metod3(double R)
        {
            return 4 * Math.PI * Math.Pow(R, 3) / 3;
        }
    }
}
