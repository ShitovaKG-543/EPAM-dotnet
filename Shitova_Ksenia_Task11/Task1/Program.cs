using System;
using MathLibrary;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"2^5 = {MathFunction.Pow(2.0, 5.0)}");
            Console.WriteLine($"5! = {MathFunction.Factorial(5)}");
            Console.ReadLine();
        }
    }
}
