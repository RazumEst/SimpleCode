using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы.Заполнение_с_клавиатуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[,] myArray = new int[2, 3];
            
            

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.WriteLine("Y: " + i + "X: "+ j);//по вертикали идут значения I 
                    myArray[i, j] = int.Parse(Console.ReadLine());//обращаемся к каждому элементу массива
                    //по нужным индексам, которые перебираются. На консоли будем видеть, 
                    //какой именно элемент нам предлагается, то есь его индекс
                }
                Console.WriteLine();

            }

            Console.WriteLine();


            for (int y = 0; y < myArray.GetLength(0); y++)
            {
                for (int x = 0; x < myArray.GetLength(1); x++)
                {
                    Console.Write(myArray[y, x] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}//можно выводить переменную string, тогда парсить ничего не надо. 
