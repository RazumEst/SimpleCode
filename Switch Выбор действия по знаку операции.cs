using System;

namespace Switch_Выбор_действия_по_знаку_операции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the operation ");
            string operation = Console.ReadLine();

            Console.WriteLine("Input second number");
            int y = int.Parse(Console.ReadLine());

            double result; //переменна для хранения результата

            switch (operation)
            {
                case "+":
                    result = x + y;
                    break;

                case "-":
                    result = x - y;
                    break;

                case "*":
                    result = x * y;
                    break;

                case "/":
                    if (y == 0) //проверка на 0. 
                    {
                        result = double.NaN; //NaN - Not a Number.
                        Console.WriteLine("You cannot divide by zero");
                    }
                    else
                    {
                        result = x / y;
                    }
                    break;

                default:
                    result = double.NaN;
                    Console.WriteLine("Invalid operation");
                    break;

            }

            Console.WriteLine($"{x} {operation} {y} = {result}");

        }
    }
}
