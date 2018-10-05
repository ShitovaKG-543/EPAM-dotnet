using System;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = WorkWithArray.WorkWithArray.GetArrayWithRandomValue(20, -100, 100);
            StringBuilder resultString = new StringBuilder();
            resultString.Append($"Initial array: \r\n{WorkWithArray.WorkWithArray.ToString(array)}\r\n");
            resultString.Append($"Sum of the non-negative elements of the array: {GetArrayNonNegativeElementsSum(array)}");
            Console.WriteLine(resultString);
            Console.ReadLine();
        }

        public static int GetArrayNonNegativeElementsSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
