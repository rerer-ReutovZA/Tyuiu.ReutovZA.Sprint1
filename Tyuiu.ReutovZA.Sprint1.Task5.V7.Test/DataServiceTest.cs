using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.Reutovza.Sprint1.Task5.V7.Lib;

namespace Tyuiu.Reutovza.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 90.0; // 3 часа вроде я устал спасите меня 
            DataService ds = new DataService();
            double res = ds.AngleToHoursMinutes(f);

            int result = Convert.ToInt32(res);

            int wait = 3;
            Assert.AreEqual(wait, result);

        }
    }
}