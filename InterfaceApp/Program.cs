namespace InterfaceApp
{
    class Program
    {
        static void Main()
        {
            IMovable car = new Car();
            IMovable bike = new Bicycle();

            car.Move();
            bike.Move();
        }
    }
}