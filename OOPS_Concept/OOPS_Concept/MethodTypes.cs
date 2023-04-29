using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class MethodTypes
    {
        // Method without parameters and return type
        public void Greeting()
        {
            Console.WriteLine("Maths Operation");
        }

        // Method with parameters and without return type
        public void Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Result of addition: " + result);
        }

        // Method with parameters and return type
        public int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }
}
