using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SafonovRV.Sprint4.Task3.V26.Lib
{
    public class DataService : ISprint4Task3V26
    {

        public int Calculate(int[,] array)
        {
            int[,] ints = new int[,]
                    {
            { 4, 3, 2, 6, 2 },
            { 5, 2, 2, 5, 6 },
            { 2, 5, 4, 5, 6 },
            { 4, 5, 2, 4, 6 },
            { 6, 5, 4, 3, 6 }
                    };
            

            // Переменная для хранения максимального элемента
            int maxElement = array[1, 0]; // Инициализация первым элементом второй строки

            // Поиск максимального элемента во второй строке
            for (int j = 1; j < array.GetLength(1); j++)
            {
                if (array[1, j] > maxElement)
                {
                    maxElement = array[1, j];
                }
            }

            // Вывод результата
            Console.WriteLine("Максимальный элемент во второй строке: " + maxElement);
        }
    }
}




