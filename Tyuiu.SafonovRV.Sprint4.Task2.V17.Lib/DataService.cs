using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SafonovRV.Sprint4.Task2.V17.Lib
{
    public class DataService : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            
                //!=
                int mult = 1;
                foreach (int num in array)
                {
                    if (num % 2 != 0) // проверка на нечетность
                    {
                        mult *= num; // умножение на новый нечётный элемент
                    }
                }
                return mult;
            }
        }
    }

    

