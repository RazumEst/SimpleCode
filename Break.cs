using System;

namespace Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ключевое слово break. С его помощью можно прервать выполнение цикла.
            //for (int a = 0; a < 100; a++)
            //{
            //    Console.WriteLine(a);

            //    if (a  == 40)
            //    {
            //        break;
            //    }
            //}

            for (int r = 0; r < 10; r++)
            {
                Console.WriteLine("Нажмите любую клавишу, кроме w, чтобы продолжить выполнение программы");
                string msg = Console.ReadLine();
                if (msg == "w")
                {
                    break;
                }
                Console.WriteLine(r);

            }
            Console.ReadLine();


        }
    }
}
