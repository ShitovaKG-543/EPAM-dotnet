using System;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }

            StringBuilder resultString = new StringBuilder();
            resultString.Append($"Initial array: \r\n{ToString(array)} \r\n");

            if (array.Length != 0)
            {
                int max = GetMaxValue(array);
                int min = GetMinValue(array);
                SortArray(ref array);
                resultString.Append($"Max value of array: {max}\r\nMin value of array: {min}\r\nSorted array: \r\n{ToString(array)}"); 
            }
            else
            {
                resultString.Append("Array is empty.");
            }
            
            Console.WriteLine(resultString);
            Console.ReadLine();
        }

        private static int GetMaxValue(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
        
        private static int GetMinValue(int[] array)
        {
            int min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }

        private static void SortArray(ref int[] array)
        {
            int temp;
            int[] sortedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1 + i; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        private static string ToString(int[] array)
        {
            StringBuilder result = new StringBuilder();
            foreach (int elArray in array)
            {
                result.Append($"{elArray} ");
            }
            return result.ToString();
        }
    }
}
