using System;
using System.Diagnostics;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watchForString = new Stopwatch();
            Stopwatch watchForStringBuilder = new Stopwatch();

            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            watchForString.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            watchForString.Stop();

            watchForStringBuilder.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            watchForStringBuilder.Stop();

            Console.WriteLine($"Work time of class String: {watchForString.Elapsed}");
            Console.WriteLine($"Work time of class StringBuilder: {watchForStringBuilder.Elapsed}");

            if (watchForString.ElapsedTicks > watchForStringBuilder.ElapsedTicks)
            {
                Console.WriteLine($"Work time of class String more than work time of class StringBuilder {watchForString.ElapsedTicks / watchForStringBuilder.ElapsedTicks} times");
            }
            else
            {
                Console.WriteLine($"Work time of class StringBuilder more than work time of class String {watchForStringBuilder.ElapsedTicks / watchForString.ElapsedTicks} times");
            }

            Console.ReadLine();
        }
    }
}
