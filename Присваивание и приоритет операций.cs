using System;

namespace Присваивание_и_приоритет_операций
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            x += 1; //увеличение на 1
            x++;// это то же увеличение на 1, но работает быстрее, чем верхний оператор.

            int y = 1;
            bool result = y > 5 && y < 6 || -x == -1 * x++;
            Console.WriteLine(result);

        }
    }
}
