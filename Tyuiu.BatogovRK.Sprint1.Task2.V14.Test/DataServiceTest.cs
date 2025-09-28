using Tyuiu.BatogovRK.Sprint1.Task2.V14.Lib;

namespace Tyuiu.BatogovRK.Sprint1.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 0;
            var res = ds.ConvertKelvinToCelsius(x);
            Assert.AreEqual(- 273, res);
        }
    }
}
