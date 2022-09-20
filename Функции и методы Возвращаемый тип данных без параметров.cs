using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Функции_и_методы_Возвращаемый_тип_данных_без_параметров
{
    internal class Program
    {
        static int What()
        {
          
            return 55;
        }
        static void Main(string[] args)
        {

            int a = What();
            Console.WriteLine(a);
        }
    }
}
