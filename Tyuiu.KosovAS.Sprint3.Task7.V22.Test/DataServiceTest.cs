using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint3.Task7.V22.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] valueWaitArray = new double[(stopValue - startValue) + 1];

            valueWaitArray[0] = 8.039;
            valueWaitArray[1] = 6.684;
            valueWaitArray[2] = 4.839;
            valueWaitArray[3] = 1.764;
            valueWaitArray[4] = 0.450;
            valueWaitArray[5] = 0.500;
            valueWaitArray[6] = -0.867;
            valueWaitArray[7] = -2.418;
            valueWaitArray[8] = -3.879;
            valueWaitArray[9] = -6.830;
            valueWaitArray[10] = -8.878;

            CollectionAssert.AreEqual(valueWaitArray, ds.GetMassFunction(startValue, stopValue));
        }
    }
}
