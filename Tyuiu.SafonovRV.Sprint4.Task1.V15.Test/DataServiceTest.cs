using Tyuiu.SafonovRV.Sprint4.Task1.V15.Lib;

namespace Tyuiu.SafonovRV.Sprint4.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6, 5, 8, 5 };

            int res = ds.Calculate(numsArray);
            int wait = 36;

            Assert.AreEqual(wait, res);
        }
    }
}

        
    
