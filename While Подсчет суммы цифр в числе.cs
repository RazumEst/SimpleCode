using System;

namespace While_Подсчет_суммы_цифр_в_числе
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;
            if (digit is >= 0 and <= 9)
            {
                int summ = 0;
                int tempnumber = number;

                while (tempnumber > 0)
                {
                    int mod = tempnumber % 10;
                    if (tempnumber == digit)
                    {
                        summ = summ + mod;
                    }
                    tempnumber = tempnumber / 10;
                }
                Console.WriteLine($"Summ of digits in number {number} is \"{summ}\" ");
            }
            else
            {
                Console.WriteLine("Invalid values. Please, try again.");
            }

            
        
        }
    }
}
