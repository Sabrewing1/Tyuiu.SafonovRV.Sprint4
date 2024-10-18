using Tyuiu.SafonovRV.Sprint4.Task7.V19.Lib;

namespace Tyuiu.SafonovRV.Sprint4.Task7.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #4 | Выполнил:  Сафонов Р.В АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 90817264. Преобразуйте                *");
            Console.WriteLine("* ее в матрицу 4 на 2 и подсчитайте количество нечетных чисел в матрице.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            int n = 4;
            int m = 2;
            string text = "90817264";
            Console.WriteLine("n: " + n);
            Console.WriteLine("m: " + m);
            Console.WriteLine("String: " + text);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(n, m, text);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
