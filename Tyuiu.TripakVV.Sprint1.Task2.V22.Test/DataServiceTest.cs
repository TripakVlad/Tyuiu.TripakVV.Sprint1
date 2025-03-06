using Tyuiu.TripakVV.Sprint1.Task2.V22.Lib;

namespace Tyuiu.TripakVV.Sprint1.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 124;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(res, 0, 124);
        }
    }
}