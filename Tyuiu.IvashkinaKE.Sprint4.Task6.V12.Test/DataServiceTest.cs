using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.IvashkinaKE.Sprint4.Task6.V12.Lib;

namespace Tyuiu.IvashkinaKE.Sprint4.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] country = { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };
            string[] res = ds.Calculate(country);
            string[] wait = { "Украина", "Молдова", "Эстония" };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
