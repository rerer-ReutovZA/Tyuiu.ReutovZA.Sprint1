using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ReutovZA.Sprint1.Task7.V18.Lib
{
    public class DataService : ISprint1Task7V18
    {
        public double Calculate(double x, double y)
        {
            double sinSum = Math.Sin(x + y);
            double numerator = 1 + Math.Pow(sinSum, 2);

            double denominatorPart1 = (2 * x) / (1 + Math.Pow(x, 2) * y);
            double denominatorPart2 = 2 + Math.Abs(x - denominatorPart1);

            double result = numerator / denominatorPart2 + x;
            return Math.Round(result, 3);
        }
    }
}