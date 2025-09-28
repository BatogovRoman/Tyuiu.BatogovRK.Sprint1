using Tyuiu.BatogovRK.Sprint1.Task4.V3.Lib;

namespace Tyuiu.BatogovRK.Sprint1.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 3.9;
            double need = 3.201;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(need, res);
        }
    }
}
