using Tyuiu.BatogovRK.Sprint1.Task0.V12.Lib;

namespace Tyuiu.BatogovRK.Sprint1.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var res = ds.Calculate();

            Assert.AreEqual(6, res);
        }
    }
}
