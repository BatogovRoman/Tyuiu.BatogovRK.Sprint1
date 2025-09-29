using Tyuiu.BatogovRK.Sprint1.Task7.V25.Lib;

namespace Tyuiu.BatogovRK.Sprint1.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double res = ds.Calculate(x, y);
            double need = 20.231;
            Assert.AreEqual(need, res);

        }
    }
}
