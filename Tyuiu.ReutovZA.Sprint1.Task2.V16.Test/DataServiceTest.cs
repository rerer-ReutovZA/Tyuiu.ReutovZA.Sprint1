using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ReutovZA.Sprint1.Task2.V16.Lib;

namespace Tyuiu.ReutovZA.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateCirclePerimeter()
        {
            DataService ds = new DataService();
            int radius = 5;
            double result = ds.CalculatePerimetrCircle(radius);
            double wait = 31.416;
            Assert.AreEqual(wait, result, 0.001);
        }
    }
}