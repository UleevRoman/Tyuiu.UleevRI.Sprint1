using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint1.Task2.V22.Lib;

namespace Tyuiu.UleevRI.Sprint1.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Улеев Р.И. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Арифмитические операторы в C#                                     *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Улеев Роман Игоревич | ИИПБ-23-3                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int value, valueTwo, valueThree;
            Console.WriteLine("Введите значение value:");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение valueTwo:");
            valueTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение valueThree:");
            valueThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Среднее значение чисел равно = " + ds.CalculateAVGValue(value, valueTwo, valueThree));
            Console.ReadLine();
        }
    }
}
