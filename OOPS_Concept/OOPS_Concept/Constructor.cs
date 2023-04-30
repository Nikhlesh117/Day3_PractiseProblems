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

        // Non-parameterized constructor
        public Constructor()
        {
            num1 = 0;
            num2 = 0;
        }
        public int Sum()
        {
            return num1 + num2;
        }
    }
}
