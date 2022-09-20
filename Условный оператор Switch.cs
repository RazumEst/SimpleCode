using System;

namespace Условный_оператор_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
                {
                case 1: //in case - в случае
                    Console.WriteLine("Вы ввели число 1");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели число 2");
                    break;
                default: // если нет ни одного совпадения
                    Console.WriteLine("Курлык");
                    break;

            }
            int nanya = int.Parse(Console.ReadLine());

            switch (nanya)
            {
                case 1:// при отсутствии break, проверяется следующий кейс
                case 2:
                    Console.WriteLine("И чо дальше");
                    break;
                default:
                    Console.WriteLine("Курлык");
                    break;
            } //не забудь ее!!!

            string gaga = Console.ReadLine();

            switch (gaga)
            {
                case "1": //in case - в случае
                    Console.WriteLine("Вы ввели число 1");
                    break;
                case "2":
                    Console.WriteLine("Вы ввели число 2");
                    break;
                default: // если нет ни одного совпадения
                    Console.WriteLine("Нету такого, ты куда смотришь!");
                    break;

            }

            int kit = int.Parse(Console.ReadLine());
            int x;

            switch (kit)
            {
                case 1:
                    x = 5; goto case 2;
                    
                case 2:
                   x++;
                    break;
                default:
                    Console.WriteLine("Wrong");
                    break;


            }
        }
    }
}
