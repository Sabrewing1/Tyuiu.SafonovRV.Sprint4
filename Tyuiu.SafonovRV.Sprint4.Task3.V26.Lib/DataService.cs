using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SafonovRV.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {

        public int Calculate(int[,] array)
        {
            int MaxNum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[1, i] > MaxNum)
                {
                    MaxNum = array[1, i];
                }
            }
            return MaxNum;
        }
    }
}




