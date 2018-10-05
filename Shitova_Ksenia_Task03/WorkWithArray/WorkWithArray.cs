using System;
using System.Text;

namespace WorkWithArray
{
    public static class WorkWithArray
    {
        public static int[] GetArrayWithRandomValue(int numberElements, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] array = new int[numberElements];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(minValue, maxValue);
            }
            return array;
        }

        public static int GetMaxValue(int[] array)
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

        public static int GetMinValue(int[] array)
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

        public static void SortArray(ref int[] array)
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

        public static string ToString(int[] array)
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
