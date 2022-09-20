using System;

namespace Наименьший_элемент_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 45, 6, 7, 56, 23, 1, 44 };
            int minValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }
            Console.WriteLine(minValue);
            Console.ReadLine();


        }
    }
}
