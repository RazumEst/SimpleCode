using System;

namespace PARAMSКЛЮЧЕВОЕ_СЛОВА
{
    internal class Program
    {
        static int Sum(params int[] parameters)
        {
            int result = 0;
            for(int i = 0; i < parameters.Length; i++)
            {
                result += parameters[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            int result = Sum(2, 4, 5, 8, 9, 586);
            Console.WriteLine(result);
        }
    }
}
//тип данных с ключевым словом params нужно писать в конце указываемых параметров.
//с модификатором params можно использовать только 1 параметр. 