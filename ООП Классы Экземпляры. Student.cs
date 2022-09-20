using System;

namespace ООП_Классы_Экземпляры._Student
{

    internal class Program
    {
        static Student GetStudent()
        {
            Student student = new Student();

            student.firstName = "Курлык";
            student.lastName = "Курлыкин";
            student.middleName = "Курлыкович";
            student.id = Guid.NewGuid();
            student.age = 30;
            student.group = "Kurlik";

            return student;

        }
        static void Print(Student student)
        {
            Console.WriteLine("Информация о студенте");
            Console.WriteLine($"Id: {student.firstName}");
            Console.WriteLine($"Фамилия: {student.lastName}");
            Console.WriteLine($"Имя: {student.firstName}");
            Console.WriteLine($"Отчество: {student.middleName}");
            Console.WriteLine($"Группа: {student.group}");
            Console.WriteLine($"Возраст: {student.age}");
        }

        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
        }
    }
}

 