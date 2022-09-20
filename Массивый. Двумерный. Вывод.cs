﻿using System;

namespace Массивый._Двумерный._Вывод
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
            {
                {24,45,6,7,8 },
                {56,6,23,4,5 },
                {6,78,234,4,67 },
                {56,7345,4,555,123 }
            };
            //для того чтобы вывести массив на консоль, нужно получить доступ
            //ко всем его элементам. И эта логика должна работать даже, когда
            //мы прибавляем, удаляем элементы.Поэтому мы должны использовать циклы.
            //выводить элементы массива можно по-разному: в одну строку, в вертикальную
            //линию. Но обычно двумерный массив выводится в табличку, так как это удобно.
            //Если не важно, как выводить массив, нужно просто наличие цифр в консоли.
            //тогда используем цикл foreach. Задачей этого цикла является
            //перебор элементов коллекции.
            //foreach (var item in collection) вместо collection ставим имя массива.
            //это цикл будет пробегаться по всем элементам массива, и помещать каждый
            //в переменную item.Ее можно назвать как угодно.    
           // foreach(var item in myArray)
            //{
                //Console.WriteLine(item); //выводим элементы на консоль в вертикальном
                //порядке, так как метод WriteLine после вывода того,что
                //мы передадим в круглые скобки (т.е. в качестве параметра)
                //делает переход на следующей строку.
                //Если нужно в строку,используем Write.
            //}
            //foreach(var item in myArray)
            //{
            //    Console.Write(item + " ");
            //}
            //Далее выведем массив табличкой, как он записан.Для этого нам понадобятся
            //вложенные циклы. Цикл for. Зачем нужно 2 цикла?
            //1-й внешний цикл будет итерироваться по вертикали.У нас 4 строки
            //т.о. цикл отработает 4 раза. Но каждая строка - это тоже массив.
            //Соответсвенно каждую итерацию внешнего цикла будет отрабатывать вложенный
            //который будет перебирать все элементы каждой строки.
           //Console.WriteLine(myArray.Rank);//обратимся к свойству массива Rank.
            //наш массив хранит информацию, о том сколькимерный он.
            //Console.WriteLine(myArray.GetLength(0));//метод, который поможет узнать кол-во элементов 
                //в определенном измерении нашего массива. Нумерация измерений также
                //начинается с 0. 0 - это строки, 1 - это кол-во элементов в строке.
                
            int height = myArray.GetLength(0);//кол-во элементов по вертикали, высота 
            //нашей таблички.
            int width = myArray.GetLength(1);//кол-во элементов во 2-м измерении
            //т.е. ширина нашей таблички.
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)//вложенный цикл перебирает элементы
                    //по ширине
                {
                    Console.Write(myArray[y,x] + "\t");//в индексе указаны ряд и элемент в нем.
                    //используем метод Write, так как нужно выводить элементы в строку.
                    //и еще нужно отделить числа друг от друга. Поэтому выполняем
                    //конкатенацию и \t.
                }
                Console.WriteLine();
                //не забыть!!!Задачей внешнего цикла является перебор строк. Нам нужно
                //переходить на сл строку, для того нужно вызвать метод WriteLine после
                //внутреннего цикла
            }

            //Теперь если мы добавим еще строку, то все будет ок. Так как в c# массивы
            //"знают", какое кол-во элементов содержат.

            //int height = myArray.GetLength(0);
            // int width = myArray.GetLength(1);
            //эти переменные можем не выводить отдельно, а записать так:
            //for (int y = 0; y < myArray.GetLength(0); y++)
            // for (int x = 0; x < myArray.GetLength(1); x++)






        }
    }
}
