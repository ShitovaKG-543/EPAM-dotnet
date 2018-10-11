using System;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first string:");
                MyString firstString = new MyString(Console.ReadLine().Trim().ToCharArray());
                Console.WriteLine("Enter second string:");
                MyString secondString = new MyString(Console.ReadLine().Trim().ToCharArray());

                StringBuilder stringResult = new StringBuilder();

                stringResult.Append($"{firstString} + {secondString}: {firstString + secondString}\r\n");
                stringResult.Append($"{firstString} - {secondString}: {firstString - secondString}\r\n");
                stringResult.Append($"{firstString} == {secondString}: {firstString == secondString}\r\n");
                stringResult.Append($"{firstString} != {secondString}: {firstString != secondString}\r\n");

                Console.WriteLine(stringResult);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
