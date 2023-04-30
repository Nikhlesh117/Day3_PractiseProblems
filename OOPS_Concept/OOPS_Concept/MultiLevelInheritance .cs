using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    // Base Class
    public class Person_One
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Greeting()
        {
            Console.WriteLine("Hello, my name is " + Name + " and I am " + Age + " years old.");
        }
    }

    // Derived Class 1
    public class Student_One : Person
    {
        public string StudentID { get; set; }

        public void Study()
        {
            Console.WriteLine("I am studying and my StudentID is "+ StudentID);
        }
    }
    // Derived Class 2
    public class CollegeStudent : Student_One
    {
        public string Major { get; set; }

        public void AttendClass()
        {
            Console.WriteLine("I am attending class of Major "+ Major);
        }
    }
}
