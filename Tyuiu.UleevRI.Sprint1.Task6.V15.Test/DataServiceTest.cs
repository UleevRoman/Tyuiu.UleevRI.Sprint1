using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.UleevRI.Sprint1.Task6.V15.Lib;

namespace Tyuiu.UleevRI.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string value = "dgddfgf_dfg()+gggk!!";
            bool res = ds.CheckLettersCount(value);
            bool wait = true;
            Assert.AreEqual(res, wait);
            
        }
    }
}
