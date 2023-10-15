using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint2.Task4.V4.Lib;

namespace Tyuiu.NovikovNS.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 7;
            double y = 10;
            double res = Math.Round(ds.Calculate(x, y),3);
            double wait = 20.657;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 8;
            double y = 10;
            double res = Math.Round(ds.Calculate(x, y),3);
            double wait = 159.161;
            Assert.AreEqual(wait, res);
        }
    }
}
