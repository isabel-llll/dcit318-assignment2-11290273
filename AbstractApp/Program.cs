using System;

namespace AbstractApp
{
    class Program
    {
        static void Main()
        {
            var c = new Circle(3);
            var r = new Rectangle(4, 5);

            Console.WriteLine($"Circle area: {c.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {r.GetArea():F2}");
        }
    }
}