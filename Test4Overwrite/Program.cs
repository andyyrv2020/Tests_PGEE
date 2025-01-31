namespace Test4Overwrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal defaultAnimal = new Animal();
            defaultAnimal.MakeTrick();

            Dog dog = new Dog();
            dog.MakeTrick();

        }
    }
}
