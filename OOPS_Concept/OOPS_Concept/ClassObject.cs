using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPS_Concept
{
    public class ClassObject
    {
        public void person()
        {
            Console.WriteLine("Enter the your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hi, my name is " + name + " and I am " + age + " years old.");

        }
    }
}
