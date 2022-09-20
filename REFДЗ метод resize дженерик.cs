using System;

namespace REFДЗ_метод_resize_дженерик
{
    internal class Program
    {
        static void Resize<T>(ref T[] array, int newsize)
        {
            //метод работает с любым типом данных,благодаря T(type).
            T[] newArray = new T[newsize];

            for (int i = 0; i < newArray.Length && i < array.Length; i++)
            {
                newArray[i]=array[i];
            }
            array= newArray;
        }
        static void Main(string[] args)
        {
            string[] str = { "hello ", "it's me ", "love" };
            Resize(ref str, 2);
            
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
