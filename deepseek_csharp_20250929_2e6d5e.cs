// DataService.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.ReutovZA.Sprint1.Task7.V27.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double cosX = Math.Cos(x);
            double sinY = Math.Sin(y);
            
            double numerator1 = Math.Pow(cosX, 2) + Math.Pow(sinY, 2);
            double denominator1 = sinY + 1;
            double firstPart = numerator1 / denominator1;

            double numerator2 = x * y - 12;
            double denominator2 = 15 + cosX;
            double secondPart = numerator2 / denominator2;

            double result = firstPart - secondPart;
            return Math.Round(result, 3);
        }
    }
}