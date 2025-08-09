namespace InterfaceApp
{
    public class Bicycle : IMovable
    {
        public void Move() => System.Console.WriteLine("Bicycle is moving");
    }
}