using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.ReutovZA.Sprint1.Task1.V23.Lib;

namespace Tyuiu.ReutovZA.Sprint1.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double a = 1.0;
            var res = ds.Calculate(x, a);
            Assert.AreEqual(1.57, res);
                
        }
    }
}
