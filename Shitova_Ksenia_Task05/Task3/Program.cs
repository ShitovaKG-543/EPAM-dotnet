using System;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                Triangle triangle = new Triangle(12, 7, 8);
                result.Append($"{triangle}\r\n");
                result.Append(string.Format("Triangle perimeter: {0:0.##}\r\n", triangle.GetTrianglePerimeter()));
                result.Append(string.Format("Triangle square: {0:0.##}\r\n", triangle.GetTriangleSquare()));
                Console.WriteLine(result);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
