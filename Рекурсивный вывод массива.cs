using System;

namespace Рекурсивный_вывод_массива
{
    internal class Program
    {
        static void PrintArray(int[] array, int index = 0)//index - необязательный параметр
            //так как нам может понадобиться вывести все элементы массива. 
        {
            if (index < array.Length)//условие, при котором будет выполняться рекурсия.
                //т.е. из нее есть выход. 
            {
                Console.WriteLine(array[index]);
                PrintArray(array, index + 1);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 2, 5, 6, 7, 1, 5685 };
            PrintArray(myArray) ;


        }
    }
}
