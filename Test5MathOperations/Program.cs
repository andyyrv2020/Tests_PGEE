namespace Test5MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()

                  .Split()

                  .Select(int.Parse)

                  .ToList();



            string cmd = Console.ReadLine();

            static int Addition(int x) => x + 1;
            static int Multiplication(int x) => x * 2;
            static int Subtraction(int x) => x - 1;
            static void Print(int x) => Console.Write(x + " ");
            //Създават се 4 метода за съответните операции, които се извършват върху числата.

            while (!cmd.Equals("end"))

            {

                switch (cmd)

                {

                    case "add":

                        numbers = numbers.Select(Addition).ToList();// Променя се от малка на главна буква

                        break;

                    case "multiply":

                        numbers = numbers.Select(Multiplication).ToList();// Променя се от малка на главна буква

                        break;

                    case "subtract":

                        numbers = numbers.Select(Subtraction).ToList();// Променя се от малка на главна буква

                        break;

                    case "print":

                        foreach (var item in numbers)

                        {

                            Print(item);// Променя се от малка на главна буква

                        }

                        Console.WriteLine();

                        break;

                }



                cmd = Console.ReadLine();

            }
        }
    }
}
