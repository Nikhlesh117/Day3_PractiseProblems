using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class Constructor
    {
        private int num1;
        private int num2;

        // Parameterized constructor
        public Constructor(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }
        // Copy constructor
        public Constructor(Constructor obj)
        {
            num1 = obj.num1;
            num2 = obj.num2;
        }

        // Non-parameterized constructor
        public Constructor()
        {
            num1 = 0;
            num2 = 0;
        }
        
        // Static constructor
        static Constructor()
        {
            Console.WriteLine("Static constructor called");
        }
        // Private constructor
        private Constructor(int n)
        {
            num1 = n;
            num2 = n;
        }
        public int Sum()
        {
            return num1 + num2;
        }


    }
}
