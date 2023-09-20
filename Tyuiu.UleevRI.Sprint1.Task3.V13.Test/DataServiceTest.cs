using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint1.Task3.V13.Lib;

namespace Tyuiu.UleevRI.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 123;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(6, res);
        }
    }
}
