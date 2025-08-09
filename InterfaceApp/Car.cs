namespace InterfaceApp
{
    public class Car : IMovable
    {
        public void Move() => System.Console.WriteLine("Car is moving");
    }
}