using Tyuiu.TripakVV.Sprint1.Task6.V1.Lib;

namespace Tyuiu.TripakVV.Sprint1.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string x = "1";
            var res = "49";
            Assert.AreEqual(res, ds.SymbolCode(x));
        }
    }
}