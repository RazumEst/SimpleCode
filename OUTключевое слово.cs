 using System;

namespace OUTключевое_слово
{
    internal class Program
    {
        static void Bar(out int a)
        {
            a = 5;
        }
        static void Main(string[] args)
        {
            Bar(out int a);
            Console.WriteLine(a);
        }
    }
}
//out обязывает инициализировать переменную, которая была передана в качестве параметра с данным модификатором.
//Поэтому в методе Main необязательно инициализировать переменную, т.е. присваивать ей какое-то значение. 
//у ref лишь есть такая возможность, но не обязательство. 