using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.Reutovza.Sprint1.Task5.V7.Lib;

//ЗАДАНИЕ
//Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня), когда часовая стрелка повернулась на f 
//градусов (0<f<360, f – вещественное число).

namespace Tyuiu.Reutovza.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите f (градусы):");
            double f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.AngleToHoursMinutes(f));
            Console.WriteLine("Полное количество часов: " + res);

            Console.ReadKey();

        }
    }
}