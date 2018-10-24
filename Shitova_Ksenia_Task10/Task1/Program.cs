using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringArray myStringArray = new MyStringArray();
            myStringArray.Add("dsfsf");
            myStringArray.Add("rsa");
            myStringArray.Add("kjs");
            myStringArray.Add("g");
            myStringArray.Add("tersses");

            Console.WriteLine("Initial strings array:");
            for (int i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine(myStringArray[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Resulting strings array:");
            myStringArray.Sort(MyStringArray.AscendingComparer);
            for (int i = 0; i < myStringArray.Length; i++)
            {
                Console.WriteLine(myStringArray[i]);
            }
            Console.ReadLine();
        }
    }
}
