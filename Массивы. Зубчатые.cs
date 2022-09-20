using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Массивы.Зубчатые
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //зубчатый массив или массив массивов - это массив с вложенным массивом .
            //массив может содержать внутри себя любой тип данных
            //это одномерный массив, элементами которого явл одномерные массивы.
            //int[] myArray;//это одномерный массив, который содержит в себе тип 
            ////данных int.
            //int[][] myArray2 = new int[3][];
            //int[,] myArray3 = new int[3, 5];

            //int myArrayRank2 = myArray2.Rank;//кол-во измерений в массиве
            //int myArrayRank3 = myArray3.Rank;
            //int myArrayLength2 = myArray2.Length;//кол-во всех элементов массива
            //int myArrayLength3 = myArray3.Length;

            //для того, чтобы получить доступ ко 2-му измерению зубчатого массива,
            //надо сначала обратиться к какому-то его элементу по индексу
            //как результат, получим одномерный массив, который хранится в кач-ве
            //элемента. И только тут мы можем начать работать с его элементами.
            //под каждый внутренний массив массива нужно выделить память.

            int[][] myArray = new int[3][];
            myArray[0] = new int[3];
            myArray[1] = new int[5];
            myArray[2] = new int[10];

            //Console.WriteLine(myArray[2][2]);//на консоль будет выведен 0
            //так как во внутреннем массиве элементом является переменная int
            //а элементы внутренних массивов еще не указаны, соответственно будет
            //выведено дефолтное значение переменной int. 
            //можно указать значение myArray[2][2] = 55. тогда на консоль будет 
            //выведено 55. 
            Random random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = random.Next(100);
                }
            }

                for (int i = 0; i < myArray.Length; i++)
                {
                    for (int j = 0; j < myArray[i].Length; j++)
                    {
                       Console.Write(myArray[i][j] + "\t");
                    }
                Console.WriteLine();
                }

        }
    }
}
