using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint1.Task5.V5.Lib;

namespace Tyuiu.UleevRI.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 37.85;
            int res = ds.Calculate(x);
            int wait = 8;
            Assert.AreEqual(res, wait);
        }
    }
}
