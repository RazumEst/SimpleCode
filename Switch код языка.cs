using System;

namespace Switch_код_языка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input language code");
            string language = Console.ReadLine();

            switch (language)
            {
                case "eng":
                case "анг":

                    Console.WriteLine("Language is Английский");
                    break;
                case "ban":
                    Console.WriteLine("Language is Балийский");
                    break;
                    default: Console.WriteLine("Ошибка");
                    break;

            }
        }
    }
}
