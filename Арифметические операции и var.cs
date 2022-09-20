using System;

namespace Арифметические_операции_и_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = 8;
            int two = 5;
            double three = one / two; //получится целое число, так как делим целые числа. Происходит неявный каст результата деления 8/5=1. 
            Console.WriteLine(three);

            int four = 4;
            int five = 3;
            double six = (double)four / five;// получится дробное число, так как мы сделали каст первого числа в дробное. И это первая по приоритету операция
            Console.WriteLine(six);

            double angle = 3.14315;
            Console.WriteLine(Math.Sin(angle));

            int a = 5;
            int b = 6;
            var c = a * b;//var говорит компилятору "Определи тип переменной по ее значению".
            Console.WriteLine(c);
            var d = c.ToString();//метод ToString возвращает строку

            var f = 56;
            var g = 586;
            var k = 58854;
            f = g = k; //сначала g приравнивается k, потом f приравнивается к результату g = k;
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(k);

            int s = 3;
            int r = 4;
            s += 3; // s = s + 3
            r *= 4;// r = r * 4
            Console.WriteLine(r);
            Console.WriteLine(s);



        }
    }
}
