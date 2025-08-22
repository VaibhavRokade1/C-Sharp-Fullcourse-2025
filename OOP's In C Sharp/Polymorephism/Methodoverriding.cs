using System;

namespace OOP_s_In_C_Sharp.Polymorephism
{
    class Person{

        public virtual void Eat()
        {
            Console.WriteLine("Hi this is Person Class Method.");
        }
    }
    class Vaibhav : Person {
        public override void Eat()
        {
            Console.WriteLine("Hi this is Vaibhav Class Method from Preson Parent.");
        }
    }

    internal class Methodoverriding
    {
        public static void Main()
        {
            Console.WriteLine("Method Overriding Demo");

            // Reference Person Class Object creation Person class
            Person person = new Person();
            person.Eat();

            // Reference Person class but Object creation child Class 

            Person obj = new Vaibhav();
            obj.Eat();

            Vaibhav vaibhav = new Vaibhav();
            vaibhav.Eat();
        }
    }
}
