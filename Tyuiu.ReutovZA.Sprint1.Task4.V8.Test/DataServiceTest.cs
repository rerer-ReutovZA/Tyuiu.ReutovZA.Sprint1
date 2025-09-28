using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ReutovZA.Sprint1.Task4.V8.Lib;

namespace Tyuiu.ReutovZA.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = 1.200;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}