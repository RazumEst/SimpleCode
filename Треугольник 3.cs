using System;

namespace Треугольник_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту треугольника");
            int height = int.Parse(Console.ReadLine());


            for (int i = 0; i < height; i++)
            {
                for (int b = height; b >= i; b--)
                {
                    Console.Write(" "); //тут делается треугольник, как из задачи про 2-й треугольник, только пробелами.
                    for (int a = 0; a <= i; a++)
                    {
                        Console.Write("#");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
