namespace Test5People
{
    using System;

    class Program
    {
        static void Main()
        {
            try
            {
                string name = Console.ReadLine();
                int age;

                while (true) // Добавен безкраен цикъл за въвеждане на възрастта(стойността) докато не е положителна
                {
                    try
                    {
                        age = int.Parse(Console.ReadLine());
                        Person person = new Person(name, age);
                        break;
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid age format. Please enter a valid number.");
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
