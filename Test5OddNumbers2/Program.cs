using System;
using System.Collections.Generic;

namespace Test5OddNumbers2
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<int> numbers = ParseNumbers(input);

            Console.WriteLine(string.Join(", ", numbers));
        }

        static List<int> ParseNumbers(string input)
        {
            List<int> numbers = new List<int>();
            string[] parts = input.Split(' ');

            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine($"'{part}' не е валидно цяло число и ще бъде пропуснато.");
                }
            }

            return numbers;
        }
    }
}
