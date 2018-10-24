using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        //public delegate void Message(string text);
        //public delegate void PersonDelegate(Person person, DateTime time);

        static void Main(string[] args)
        {
            Office o = new Office();
            Person p1 = new Person("Alex");
            Person p2 = new Person("John");
            Person p3 = new Person("Kate");
            Person p4 = new Person("Georgy");
            Person p5 = new Person("Garry");
            o.Add(p1);
            Console.WriteLine();
            o.Add(p2);
            Console.WriteLine();
            o.Add(p3);
            Console.WriteLine();
            o.Add(p4);
            Console.WriteLine();
            o.Add(p5);
            Console.WriteLine();

            Console.WriteLine();
            o.Remove(p3);
            Console.WriteLine();
            o.Remove(p1);
            Console.WriteLine();
            o.Remove(p2);
            Console.WriteLine();
            o.Remove(p4);
            Console.WriteLine();
            o.Remove(p5);

            Console.ReadLine();
        }
    }
}
