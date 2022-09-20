using System;

namespace ДЗ_Количестве_четных_и_нечетных
{
    internal class Program //количество четных и нечетных чисел при заданном пользователем диапазоне
    {
        static void Main(string[] args)
        {
            uint oddNumberscount = 0; // нечетные числа  uint - unsight interger (беззнаковое число), не может хранить отрицательные числа
            uint evenNumberscount = 0;// четные числа

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Введите первое число диапазона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное число диапазона");
            int limit = int.Parse(Console.ReadLine());
            while (currentValue <= limit)
            {
              if (currentValue % 2 == 0)
                {
                    evenNumbersSum += currentValue; //краткая запись evenNumbersSum + currentValue
                    evenNumberscount++;
                }
              else
                {
                    oddNumbersSum = oddNumbersSum + currentValue;
                    oddNumberscount++;
                    
                }
                currentValue++;
            }
           

            

            Console.WriteLine("Количество нечетных чисел " + oddNumberscount);
            Console.WriteLine("Количество четных чисел " + evenNumberscount);

            Console.WriteLine("Сумма нечетных чисел " + oddNumbersSum);
            Console.WriteLine("Сумма четных чисел " + evenNumbersSum);
            Console.ReadLine();



          
        }
    }
}
