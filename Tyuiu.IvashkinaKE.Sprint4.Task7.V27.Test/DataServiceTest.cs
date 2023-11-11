using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint4.Task7.V27.Lib;

namespace Tyuiu.IvashkinaKE.Sprint4.Task7.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            
            int rows = 4;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];
            string str = "583197256891";
            DataService ds = new DataService();
            double res = ds.Calculate(rows, columns, str);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
