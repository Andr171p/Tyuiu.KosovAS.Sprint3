using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint3.Task1.V13.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double n = 1.2;
            int start = 1;
            int stop = 7;

            Assert.AreEqual(164.845, ds.GetMultiplySeries(n, start, stop));
        }
    }
}
