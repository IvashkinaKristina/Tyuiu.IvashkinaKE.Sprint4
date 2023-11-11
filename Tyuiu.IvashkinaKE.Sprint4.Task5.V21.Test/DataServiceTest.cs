using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint4.Task5.V21.Lib;

namespace Tyuiu.IvashkinaKE.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { -8, 2, -5, 1, 0 },
                                          { -3, -2, -4, 2, 2 },
                                          { -6, 1, 2, -6, -3 },
                                          { -2, -3, -4, 2, 0 },
                                          { 1, 2, 2, -5, -8 } };
            int[,] res = ds.Calculate(mas2);
            int[,] wait = new int[5, 5] { { -8, 1, -5, 1, 0 },
                                          { -3, -2, -4, 1, 1 },
                                          { -6, 1, 1, -6, -3 },
                                          { -2, -3, -4, 1, 0 },
                                          { 1, 1, 1, -5, -8 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
