using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SafonovRV.Sprint4.Task6.V6.Lib
{
    public class DataService : ISprint4Task6V6
    {
        public string[] Calculate(string[] arrayStrings)
        {
            string[] mas = Array.FindAll(arrayStrings, x => x.Length == 5);
            return mas;
        }
    }
}
