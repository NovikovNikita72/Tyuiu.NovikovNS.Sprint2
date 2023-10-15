using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NovikovNS.Sprint2.Task6.V4.Lib;

namespace Tyuiu.NovikovNS.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit()
        {
            DataService ds = new DataService();
            int value = 1;
            string res = ds.FindCardSuit(value);
            string wait = "пики";
            Assert.AreEqual(wait, res);
        }
    }
}
