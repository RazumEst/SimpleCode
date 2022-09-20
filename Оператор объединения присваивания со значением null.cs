using System;

namespace Оператор_объединения_присваивания_со_значением_null
{
    internal class Program
    {
        static int[] GetArray()
        {
            int[] myArray = null;
            return myArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = GetArray();
            myArray ??= new int[0];

            Console.WriteLine("количество элементов в массиве " + myArray.Length);

        }
    }
}
