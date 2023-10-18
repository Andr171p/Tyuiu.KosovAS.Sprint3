using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint3.Task0.V22.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double a = 0.25;
            int start = 1;
            int stop = 8;
            Assert.AreEqual(55217.446, ds.GetMultiplySeries(a, start, stop));
        }
    }
}
