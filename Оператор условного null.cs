using System;
using System.Linq;

namespace Оператор_условного_null
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
                Console.WriteLine("Сумма элементов массива " + (myArray?.Sum() ?? 0));
            //?. - оператор, который выполняет проверку на null, прежде чем обратиться к массиву. 
            //если в массиве будет null, то никакие действие дальше выполняться не будут. 
            //далее добавляем оператор объединения с null - ?? и будет выводиться дефолтное значение. 

            }
        }
    }

