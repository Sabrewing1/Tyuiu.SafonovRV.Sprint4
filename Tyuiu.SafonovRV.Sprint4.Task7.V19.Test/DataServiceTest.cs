using Tyuiu.SafonovRV.Sprint4.Task7.V19.Lib;

namespace Tyuiu.SafonovRV.Sprint4.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string text = "90817264";
            int n = 4;
            int m = 2;
            int res = ds.Calculate(n, m, text);

            Assert.AreEqual(3, res);
        }
    }
}