using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции_и_методы.ДЗ_введение_символа
{
    internal class Program
    {
        static char Symbol(char a, int b)
        {
            for (int i = 1; i < b; i++)
            {
                Console.Write(a);
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ и его количество через Enter ");
            char a = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char c = Symbol(a, b);
            Console.WriteLine(c);
       
        }
    }
}
