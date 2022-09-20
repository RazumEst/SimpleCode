using System;

namespace Массивы_ДЗ
{
    internal class Program
    {
        // Заполнить массив с клавиатуры
        // вывести массив в обратном порядке
        // найти сумму четных чисел в массиве
        // найти наименьшее число в массиве
        static void Main(string[] args)
        {
            Console.Write("Введит кол-во элементов массива:\t"); //Write - не переходит на сл строку
            // \t - отступ в виде табуляции
            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount]; //создаем массив
                                                    //на столько элементов, сколько
            //введем в консоль.
            //нужно перебрать все элементы массива, обратиться к каждому, прочитать данные с консоли.
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"\nВведите элемент массива под индексом {i}:\t");
                //
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nВывод массива: ");// \n - перед текстом. Переход на сл строчку

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            
        }
    }
}
