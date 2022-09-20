using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                count++;
                Console.WriteLine(count); // цикл будет выполняться бесконечно, так как в условиях while - истина. 
            }

            int count1 = 0; // выйдет ошибка про недостижимый код, так как предыдущий фактически бесконечен. А значит, мы не перейдем к данному коду. 

            while (count1 < 10)
            {
                ++count1; //увеличиваем число на единицу
                Console.WriteLine(count1);
            }

            int count2 = 0;
            int limit = int.Parse(Console.ReadLine()); // в этом коде количество повторений кода
            // определяется пользователем

            while (count2 < limit)
            {
                ++count2;
                Console.WriteLine(count2);

            }

            bool love = true;
            while (love)
            {
                string end = Console.ReadLine();
                if (end == "end")
                    love = false;
            }
        }
    }
}
