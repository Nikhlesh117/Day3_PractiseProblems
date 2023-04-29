using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    class baseClass
    {
        public virtual int Calculate(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    class derived : baseClass
    {
        public override int Calculate(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
