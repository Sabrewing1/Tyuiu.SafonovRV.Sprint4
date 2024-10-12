using Tyuiu.SafonovRV.Sprint4.Task3.V26.Lib;

namespace Tyuiu.SafonovRV.Sprint4.Task3.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] mtrx = new int[5, 5] { { 4, 3, 2, 6, 2 },
                                          { 5, 2, 2, 5, 6 },
                                          { 2, 5, 4, 5, 6 },
                                          { 4, 5, 2, 4, 6 },
                                          { 6, 5, 4, 3, 6} };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            Console.Title = "Спринт #4 | Выполнил: Сафонов Р.В | АСОиУБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич | АСОиУБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 8. Найдите сумму элементов  *");
            Console.WriteLine("* в тором столбце.                                                        *");
            Console.WriteLine("* 4, 3, 2, 6, 2,                                                          *");
            Console.WriteLine("* 5, 2, 2, 5, 6,                                                          *");
            Console.WriteLine("* 2, 5, 4, 5, 6,                                                          *");
            Console.WriteLine("* 4, 5, 2, 4, 6,                                                          *");
            Console.WriteLine("* 6, 5, 4, 3, 6,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mtrx);

            Console.WriteLine(" Сумма элементов во второом столбце = " + res);

            Console.ReadKey();
        }
    }
}
        
    

