using System;

namespace Неизменяемость_строк
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Создание объекта Student
            Student sl = new Student();
            sl.Name = "Jenny";
            // Создаем новьй объект с тем же именем
            Student s2 = new Student();
            s2.Name = sl.Name;
            // "Изменение " имени объекта s1 не изменяет сам объект, поскольку ToUpper() возвращает новую
            // строку, не влияя на оригинал.

            s2.Name = sl.Name.ToUpper();
            Console.WriteLine(" s1 - " + sl.Name + " , s2 - " + s2.Name);
            // Ожидаем подтверждения пользователя
            Console.WriteLine("Haжмитe <Enter> для " + "завершения программы... ");
            

            // Student - простейший класс, содержащий строку
        }
         class Student
        { 
            public String Name ;
        }
        //Вот что выводит на экран приведенная выше программа:
        //sl - Jenny, s2 - JENNY
        //Это свойство строк называется неизметюстыо (или неизменяемостью - immutability).
        
    }
}
