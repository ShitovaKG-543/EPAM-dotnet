using System;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex numberInNormalNotationPattern = new Regex(@"^[-+]?\d+\.?\d*$");
            Regex numberInScientificNotationPattern = new Regex(@"^[-+]?\d\.?\d*e-?\d+$");

            Console.Write("Enter number: ");
            string htmlText = Console.ReadLine().Trim();

            if (numberInNormalNotationPattern.IsMatch(htmlText))
            {
                Console.WriteLine("Это число в обычной нотации");
            }
            else if (numberInScientificNotationPattern.IsMatch(htmlText))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }

            Console.ReadLine();
        }
    }
}
