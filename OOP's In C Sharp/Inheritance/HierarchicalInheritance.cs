using System;
namespace OOP_s_In_C_Sharp.Inheritance
{
    // Hierarchical Inheritance is a type of inheritance in which multiple child classes inherit from a single parent class.
    public class LivingThings {
        public void Parent()
        {
            Console.WriteLine("This is Parent Method from LivingThings class");
        }
    }

    // Each child class can have its own specific methods and properties, while still inheriting the common functionality from the parent class.

    public class Animals : LivingThings
    {
        public void AnimalChildMethod()
        {
            Console.WriteLine("This is a Animal Child Class Method");
        }
    }

    public class Plants : LivingThings
    {
        public void PlantChildMethod()
        {
            Console.WriteLine("This is a Plant Child Class Method");
        }
    }

    internal class HierarchicalInheritance
    {
        public static void Main(String[] arg)
        {
            LivingThings lt = new LivingThings();

            lt.Parent(); // Output: This is Parent Method from LivingThings class

            Animals als = new Animals();
            als.Parent(); // Output: This is Parent Method from LivingThings class
            als.AnimalChildMethod(); // Output: This is a Animal Child Class Method

            Plants pls = new Plants();

            pls.Parent(); // Output: This is Parent Method from LivingThings class
            pls.PlantChildMethod(); // Output: This is a Plant Child Class Method
        }
    }
}


// Multiple inheritance is not supported in C# directly, but it can be achieved through interfaces.
// Multiple inheritance means that a class can inherit from more than one parent class.

// Multiple parent class inherits a single child class That is called as Multiple Inheritance.

// Hybrid inheritance is a combination of two or more types of inheritance, such as single, multiple, and hierarchical inheritance.
// C# does not support hybrid inheritance directly, but it can be achieved through interfaces and abstract classes.
// Hybrid inheritance can be implemented by combining different types of inheritance, such as single and hierarchical inheritance, to create a more complex structure.
