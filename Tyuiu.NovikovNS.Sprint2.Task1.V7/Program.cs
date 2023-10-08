using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NovikovNS.Sprint2.Task1.V7.Lib;

namespace Tyuiu.NovikovNS.Sprint2.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Новиков Н. С. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Новиков Никита Сергеевич | ИСТНб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений  (==, !=, <, >, <=, >=,        *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность*");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
            Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
            Console.WriteLine("* (True, False, False, False, True, False),                               *");
            Console.WriteLine("* при a = 195, b = 16, c = 14, d = 45                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 195;
            int b = 16;
            int c = 14;
            int d = 45;

            bool[] res = new bool[6];
            res = ds.GetCompareOperations(a,b,c,d);

            Console.WriteLine("Значение A = " + a);
            Console.WriteLine("Значение B = " + b);
            Console.WriteLine("Значение C = " + c);
            Console.WriteLine("Значение D = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
