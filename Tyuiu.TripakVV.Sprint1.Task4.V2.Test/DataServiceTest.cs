using Tyuiu.TripakVV.Sprint1.Task4.V2.Lib;

namespace Tyuiu.TripakVV.Sprint1.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 124;
            var res = ds.Calculate(3, 3);
            Assert.AreEqual(res, 6);
        }
    }
}