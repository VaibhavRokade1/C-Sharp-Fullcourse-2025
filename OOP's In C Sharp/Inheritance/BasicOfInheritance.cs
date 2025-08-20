using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s_In_C_Sharp.Inheritance
{
    // example of inheritance in C#
    // Inheritance is a mechanism in C# that allows a class to inherit properties and methods from another class.

    // parent class
    class Animal {
    
        public void Eat() {
            Console.WriteLine("Animal is eating");
        }
        public void Sleep() {
            Console.WriteLine("Animal is sleeping");
        }
    }
    // child class

    class Dog : Animal {
        

        public void Bark() {
            Console.WriteLine("Dog is Runing.");
        }
    }

    internal class BasicOfInheritance
    {
        public static void Main() {

            Console.WriteLine("Hello World...!!!");

            Dog dog  = new Dog();
            dog.Eat(); // inherited method from Animal class
            dog.Sleep(); // inherited method from Animal class

            dog.Bark(); // method from Dog class
        }
    }
}

