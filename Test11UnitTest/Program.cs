namespace Test11UnitTest
{
    public class Program
    {


        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = 0;

            if (operation == "+")
            {
                result = Add(a, b);
            }
            else if (operation == "*")
            {
                result = Multiply(a, b);
            }
            else if (operation == "-")
            {
                result = Subtract(a, b);
            }
            else if (operation == "/")
            {
                try
                {
                    result = Division(a, b);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Invalid result caused by division by zero!");
                }
            }

            Console.WriteLine(result);
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }
    }
}
