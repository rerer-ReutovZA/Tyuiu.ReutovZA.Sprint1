using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ReutovZA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.ReutovZA.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 3;
            double wait = 37.699; 
            double res = Math.Round(ds.CylinderVolume(r, h), 3);
            Assert.AreEqual(wait, res);
        }
    }
}