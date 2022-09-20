using System;

namespace Треугольник_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int a = height; a >= i; a--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
