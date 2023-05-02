using System.Drawing;
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
            //Encapsulation encapsulation = new Encapsulation();
            //string name = encapsulation.Name = "Nk";
            //int age = encapsulation.Age = 88;
            //Console.WriteLine("Hi, my name is " + name + " and I am " + age + " years old.");

            //Abstraction
            //Shape circle = new Circle();
            //circle.Draw();

            //MethodTypes
            //MethodTypes math = new MethodTypes();
            //math.Greeting();
            //math.Add(10, 5);
            //int result = math.Subtract(10, 5);
            //Console.WriteLine("Result of subtraction: " + result);

            //Value And Reference type
            //int x = 40;
            //int y = 10;
            //ValueAndReferenceType obj = new ValueAndReferenceType();
            //obj.Value(x, y);
            //obj.Reference(ref x, y);

            //SingleLevelInheritence
            //Student student = new Student();
            //student.Name = "NK";
            //student.Age = 20;
            //student.StudentID = "1234";
            //student.Greeting();
            //student.Study();
            //Console.WriteLine("-----------------------------------------------");
            //MultiLevelInheritance 
            //CollegeStudent collegeStudent = new CollegeStudent();
            //collegeStudent.Name = "NK";
            //collegeStudent.Age = 20;
            //collegeStudent.StudentID = "1234";
            //collegeStudent.Major = "Computer Science";
            //collegeStudent.Greeting();
            //collegeStudent.Study();
            //collegeStudent.AttendClass();
            //Console.WriteLine("-----------------------------------------------");
            //HierarchicalInheritance
            //Circle_one circle = new Circle_one();
            //circle.Draw();
            //Rectangle_one rectangle = new Rectangle_one();
            //rectangle.Draw();

            // Constructors
            Constructor obj1 = new Constructor(5, 10);
            Constructor obj2 = new Constructor();
            Constructor obj3 = new Constructor(obj1);
            //Constructor obj4 = new Constructor(5); // This line will cause a compilation error because the constructor is private

            Console.WriteLine("Sum of obj1: " + obj1.Sum());
            Console.WriteLine("Sum of obj2: " + obj2.Sum());
            Console.WriteLine("Sum using copy constructor: " + obj3.Sum());

            //Interface
            //Dog dog = new Dog();
            //dog.Speak();
            //Cat cat = new Cat();
            //cat.Speak();

            //AccessModifiers
            //AccessModifiers obj = new AccessModifiers();
            //obj.PublicMethod();
            //obj.InternalMethod();
            //obj.ProtectedMethod();  //Error: Cannot access protected method from outside the class or its derived classes
            //obj.PrivateMethod();    //Error: Cannot access private method from outside the class
        }
    }
}