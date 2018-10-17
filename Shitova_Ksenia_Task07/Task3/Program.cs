using System;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1, 4, 3, 1, 6, 7, 3, 2 };
            IIndexable list = new List(array);
            Console.WriteLine($"{list.GetType().Name}: {PrintSeries(list)}");
            IIndexable arithmeticalProgression = new ArithmeticalProgression(2, 3, 10);
            Console.WriteLine($"{arithmeticalProgression.GetType().Name}: {PrintSeries(arithmeticalProgression)}");
            Console.ReadLine();
        }

        static string PrintSeries(IIndexable series)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < series.GetLength(); i++)
            {
                result.Append($"{series[i]} ");
            }
            return result.ToString();
        }

    }
}
