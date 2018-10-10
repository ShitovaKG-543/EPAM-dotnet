using System;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter HTML text: ");
            string htmlText = Console.ReadLine();

            Regex pattern = new Regex(@"<[^>]*>");
            string result = pattern.Replace(htmlText, "_");

            Console.WriteLine($"Replacement result: {result}");
            Console.ReadLine();
        }
    }
}
