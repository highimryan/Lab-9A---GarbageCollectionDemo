using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator
    {
        // The purpose of this constructor is to enable you to verify that a Calculator
        // object has been successfully created.
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        /* This destructor simply displays a message so that you can see when the
        garbage collector runs and finalizes instances of this class. When writing
        classes for real-world applications, you would not normally output text in a
        destructor. */

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
        }

        /* This is a very straightforward method that divides the first parameter by the
        second and returns the result.It is provided just to add a bit of functionality
        that can be called by an application.*/
        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
