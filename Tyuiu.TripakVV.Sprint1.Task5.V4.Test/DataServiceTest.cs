using Tyuiu.TripakVV.Sprint1.Task5.V4.Lib;

namespace Tyuiu.TripakVV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.DistanceBetweenDots(0, 0, 3, 0);
            Assert.AreEqual(res, 3);
        }
    }
}