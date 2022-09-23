using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //подключение пространств имен

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
             -длину окружности по формуле D = 2 * π * R;
             -площадь круга по формуле S = π * R²;
             -объем шара.Формула V = 4 / 3 * π * R³.
            */ //формулы

            Console.WriteLine("Калькулятор расчета геометрических фигур по радиусу!\n\nВведите радиус:");
            double r = Convert.ToDouble(Console.ReadLine()); //преобразование строкового представления числа в вещественное число с плавающей запятой
            Console.WriteLine("Введите код операции:\n1. Вычисление длины окружности\n2. Вычисление площади круга\n3. Вычисление объема шара"); //консоль
            int operation = Convert.ToInt32(Console.ReadLine()); //преобразование строкового представление числа в эквивалентное ему 32-битовое целое число
            if (operation == 1) //приравнивание к первому методу
            {
                Func<double, double> calcCircumFerence = Metod1;
                double answer = calcCircumFerence(r); // применение встроенной функции на нахождение длины окружности
                Console.WriteLine("Ответ: {0:f2}", answer); //вычисление длины окружности, получение ответа
            }
            else
            {
                if (operation == 2) //приравнивание ко второму методу
                {
                    Func<double, double> calcCircumSquare = Metod2; 
                    double answer = calcCircumSquare(r); // применение встроенной функции на нахождение площади круга
                    Console.WriteLine("Ответ: {0:f2}", answer); //получение ответа
                } 
                else
                {
                    if (operation == 3) //приравнивание к третьему методу
                    {
                        Func<double, double> calcSphereVolume = Metod3;
                        double answer = calcSphereVolume(r); // применение встроенной функции на нахождение объёма шара
                        Console.WriteLine("Ответ: {0:f2}", answer); //получение ответа
                    }
                    else
                    {
                        Console.WriteLine("Введен недопустимый номер операции"); //проверка
                    }

                }

            }
            Console.ReadKey();
        }
        static double Metod1(double R)
        {
            return 2 * Math.PI * R; // применение формулы
        }
        static double Metod2(double R)
        {
            return Math.PI * Math.Pow(R, 2); // применение формулы
        }
        static double Metod3(double R)
        {
            return 4 * Math.PI * Math.Pow(R, 3) / 3; // применение формулы
        }
    }
}
