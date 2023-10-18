using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint3.Task2.V8.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            Assert.AreEqual(0.001, ds.GetMultiplySeries(startValue, stopValue));
        }
    }
}
