using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint2.Task5.V13.Lib;

namespace Tyuiu.NovikovNS.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidNextDayDate()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 2;
            int n = 29;
            string res = ds.FindDateOfNextDay(g, m, n);
            string wait = "01.03.2024";
            Assert.AreEqual(wait,res);
        }
    }
}
