using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SafonovRV.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {
        public int Calculate(int[,] array)
        {
            
            
                int rows = array.GetUpperBound(0) + 1;
                int columns = array.Length / rows;

                int res = 0;

                for (int j = 0; j < columns; j++)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        if (j == 3)
                        {
                            res += array[i, j];
                        }
                    }
                }
                return res;
            }
        }
    }

    

