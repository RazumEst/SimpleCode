using System;

namespace Вложенные_циклы_квадрат
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту прямоугольника ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника ");
            int wigth = int.Parse(Console.ReadLine());

            for (int k = 0; k < height; k++)
            {
                for (int i = 0; i < wigth; i++)
                {
                    Console.Write("#"); //метод Write не переходит на сл строчку. 
                }
                Console.WriteLine(); //этот метод нужен, чтобы все не писалось в одну строку.
                                     //после каждого выполнения 1 внешнего цикла, внутренний будет начинаться с новой строки.
            }


            Console.ReadLine();


        }
    }
}
