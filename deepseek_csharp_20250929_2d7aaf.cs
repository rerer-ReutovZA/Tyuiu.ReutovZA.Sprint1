// DataServiceTest.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ReutovZA.Sprint1.Task7.V27.Lib;

namespace Tyuiu.ReutovZA.Sprint1.Task7.V27.Test
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
            double wait = 1.229;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}