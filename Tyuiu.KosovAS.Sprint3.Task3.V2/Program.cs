using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosovAS.Sprint3.Task3.V2.Lib;

namespace Tyuiu.KosovAS.Sprint3.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string value; char item;

            Console.Title = "Спринт #3 | Выполнил: Косов А. С. | АСОиУБ-23-3";
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Спринт #3" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3" + String.Concat(Enumerable.Repeat(" ", 62)) + "*");
            Console.WriteLine("* Вариант 2" + String.Concat(Enumerable.Repeat(" ", 63)) + "*");
            Console.WriteLine("* Выполнил: Косов Андрей Сергеевич | АСОиУБ-23-3" + String.Concat(Enumerable.Repeat(" ", 26)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* УСЛОВИЕ:" + String.Concat(Enumerable.Repeat(" ", 64)) + "*");
            Console.WriteLine("* Написать програму, которая запрашивает у пользователя данные, вычисляет *");
            Console.WriteLine("* их и печатает их на экран.                                              *");
            Console.WriteLine("*" + String.Concat(Enumerable.Repeat(" ", 73)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:" + String.Concat(Enumerable.Repeat(" ", 56)) + "*");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine("Введите исходную строку: ");
            value = Console.ReadLine();

            Console.WriteLine("Введите искомый символ: ");
            item = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine(String.Concat(Enumerable.Repeat("*", 75)));

            Console.WriteLine($"Максимальная длина подряд идущего символа '{item}' в строке '{value}'\n" +
                $"равна: {ds.GetMaxCharCount(value, item)}");

            Console.ReadKey();
        }
    }
}
