using Tyuiu.TripakVV.Sprint1.Task3.V9.Lib;

namespace Tyuiu.TripakVV.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 124;
            var res = ds.TriangleArea(0, 0, 0, 3, 4, 0);
            Assert.AreEqual(res, 6);
        }
    }
}

