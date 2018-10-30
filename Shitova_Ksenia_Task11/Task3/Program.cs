using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int n = 1000000;
            
            Dictionary<TwoDPointWithHash, int> dict = new Dictionary<TwoDPointWithHash, int>();

            for (int i = 0; i < n; i++)
            {
                TwoDPointWithHash point = new TwoDPointWithHash(rand.Next(-1000000, 1000000), rand.Next(-1000000, 1000000));
                if (!dict.ContainsKey(point))
                {
                    dict.Add(point, point.GetHashCode());
                }
            }

            var distinct = dict.Values.Distinct();
            

            Console.WriteLine($"The same: {dict.Count - distinct.Count()}, hashes all: {dict.Count}, percent: {(double)(dict.Count - distinct.Count()) * 100.0 /(double)dict.Count}");
           
            Console.ReadLine();
        }
    }
}
