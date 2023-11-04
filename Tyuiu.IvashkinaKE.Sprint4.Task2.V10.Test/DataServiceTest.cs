using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint4.Task2.V10.Lib;

namespace Tyuiu.IvashkinaKE.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 1, 2, 5, 2, 3, 4, 2, 6, 2, 5, 6, 4, 3, 5, 3 };
            int res = ds.Calculate(numsArray);
            int wait = 3375;

            Assert.AreEqual(wait, res);
        }
    }
}
