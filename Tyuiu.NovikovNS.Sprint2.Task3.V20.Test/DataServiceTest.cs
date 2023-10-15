using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint2.Task3.V20.Lib;

namespace Tyuiu.NovikovNS.Sprint2.Task3.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = 0.07;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = Math.Round(ds.Calculate(x), 3);
            double wait = 4;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -25;
            double res = Math.Round(ds.Calculate(x),3);
            double wait = -274.96;
            Assert.AreEqual(wait, res);
        }
    }
}
