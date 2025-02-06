using System;
using System.Linq;
using System.Collections.Generic;

namespace Test5OddNumbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> numbers = input.Split(", ").Select(int.Parse).ToList();
            List<int> oddNumbers = numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToList();
            Console.WriteLine(string.Join(", ", oddNumbers));
        }
    }
}
