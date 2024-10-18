using Tyuiu.SafonovRV.Sprint4.Task6.V6.Lib;

namespace Tyuiu.SafonovRV.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            var name = new string[] { "�����", "����", "������", "�����", "������", "�������", "����" };

            var res = ds.Calculate(name);
            string[] wait = { "�����", "�����" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}