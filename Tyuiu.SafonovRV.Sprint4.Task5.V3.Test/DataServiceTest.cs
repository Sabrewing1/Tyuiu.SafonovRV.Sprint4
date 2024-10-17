using Tyuiu.SafonovRV.Sprint4.Task5.V3.Lib;


namespace Tyuiu.SafonovRV.Sprint4.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { 1, 2, 4, 5, - 4 },
                { 4, -2, -3, -2, 1 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                {1,2,3,4,5} };

            int[,] waitArray = new int[5, 5] { { 1, 2, 4, 5, 0 },
                { 4, 0, 0, 0, 1 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                {1,2,3,4,5} };

            var res = ds.Calculate(array);

            CollectionAssert.AreEqual(res, waitArray);

        }
    }
}