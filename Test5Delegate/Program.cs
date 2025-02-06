namespace Test5Delegate
{
    class Program
    {
        delegate double SumDelegate(double a, double b);

        static void Main()
        {
            SumDelegate sumDelegate = Sum;

            double result = sumDelegate(5.5, 3.3);
            Console.WriteLine($"Резултатът: {result}");
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}
