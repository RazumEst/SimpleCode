using System;

namespace REFДЗ_изменить_размер_массива_метод_resize
{
    internal class Program
    {
        static void Resize(ref int[] array, int newsize)
        {
            //метод resize для int-значений. 
            int[] myArray = new int[newsize];

            for (int i = 0; i < myArray.Length && i < array.Length; i++)
            {
                myArray[i] = array[i];
            }
            array = myArray;
        }
        static void Main(string[] args)
        {
            int[] newArray = { 2,4,6 };
            Resize(ref newArray, 10);
            
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }
    }
}
