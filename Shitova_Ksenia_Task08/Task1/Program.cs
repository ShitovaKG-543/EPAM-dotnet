using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DynamicArray<int> dinamicArray = new DynamicArray<int>();
                Console.WriteLine($"Length = { dinamicArray.Length}, Capacity = { dinamicArray.Capacity}");

                dinamicArray = new DynamicArray<int>(2);
                Console.WriteLine($"Length = { dinamicArray.Length}, Capacity = { dinamicArray.Capacity}");

                int[] array = { 1, 2 };

                dinamicArray = new DynamicArray<int>(array);
                Console.WriteLine($"Dinamic array:\r\n {dinamicArray}, Length = {dinamicArray.Length}, Capacity = {dinamicArray.Capacity}");

                dinamicArray.Add(10);
                Console.WriteLine($"Dinamic array after add element with value 10:\r\n {dinamicArray}, Length = {dinamicArray.Length}, Capacity = {dinamicArray.Capacity}");

                int[] arrayForAdd = { 2, 3, 4, 7, 5, 8, 4, 1, 4, 6 };
                dinamicArray.AddRange(arrayForAdd);
                Console.WriteLine($"Dinamic array after add range:\r\n {dinamicArray}\r\nLength = {dinamicArray.Length}");

                Console.WriteLine($"Remove element with value 4: {dinamicArray.Remove(4)},\r\n Dinamic array: {dinamicArray}, Length = {dinamicArray.Length}, Capacity = {dinamicArray.Capacity}");

                dinamicArray.Insert(3, 333);
                Console.WriteLine($"Dinamic array after insert element 3 with value = 333:\r\n Dinamic array: {dinamicArray}, Length = {dinamicArray.Length}, Capacity = {dinamicArray.Capacity}");

                Console.WriteLine($"Array element with index = 2: {dinamicArray[2]}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
