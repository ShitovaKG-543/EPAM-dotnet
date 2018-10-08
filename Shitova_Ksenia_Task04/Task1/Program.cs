using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            string initialString = Console.ReadLine();
            string pattern = @"\W+";
            string[] elements = Regex.Split(initialString, pattern);
            int sum = 0;
            foreach (string element in elements)
            {
                sum += element.Length;
            }
            Console.WriteLine($"Average length of word: { sum / elements.Length }");
            Console.ReadLine();
        }
    }
}
