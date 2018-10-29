using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringArray myStringsArray = new MyStringArray();
            myStringsArray.Add("dsfsf");
            myStringsArray.Add("rsa");
            myStringsArray.Add("kjs");
            myStringsArray.Add("g");
            myStringsArray.Add("tersses");

            Console.WriteLine("Initial strings array:");
            for (int i = 0; i < myStringsArray.Length; i++)
            {
                Console.WriteLine(myStringsArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Resulting strings array:");
            myStringsArray.Sort(MyStringArray.AscendingComparer);
            for (int i = 0; i < myStringsArray.Length; i++)
            {
                Console.WriteLine(myStringsArray[i]);
            }
            Console.ReadLine();
        }
    }
}
