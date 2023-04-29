using System.Xml.Linq;

namespace OOPS_Concept
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ClassAndObject
            //ClassObject classObject = new ClassObject();
            //classObject.person();

            //Polymorphism
            //Fruit obj1= new Fruit();
            //obj1.PrintName();
            //Apple obj2= new Apple();
            //obj2.PrintName();

            //Overloading
            //Overloading overloading= new Overloading();
            //Console.WriteLine("Add with two int parameter :" + overloading.Add(4, 2));
            //Console.WriteLine("Add with three int parameter :" + overloading.Add(2, 2, 8));

            //Override
            //baseClass addition = new baseClass();           
            //Console.WriteLine("Result of addition operation: " + addition.Calculate(10, 5));
            //derived subtraction = new derived();
            //Console.WriteLine("Result of subtraction operation: " + subtraction.Calculate(10, 5));

            //Encapsulation
            Encapsulation encapsulation = new Encapsulation();

            string name = encapsulation.Name = "Nk";
            int age = encapsulation.Age = 88;
            Console.WriteLine("Hi, my name is " + name + " and I am " + age + " years old.");
        }
    }
}