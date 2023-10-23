using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint3.Task6.V13.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int start = 8;
            int end = 17;

            Assert.AreEqual(117, ds.GetSumTheDivisors(start, end));
        }
    }
}
