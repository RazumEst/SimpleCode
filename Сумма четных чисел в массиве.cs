using System;

namespace Сумма_четных_чисел_в_массиве
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, };

            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i]%2==0)
                {
                    result += myArray[i];
                }
            }
            Console.WriteLine($"Сумма четных чисел равна {result}");
        }
    }
}
