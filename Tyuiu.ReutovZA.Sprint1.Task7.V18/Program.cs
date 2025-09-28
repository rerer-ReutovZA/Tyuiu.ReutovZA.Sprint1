using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ReutovZA.Sprint1.Task7.V18.Lib;

//Написать программу, которая вычисляет математическое выражение 
//по исходным значениям данных, вводимых пользователем.
//z = (1 + sin²(x + y)) / (2 + |x - (2x)/(1 + x²y)|) + x

namespace Tyuiu.ReutovZA.Sprint1.Task7.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("      z = (1 + sin²(x + y)) / (2 + |x - (2x)/(1 + x²y)|) + x");
            Console.WriteLine();

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.Calculate(x, y);
            Console.WriteLine($"z = {result:F3}");
            Console.ReadKey();

        }
    }
}