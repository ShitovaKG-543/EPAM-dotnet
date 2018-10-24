using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            ICollection<int> list = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                list.Add(i + 1);
            }
            Console.WriteLine($"Initial list:");
            foreach (var el in list)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();

            RemoveEachSecondItem<int>(ref list);
            Console.WriteLine($"Remaining item: {list.First()}\r\n");

            ICollection<int> linkedList = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                linkedList.Add(i + 1);
            }
            Console.WriteLine($"Initial linkedList:");
            foreach (var el in linkedList)
            {
                Console.Write($"{el} ");
            }
            Console.WriteLine();

            RemoveEachSecondItem<int>(ref linkedList);
            Console.WriteLine($"Remaining item: {linkedList.First()}");

            Console.ReadLine();
        }

        public static void RemoveEachSecondItem<T>(ref ICollection<T> list)
        {
            T[] array = new T[list.Count];
            list.CopyTo(array,0);
            List<T> newList = array.ToList();
            
            int j = 1;
            while (newList.Count > 1)
            {
                while (j < newList.Count)
                {
                    newList.RemoveAt(j);
                    j += 1;
                }
                j = (j + 1 - newList.Count > 1) ? 1 : 0;
            }
            list = newList;
        }


        //private static void RemoveEachSecondItem(List<int> list)
        //{
        //    int j = 1;
        //    while (list.Count > 1)
        //    {
        //        while (j < list.Count)
        //        {
        //            list.RemoveAt(j);
        //            j += 1;
        //        }

        //        if (j + 1 - list.Count > 1)
        //        {
        //            j = 1;
        //        }
        //        else
        //        {
        //            j = 0;
        //        }
        //    }
        //}

        //private static void RemoveEachSecondItem(LinkedList<int> linkedList)
        //{
        //    var currentItem = linkedList.First;
        //    while (linkedList.Count > 1)
        //    {
        //        linkedList.Remove(currentItem.Next ?? linkedList.First);
        //        currentItem = currentItem.Next ?? linkedList.First;
        //    }
        //}

    }
}
