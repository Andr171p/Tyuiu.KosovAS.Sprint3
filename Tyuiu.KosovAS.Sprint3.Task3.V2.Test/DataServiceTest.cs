using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint3.Task3.V2.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            
            string value = "asdzzz vfvfzz v gthvz";
            char item = 'z';

            Assert.AreEqual(3, ds.GetMaxCharCount(value, item));
        }
    }
}
