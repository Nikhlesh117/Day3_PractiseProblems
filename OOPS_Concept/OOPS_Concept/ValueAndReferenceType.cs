using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class ValueAndReferenceType
    {
        //Value Type
        public void Value(int a, int b)
        {
            Console.WriteLine("addition : " + (a + b));
        }

        //Reference Type  
        public void Reference(ref int a, int b)
        {
            Console.WriteLine("subtraction : " + (a - b));
        }
    }
}
