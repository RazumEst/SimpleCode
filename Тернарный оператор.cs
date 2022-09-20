using System;

namespace Тернарный_оператор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed; //это можно не писать, так как переменная и так булевая.

            string storepassword = "qwerty";
            string enteredpassword = Console.ReadLine();

            //if (enteredpassword == storepassword)
            //{
            //    accessAllowed = true;
            //}
            //else
            //{
            //    accessAllowed = false;
            //}

            //[первый операнд "условие"] ? (какой результат работы данного оператора?) [второй операнд if_true] : [третий операнд if_false]

            accessAllowed = enteredpassword == storepassword ? true : false;

             Console.WriteLine(accessAllowed);
            Console.ReadLine();

            int intputData = int.Parse(Console.ReadLine());
            int outputData = (intputData < 0) ? 0 : intputData; 
            Console.WriteLine(outputData);

            Console.ReadLine();








        }
    }
}
