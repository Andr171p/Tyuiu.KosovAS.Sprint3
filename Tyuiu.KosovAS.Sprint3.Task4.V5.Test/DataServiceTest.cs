using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint3.Task4.V5.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            Assert.AreEqual(-1.924, ds.Calculate(start, stop));
        }
    }
}
