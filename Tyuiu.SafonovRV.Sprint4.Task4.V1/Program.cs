using Tyuiu.SafonovRV.Sprint4.Task4.V1.Lib;

namespace Tyuiu.SafonovRV.Sprint4.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич | АСОиУБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 9. Найдите сумму четных     *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("* 2, 5, 1, 7, 5,                                                          *");
            Console.WriteLine("* 4, 4, 7, 4, 4,                                                          *");
            Console.WriteLine("* 7, 1, 6, 8, 8,                                                          *");
            Console.WriteLine("* 8, 1, 5, 8, 4,                                                          *");
            Console.WriteLine("* 8, 9, 1, 7, 3,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Инициализация двумерного массива
            int[,] array = new int[5, 5]
            {
            { 2, 5, 1, 7, 5 },
            { 4, 4, 7, 4, 4 },
            { 7, 1, 6, 8, 8 },
            { 8, 1, 5, 8, 4 },
            { 8, 9, 1, 7, 3 }
            };

            int sumEven = 0;

            // Суммирование четных элементов
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] % 2 == 0) // Проверка на четность
                    {
                        sumEven += array[i, j];
                    }
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма четных элементов массива: " + sumEven);
        }
    }
}
