namespace AbstractApp
{
    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }
        public Rectangle(double w, double h) { Width = w; Height = h; }
        public override double GetArea() => Width * Height;
    }
}