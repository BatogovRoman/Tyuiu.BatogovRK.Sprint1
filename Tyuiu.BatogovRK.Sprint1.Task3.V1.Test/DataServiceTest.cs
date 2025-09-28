using Tyuiu.BatogovRK.Sprint1.Task3.V1.Lib;

namespace Tyuiu.BatogovRK.Sprint1.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double r = 2;
            double h = 3;
            var res = ds.CylinderVolume(r, h);
            Assert.AreEqual(37.699, res);
        }
    }
}
