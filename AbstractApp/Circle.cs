using System;

namespace AbstractApp
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius) => Radius = radius;
        public override double GetArea() => Math.PI * Radius * Radius;
    }
}