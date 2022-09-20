using System;

namespace Функции_и_Методы._Перегрузки
{
    internal class Program
    {
        /// <summary>
        /// Возвращает сумму двух целых чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
            
           
        static void Main(string[] args)
        {
            int result = Sum(1, 2);
            Console.WriteLine(result);
        }
    }
}
