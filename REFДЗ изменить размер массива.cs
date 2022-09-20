using System;

namespace REFДЗ_изменить_размер_массива
{
    internal class Program
    {
        //метод Resize

        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 6, 7 };
            Array.Resize(ref myArray, 7);//под капотом этого метода создается новый
            //массив, в который копируются данные из старого массива.
            //а данные из старого массива остаются в управляемой куче, но к ним стирается
            //ссылка. 
        }
    }
}
