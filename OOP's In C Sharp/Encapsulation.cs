using System;

namespace OOP_s_In_C_Sharp
{
    class Person {


        private int PId;
        private string Name;
        private decimal mobile;

        // getter methods

        public int getPersonId() => PId;
        public string getPersonName() => Name;
        public decimal getMobile() => mobile;

        // setter methods
        public int setPersonId(int id) => this.PId = id;

        public string setPersonName(string name) => this.Name = name;

        public decimal setPersonMobile(decimal mobile) =>this.mobile = mobile; 

    }
    internal class Encapsulation
    {

        public static void Main() {
        
            Person person = new Person();

            Console.WriteLine("Enter a Person id : ");
            person.setPersonId(int.Parse(Console.ReadLine()));

            Console.WriteLine("Enter a Person Name : ");
            person.setPersonName(Console.ReadLine());

            Console.WriteLine("Enter a Person mobile : ");
            person.setPersonMobile(decimal.Parse(Console.ReadLine()));


            Console.WriteLine($"Your id is :{person.getPersonId()} and name is  {person.getPersonName() } and your mobile is :{person.getMobile()}");


        }
    }
}
