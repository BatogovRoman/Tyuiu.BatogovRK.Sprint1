using Tyuiu.BatogovRK.Sprint1.Task6.V15.Lib;

namespace Tyuiu.BatogovRK.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string test = ".. ..ро.. ...браб.. ...ар";
            bool res = ds.CheckLettersCount(test);
            bool need = false;
            Assert.AreEqual(need, res);
        }
    }
}
