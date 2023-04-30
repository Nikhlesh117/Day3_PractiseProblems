using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    // Base Class
    public class Shape_one
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    // Derived Class 1
    public class Circle_one : Shape_one
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    // Derived Class 2
    public class Rectangle_one : Shape_one
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
