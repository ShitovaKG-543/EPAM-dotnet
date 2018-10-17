using System;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double start = 2;
            double step = 3;
            GeometricProgression geometricProgression = new GeometricProgression(start, step);
            Console.WriteLine($"Geometric progression with first value {start} and step {step}:\r\n {PrintSeries(geometricProgression)}");
            Console.ReadLine();
        }


        static string PrintSeries(ISeries series)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                result.Append($"{series.GetCurrent()} ");
                series.MoveNext();
            }
            return result.ToString();
        }
    }
}
