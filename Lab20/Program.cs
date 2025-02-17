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
             -объем шара.Формула V = 4 / 3 * π * R³;
             -площадь полной поверхности прямого кругового цилиндра S = 2 * π * R * (R + h).
            */ //формулы
            while (true)
            {
                Console.WriteLine("Введите код операции:\n 1. Вычисление длины окружности" +
                    "\n 2. Вычисление площади круга" +
                    "\n 3. Вычисление объема шара" +
                    "\n 4. Вычисление площади поверхности прямого кругового цилиндра"); //консоль
                int operation = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите радиус:");
                double r;//преобразование строкового представления числа в вещественное число с плавающей запятой
                while (!double.TryParse(Console.ReadLine(),out r))
                {

                    Console.WriteLine("Введите число!");
                }

                //преобразование строкового представление числа в эквивалентное ему 32-битовое целое число
                if (operation == 1) //приравнивание к 1 методу
                {
                    Func<double, double> calcCircumFerence = Metod1;
                    double answer = calcCircumFerence(r); // применение встроенной функции на нахождение длины окружности
                    Console.WriteLine("Ответ: {0:f2}", answer); //вычисление длины окружности, получение ответа
                }
                else
                {
                    if (operation == 2) //приравнивание ко 2 методу
                    {
                        Func<double, double> calcCircumSquare = Metod2;
                        double answer = calcCircumSquare(r); // применение встроенной функции на нахождение площади круга
                        Console.WriteLine("Ответ: {0:f2}", answer); //получение ответа
                    }
                    else
                    {
                        if (operation == 3) //приравнивание к 3 методу
                        {
                            Func<double, double> calcSphereVolume = Metod3;
                            double answer = calcSphereVolume(r); // применение встроенной функции на нахождение объёма шара
                            Console.WriteLine("Ответ: {0:f2}", answer); //получение ответа
                        }

                        if (operation == 4) //приравнивание к 4 методу
                        {
                            Console.WriteLine("Введите h");
                            int h = int.Parse(Console.ReadLine());
                            double answer = calcCilindrSquare(r, h); // применение встроенной функции на нахождение объёма шара
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
        }
        static double Metod1(double R)
        {
            Console.WriteLine("D=2*PI*R");
            return 2 * Math.PI * R; // применение формулы
        }
        static double Metod2(double R)
        {
            Console.WriteLine("S=PI*R^2");
            return Math.PI * Math.Pow(R, 2); // применение формулы
        }
        static double Metod3(double R)
        {
            Console.WriteLine("V=4/3*PI*R^3");
            return 4 * Math.PI * Math.Pow(R, 3) / 3; // применение формулы
        }

        static double calcCilindrSquare(double R, double h)
        {
            Console.WriteLine("S=2*PI*R*(R+h)");
            return 2 * Math.PI * R * (R + h); // применение формулы
        }
    }
}
