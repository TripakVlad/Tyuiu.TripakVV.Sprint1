using Tyuiu.TripakVV.Sprint1.Task1.V5.Lib;

namespace Tyuiu.TripakVV.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 3.125);
        }
    }
}