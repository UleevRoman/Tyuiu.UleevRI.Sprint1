using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint1.Task4.V9.Lib;

namespace Tyuiu.UleevRI.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            double wait = -1.542;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
