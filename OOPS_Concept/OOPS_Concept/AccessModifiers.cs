using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    public class AccessModifiers
    {
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }

        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }
    }
}
