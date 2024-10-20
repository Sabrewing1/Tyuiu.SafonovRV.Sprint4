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
            Console.WriteLine("* статическими значениями в диапазоне от 2 до 6. Найдите сумму элементов  *");
            Console.WriteLine("* в тором столбце.                                                        *");
            Console.WriteLine("* 4, 3, 2, 6, 2,                                                          *");
            Console.WriteLine("* 5, 2, 2, 5, 6,                                                          *");
            Console.WriteLine("* 2, 5, 4, 5, 6,                                                          *");
            Console.WriteLine("* 4, 5, 2, 4, 6,                                                          *");
            Console.WriteLine("* 6, 5, 4, 3, 6,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            // Инициализация двумерного массива
            int[,] mas2 = new int[5, 5] 
            {
            { 4, 3, 2, 6, 2 },
            { 5, 2, 2, 5, 6 },
            { 2, 5, 4, 5, 6 },
            { 4, 5, 2, 4, 6 },
            { 6, 5, 4, 3, 6 }
            };

            Console.Write("Массив:{ ");
            for (int i = 0; i < mas2.GetUpperBound(0) + 1; i++)
            {
                if (i != 0) { Console.Write("\t "); }
                Console.Write("{");
                for (int j = 0; j < mas2.Length / (mas2.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(mas2[i, j]);
                    if (j != mas2.GetLength(0) - 1) { Console.Write(", "); }
                }
                Console.Write("}");
                if (i != mas2.GetLength(0) - 1) { Console.WriteLine(","); }
            }
            Console.WriteLine(" }");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas2);

            Console.WriteLine("Максимальный элемент во второй строке массива = " + res);
            Console.ReadKey();
        }
    }
}




