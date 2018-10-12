using System;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                Round round = new Round(12, 32, 6);
                result.Append($"{round}\r\n");
                result.Append(string.Format("Round length: {0:0.##}\r\n", round.RoundLength));
                result.Append(string.Format("Round square: {0:0.##}\r\n", round.RoundSquare));
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
