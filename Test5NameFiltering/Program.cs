using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split().ToList();

        // Филтриране на имената
        List<string> filteredNames = FilterNamesByLength(names, length);

        // Печат на имената
        PrintNames(filteredNames);
    }

    // Функция, която филтрира имената по тяхната дължина
    static List<string> FilterNamesByLength(List<string> names, int length)
    {
        return names.Where(name => name.Length <= length).ToList();
    }

    // Функция, която отпечатва имената
    static void PrintNames(List<string> names)
    {
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
