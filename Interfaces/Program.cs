using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4.2, Color.WHITE );
            Rectangle rectangle = new Rectangle(3.5, 4.2, Color.BLACK);

            Console.WriteLine(circle);
            Console.WriteLine(rectangle);
        }
    }
}
