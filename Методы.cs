using System;

namespace Методы
{
    internal class Program
	{


		// Это метод, возвращающий значение типа int, принимающий два аргумента типа double.
		// Его можно называть функцией, но это название не очень распространено.
		// Сигнатура метода - это совокупность имени метода и последовательности типов аргументов
		//static int DivideAndRound(double a, double b)
		//	{
		//		// return указывает, какое значение будет возвращено
		//		return (int)Math.Round(a / b);
		//	}

		//	// Это метод, не возвращающий значения. Вместо типа возвращаемого значения стоит void
		//	static void WriteNumber(int number)
		//	{
		//		Console.WriteLine(number);

		//		// return указывается без значения, и его следует опускать, когда это возможно
		//		return;
		//	}

		//	static void WriteNumber(int number, int anotherNumber)
		//	{
		//		Console.WriteLine(number);
		//		Console.WriteLine(anotherNumber);
		//	}

		//private static string GetGreetingMessage(string name, double salary)
		//{
		//	return $"Hello, {name}, your salary is {Math.Ceiling(salary)}";
		//	// возвращает "Hello, <name>, your salary is <salary>"

		//}
		//static void Main(string[] args)
		//{
		//	Console.WriteLine(GetGreetingMessage("Student", 10.01));
		//	Console.WriteLine(GetGreetingMessage("Bill Gates", 10000000.5));
		//	Console.WriteLine(GetGreetingMessage("Steve Jobs", 1));
		//}


		public static void Print(double e)
		{
			Console.WriteLine(e);
		}
		public static double GetSquare(double a)
		{
			double squared = Math.Pow(a, 2);
			return squared;
		}
		public static void Main()
		{
			Print(GetSquare(42));
		}
	}
}
