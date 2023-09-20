using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint1.Task2.V22.Lib;

namespace Tyuiu.UleevRI.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 1;
            int valueTwo = 2;
            int valueThree = 3;
            var res = ds.CalculateAVGValue(value, valueTwo, valueThree);
            Assert.AreEqual(2, res);
        }
    }
}
