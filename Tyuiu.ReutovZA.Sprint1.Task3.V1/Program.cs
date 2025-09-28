using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ReutovZA.Sprint1.Task3.V1.Lib;

//ЗАДАНИЕ
//Написать программу, которая запрашивает у пользователя исходные данные,
//выполняет указанные расчёты и печатает результат на экране.
//Расчеты: Объявите необходимые переменные и напишите программу вычисления  объема цилиндра.

namespace Tyuiu.ReutovZA.Sprint1.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите радиус цилиндра: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту цилиндра: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Радиус цилиндра = " + radius);
            Console.WriteLine("Высота цилиндра = " + height);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double volume = ds.CylinderVolume(radius, height);
            Console.WriteLine("Объем цилиндра = " + Math.Round(volume, 3));


            Console.ReadKey();

        }
    }
}