using System;
using System.Text.RegularExpressions;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Regex timePattern = new Regex(@"\b(([01]?\d)|(2[0-3]))\:[0-5]\d\b");
            Console.WriteLine($"Time in the text contains { timePattern.Matches(text).Count} times");
            Console.ReadLine();
        }
    }
}
