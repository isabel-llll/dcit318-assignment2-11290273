namespace InheritanceApp
{
    class Program
    {
        static void Main()
        {
            Animal generic = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            generic.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}