using System;

namespace ДЗ_калькулятор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            switch(a)
            {
                case '+': 
                    Console.WriteLine("Операция сложение. Введите число 1 и число 2 поочередно");
                    double first, second, result; ; 
                    first = Double.Parse(Console.ReadLine());
                    second = Double.Parse(Console.ReadLine());
                    result = first + second;
                    Console.WriteLine(result);
                    break;
                case '-':
                    Console.WriteLine("Операция вычитание. Введите число 1 и число 2 поочередно");
                    double f, s, r;
                    s = Double.Parse(Console.ReadLine());
                    f = Double.Parse(Console.ReadLine());
                    r = f + s;
                    Console.WriteLine(r);
                    break;
                case '*':
                    Console.WriteLine("Операция умножение. Введите число 1 и число 2 поочередно");
                    double f1, s1, r1;
                    f1 = Double.Parse(Console.ReadLine());
                    s1 = Double.Parse(Console.ReadLine());
                    r1 = f1 * s1;
                    Console.WriteLine(r1);
                    break;
                case '/':
                    Console.WriteLine("Операция вычитание. Введите число 1 и число 2 поочередно");
                    double f2, s2, r2;
                    f2 = Double.Parse(Console.ReadLine());
                    s2 = Double.Parse(Console.ReadLine());
                    r2 = f2 / s2;
                    Console.WriteLine(r2);
                    break;
                default: 
                    Console.WriteLine("Нету такого, ты куда смотришь!");
                break;

            }

        }
    }
}
