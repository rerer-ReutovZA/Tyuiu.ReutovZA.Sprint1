using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ReutovZA.Sprint1.Task2.V16.Lib
{
    public class DataService : ISprint1Task2V16
    {
        public double CalculatePerimetrCircle(int value)
        {
            double perimeter = 2 * Math.PI * value;
            return Math.Round(perimeter, 3);
        }
    }
}