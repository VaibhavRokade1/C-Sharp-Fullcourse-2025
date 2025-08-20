using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_s_In_C_Sharp.Encapsulatation
{
    internal class Datahiding
    {
        public class Person
        {
            // Private fields to store the internal state of the object
            private int PId;
            private string Name;
            private decimal mobile;
            // Getter methods to access the private fields
            public int getPersonId() => PId;
            public string getPersonName() => Name;
            public decimal getMobile() => mobile;
            // Setter methods to modify the private fields
            public void setPersonId(int id) => this.PId = id;
            public void setPersonName(string name) => this.Name = name;
            public void setPersonMobile(decimal mobile) => this.mobile = mobile;
        }
        public static void Main()
        {
            // Data hiding is a concept of restricting access to the internal state of an object.
            // It is achieved by using access modifiers like private, protected, and public.
            // This ensures that the internal representation of an object is hidden from the outside.

            // access modifiers : 
            // private - accessible only within the class
            // protected - accessible within the class and its derived ( child ) classes
            // public - accessible from anywhere

            // Example of data hiding in C#

            Person person = new Person();

            Console.WriteLine("Enter a Person id : ");
            person.setPersonId(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter a Person Name : ");
            person.setPersonName(Console.ReadLine());

            Console.WriteLine("Enter a Person mobile : ");
            person.setPersonMobile(decimal.Parse(Console.ReadLine()));

            Console.WriteLine($"Your id is :{person.getPersonId()} and name is  {person.getPersonName()} and your mobile is :{person.getMobile()}");
        }
    }
}
