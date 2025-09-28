<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ReutovZA.Sprint1.Task2.V16.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.

//Формулировка задания: Известен радиус круга. Вычислить примерный периметр круга. Ответ округлите до 3 знаков после запятой.

//Что пользователь вводит? Радиус круга (целое число)

//Что программа печатает на экране? Периметр круга (вещественное число)

namespace Tyuiu.ReutovZA.Sprint1.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.CalculatePerimetrCircle(x);
            Console.WriteLine($"Периметр круга  = {result:F3}");


            Console.ReadLine();
        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ReutovZA.Sprint1.Task2.V16.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.

//Формулировка задания: Известен радиус круга. Вычислить примерный периметр круга. Ответ округлите до 3 знаков после запятой.

//Что пользователь вводит? Радиус круга (целое число)

//Что программа печатает на экране? Периметр круга (вещественное число)

namespace Tyuiu.ReutovZA.Sprint1.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите :");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.CalculatePerimetrCircle(x);
            Console.WriteLine($"Периметр круга =  {result:F3}");


            Console.ReadLine();
        }
    }
>>>>>>> 01e8a873643ed11904ebbe695aca8ddd876d276b
}