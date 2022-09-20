using System;

namespace REFДЗ_добавить_элемент_массива_по_индексу
{
    internal class Program
    {
        static void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;
            
            for(int i = 0; i < index; i++)
                newArray[i]=array[i];

            for(int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];
            array = newArray;//не забыть в старый массив должны присвоить новый массив.
        }

        static void AddFirst(ref int[] array, int value)
        {
            Insert(ref array, value, 0);
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 4, 6, 45 };
            AddFirst(ref array, 5);

            for(int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
