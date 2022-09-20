using System;

namespace Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 40; a++)
            {
                if (a % 2 == 0)
                {
                    continue; // оператор пропуска, но код будет продолжаться дальше
                }
                Console.WriteLine(a);

            }
            Console.ReadLine();
        }
    }
}
