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
            Fruit obj1= new Fruit();
            obj1.PrintName();
            Apple obj2= new Apple();
            obj2.PrintName();
        }
    }
}