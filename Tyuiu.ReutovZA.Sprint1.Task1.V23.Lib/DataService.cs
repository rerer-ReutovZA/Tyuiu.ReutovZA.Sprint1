using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ReutovZA.Sprint1.Task1.V23.Lib
{
    public class DataService : ISprint1Task1V23
    {
        public double Calculate(double a, double x)
        {
            return (x * 3.14) / (2 * a);
        }
    }
}
