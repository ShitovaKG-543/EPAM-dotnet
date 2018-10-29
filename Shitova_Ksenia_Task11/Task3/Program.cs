using System;

namespace Task3
{
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            TwoDPointWithHash newPoint1 = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash newPoint2 = new TwoDPointWithHash(10, 10);

            Console.WriteLine("Hash for point1: {0}\tHash for point2: {1}", newPoint1.GetHashCode(), newPoint2.GetHashCode());

            Console.ReadLine();
        }
    }
}
