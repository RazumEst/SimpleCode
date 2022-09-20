using System;

namespace Домашнее_задание_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Напишите программу, проверяющее число, введенное с клавиатуры на четность.
            int a;
            a = int.Parse(Console.ReadLine());
            int temp = a % 2;
            bool result = temp == 0;
            
            if (result)
            {
                Console.WriteLine("a - четное число");
            }
            else
            {
                Console.WriteLine("a - не четное число");
            }
        }
    }
}
