using Tyuiu.SafonovRV.Sprint4.Task6.V6.Lib;

namespace Tyuiu.SafonovRV.Sprint4.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил:  Сафонов Р.В АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Сафонов Руслан Васильевич | АСОиУб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [Борис, Анна, Михаил, Ирина, Сергей,        *");
            Console.WriteLine("* Татьяна, Олег], используя класс Array, выведите элементы массива,       *");
            Console.WriteLine("* длина которых равна 5 символам.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] name = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"{name[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Элементы массива, длина которых равна 5 символов: ");

            string[] res = ds.Calculate(name);

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
