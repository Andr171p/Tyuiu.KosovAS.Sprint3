using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint3.Task5.V6.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int start1 = 1; int stop1 = 3;
            int start2 = 1; int stop2 = 10;

            Assert.AreEqual(40.917, ds.GetSumSumSeries(start1, start2, stop1, stop2));
        }
    }
}
