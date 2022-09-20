using System;

namespace ООП_Класс_Объект_класса_
{
    class Point //по сути это шаблон. 
    {
       public int x;
       public int y;
       public Color color;
    }

    enum Color
    {
        Red,
        Yellow,
        Green,
        Blue,
        White

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();//new - позволяет выделить место в управляемой куче под экземпляр класса
            //так как это ссылочный тип данных. 
            point.x = 5;
            point.y = 6;
            point.color = Color.Red;
            //если присвоить объекту класса null, то разорвется связт между ним и данными в управляемой куче. 
            Point point1 = new Point();
            point1.x = 8567;
            point1.y = 86049586;
            point1.color = Color.Green;
            //это разные экземпляры классов, у которых поля лежат в разных областях памяти. 
            
            Console.WriteLine($"X: {point.x} | Y: {point.y} | Color: {point.color}");
            Console.WriteLine($"X: {point1.x} | Y: {point1.y} | Color: {point1.color}");

        }
    }
}
