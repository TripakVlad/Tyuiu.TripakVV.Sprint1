using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TripakVV.Sprint1.Task0.V5.Lib;

namespace Tyuiu.TripakVV.Sprint1.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(15, res);
        }
            
    }
}