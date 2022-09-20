using System;

namespace Рекурсия_сумма_цифр_в_числе
{
    internal class Program
    {
        static int SumDig(int value)
        {
            if (value < 10)
                return value;

            int digit = value % 10;
            int nextValue = value / 10;

            return digit + SumDig(nextValue);

           
        }
        static void Main(string[] args)
        {
            int value = 459386;
            int result = SumDig(value);
            Console.WriteLine(result);
        }
    }
}
