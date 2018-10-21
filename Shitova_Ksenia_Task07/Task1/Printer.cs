using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Printer : IPrinter
    {
        public void Print(double x, double y)
        {
            Console.WriteLine($"This is figure with coordinates X = {x}, Y = {y}\r\n");
        }
    }
}
