using System;
using System.Text;

namespace Task1
{
    class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {
            int[] array = WorkWithArray.WorkWithArray.GetArrayWithRandomValue(rand, 20, -100, 100);

            StringBuilder resultString = new StringBuilder();
            resultString.Append($"Initial array: \r\n{WorkWithArray.WorkWithArray.ToString(array)} \r\n");

            if (array.Length != 0)
            {
                int max = WorkWithArray.WorkWithArray.GetMaxValue(array);
                int min = WorkWithArray.WorkWithArray.GetMinValue(array);
                WorkWithArray.WorkWithArray.SortArray(ref array);
                resultString.Append($"Max value of array: {max}\r\nMin value of array: {min}\r\nSorted array: \r\n{WorkWithArray.WorkWithArray.ToString(array)}");
            }
            else
            {
                resultString.Append("Array is empty.");
            }

            Console.WriteLine(resultString);
            Console.ReadLine();
        }
    }
}
