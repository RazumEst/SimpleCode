using System;

namespace Треугольник_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int height = int.Parse(Console.ReadLine());


            for (int i = 0; i < height; i++)
            {
               
                for (int a = 0; a <= i; a++)
                {
                    Console.Write(" ");
                }
                for (int b = height; b >= i; b--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
