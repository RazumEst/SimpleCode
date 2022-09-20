using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции_и_методы_не_возвращает_с_параметрами
{
    internal class Program
    {
        static void List(string a)
        {
            Console.WriteLine("Фамилия студента " + a);
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            List(a);

            
           
        }
    }
}
