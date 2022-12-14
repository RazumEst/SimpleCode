using System;

namespace Типы_данных
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Типы данных:
            // целые, вещественные, буловские, строки, дата и время.
            // Типы данных нужны для того, чтобы: определять, сколько нужно ячеек памяти, 
            //какие действия с ней можно совершать,
            //как ее значения показывать на экране.
            // Разные типы данных нужны для экономии памяти, в типовых программах использ int


            // Переполнение типов. 
            // При использовании целых типов данных может возникать переполнение:
            // Например, с типом byte. Он работает только с 8-ю битами. Число 256 выходит за эти пределы.


            // Вещественные типы.
            // Позволяют хранить не только целую часть, но и дробную. 
            // Вещественные: Single (float), double. Финансовые: decimal.
            // Отличаются размером, диапазоном и точностью.
            //Проблемы округления. Вещественные типы хранятся с некоторой точностью.
            // При этом, возможны потери "хвостов" чисел. 

            int a = 123456789;
            int b = 123456788;

            int c = a - b;

            Console.WriteLine($"{a} - {b} = {c}");

            float af = 123456789;
            float bf = 123456788;

            float cf = af - bf;

            Console.WriteLine($"{af} - {bf} = {cf}");

            // 123456789 - 123456788 = 1 - это операция с целыми числами
            // 123456790 - 123456780 = 8 - а тут потеря хвостов. число 789 хранится в памяти как 790. 


            // Устройства вещественных чисел
            //Есть знак, целая часть, дробная часть.
            // Вещественные числа не сравнивают при помощи оператора эквивалентности ==

            // Символьный тип. Кодируются в Unicode, UTF-16.
            // Из символа можно получить его код в виде целого числа и наоборот.
            char f = 'A';

            Console.WriteLine(f);
            Console.WriteLine((int) f);

            // Строки - это набор из последовательно расположенных в памяти символов.
            




        }
    }
}
