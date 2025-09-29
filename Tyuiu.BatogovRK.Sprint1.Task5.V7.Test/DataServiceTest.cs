using System.Runtime.InteropServices;
using Tyuiu.BatogovRK.Sprint1.Task5.V7.Lib;

namespace Tyuiu.BatogovRK.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 115.0;
            double res = ds.AngleToHoursMinutes(x);
            int result = Convert.ToInt32(res);
            int need = 3;
            Assert.AreEqual(need, result);
        }
    }
}
