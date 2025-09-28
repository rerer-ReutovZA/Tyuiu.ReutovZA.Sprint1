using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ReutovZA.Sprint1.Task7.V18.Lib;

namespace Tyuiu.ReutovZA.Sprint1.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1.437;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}