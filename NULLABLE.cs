using System;

namespace NULLABLE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            Console.WriteLine(i == null);//true
            Console.WriteLine(i.HasValue);//false есть ли значение у переменной
            Console.WriteLine(i.GetValueOrDefault());//0. результатом работы метода
            //является значение, которое мы присвоили переменной. Но метод появляется
            //только в том случае, если переменная nullable. Если значение не присвоено,
            //то будет возвращено дефолтное, которое необходимо указать в круглых скобках.
            //
            Console.WriteLine(i.GetValueOrDefault(4));//4
            Console.WriteLine(i ?? 55);//55
            Console.WriteLine(i.Value);//InvalidOperationException
        }
    }
}
