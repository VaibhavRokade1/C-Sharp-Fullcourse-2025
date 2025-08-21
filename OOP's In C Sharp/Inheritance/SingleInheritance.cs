using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s_In_C_Sharp.Inheritance
{
    class ClassA // single inheritance 
    {
        public void Output()
        {
            Console.WriteLine("Method A from ClassA");
        }
    }
    public class SingleInheritance
    {
      public static void Main(string[] args)
        {
            // Single Inheritance is a type of inheritance in which a class (child class) inherits from only one parent class.
            // This means that the child class can access the members (fields, properties, methods) of the parent class.
            ClassA obj = new ClassA();


            // every class is by default inherit from object class.
            // In C#, the Object class is the base class for all classes.

            
            obj.Output(); // Output: Method A from ClassA
        }

    }
}
