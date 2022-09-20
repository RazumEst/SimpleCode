using System;

namespace Enum_constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)DayOfTheWeek.Tuesday);
            const double Pi = 3.14159;
            //Объявлять константы можно внутри методов (там где объявляются переменные)
            //и внутри классов (где объявляются поля).

            //Константа - поле всегда является статическим, при этом слово static писать не нужно.
        }
    }
}
