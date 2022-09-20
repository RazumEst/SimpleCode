using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции_и_методы_ДЗ_1.Вывод_на_экран_строки
{
    internal class Program
    {
        static char String(char a, int b)
        {
            for(int i = 1; i < b; i++)
            {
                Console.Write(a);
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ и его количество, которые необходимо вывести на экран через Enter ");
            char symbol = char.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            char result = String(symbol, count);
            Console.WriteLine(result);
        }
    }
}
