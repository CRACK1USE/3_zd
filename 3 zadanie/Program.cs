using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Введите текст:");
            text = Convert.ToString(Console.ReadLine());

            while (text.Contains("  "))
                text = text.Replace("  ", " ");

            Console.WriteLine("Отредактированный текст: " + text);
            Console.ReadKey();
        }
    }
}
