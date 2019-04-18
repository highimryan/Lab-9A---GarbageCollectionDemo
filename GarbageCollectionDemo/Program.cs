using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This code creates a Calculator object, calls the Divide method of this object
            (and displays the result), and then outputs a message as the program
            finishes. */

            Calculator calculator = new Calculator();
            Console.WriteLine($"120 / 15 = {calculator.Divide(120, 15)}");
            Console.WriteLine("Program finishing");
        }
    }
}
