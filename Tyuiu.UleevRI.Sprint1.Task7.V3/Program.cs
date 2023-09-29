using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.UleevRI.Sprint1.Task7.V3.Lib;

namespace Tyuiu.UleevRI.Sprint1.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Улеев Р.И. | ИИПБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спритну                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 3                                                               *");
            Console.WriteLine("* Выполнил: Улеев Роман Игоревич | ИИПБ-23-3                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите      *");
            Console.WriteLine("* знаков после запятой.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*             (3 + e^(y-1))                                               *");
            Console.WriteLine("*             -------------                                               *");
            Console.WriteLine("*        (1 + x^2 * |y - tg(x)|)                                          *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();
        }
    }
}
