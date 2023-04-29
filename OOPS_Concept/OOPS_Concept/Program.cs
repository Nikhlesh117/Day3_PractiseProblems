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
            Overloading overloading= new Overloading();
            Console.WriteLine("Add with two int parameter :" + overloading.Add(4, 2));
            Console.WriteLine("Add with three int parameter :" + overloading.Add(2, 2, 8));
        }
    }
}