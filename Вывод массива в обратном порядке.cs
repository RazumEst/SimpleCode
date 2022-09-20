using System;

namespace Вывод_массива_в_обратном_порядке
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во элементов массива:\t"); 
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount]; 
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом {i}:\t");

                myArray[i] = int.Parse(Console.ReadLine());
            }
                

            Console.WriteLine("\nВывод массива");
            
            for (int i = myArray.Length-1; i >= 0; i--)//i - итератор цикла. и его нужно уменьшать на 1
                // так как счет в массивах начинается с 0.
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
