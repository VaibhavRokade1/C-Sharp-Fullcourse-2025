using System;
namespace OOP_s_In_C_Sharp.Inheritance
{
    // simple class with their own propperty 
    public class A {
        public void Display() {
            Console.WriteLine("Class A is called");
            Console.WriteLine("Has-a-Reetionship....");
        }
    }
    internal class MyInheritance
    {
       public static void Main() {
            // Implemented in code by including one class as a field/property inside another.
            //that is called as has a reletionship

            A obj = new A();
            obj.Display();
        }
    }
}
