using System;
using System.Collections.Generic;
using System.Linq;


namespace OOPsInCSharp.Linq_in_C_
{
    internal class Employee 
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string deparment { get; set; }
        public double salary { get; set; }

        public override string ToString()
        {
            return $"[ id : {this.id} , name : {this.name} , age : {this.age} , department : {this.deparment} , salary :{this.salary} ]";
        }
    }
    public class SelectMethod
    {

        //List<Employee> emp = new List<Employee> {
        //    new Employee(){ id = 1 , name = "Rahul Sharma" , age = 24 , deparment = "IT" , salary = 35000.50 },
        //    new Employee(){ id = 2 , name = "Priya Verma" , age = 29 , deparment = "HR" , salary = 42000.75 },
        //    new Employee(){ id = 3 , name = "Amit Patel" , age = 32 , deparment = "Finance" , salary = 50000.00 },
        //    new Employee(){ id = 4 , name = "Sneha Gupta" , age = 26 , deparment = "Marketing" , salary = 38000.25 },
        //    new Employee(){ id = 5 , name = "Rohan Mehta" , age = 28 , deparment = "Operations" , salary = 45000.90 },
        //    new Employee(){ id = 6 , name = "Neha Singh" , age = 30 , deparment = "Sales" , salary = 47000.10 },
        //    new Employee(){ id = 7 , name = "Vikram Joshi" , age = 35 , deparment = "IT" , salary = 60000.00 },
        //    new Employee(){ id = 8 , name = "Anjali Nair" , age = 27 , deparment = "Finance" , salary = 52000.30 },
        //    new Employee(){ id = 9 , name = "Karan Kapoor" , age = 31 , deparment = "HR" , salary = 41000.80 },
        //    new Employee(){ id = 10 , name = "Divya Rao" , age = 25 , deparment = "Marketing" , salary = 39000.40 },
        //};


        //public static void Main(String[] args) 
        //{
        //    SelectMethod sm = new SelectMethod();

        //    //IEnumerable<string> names = sm.emp.Select(e => e.name).ToArray();

        //    // select method is use to tranform one form to another form like collaction to string or more than that 

        //    //foreach (var name in names)
        //    //{
        //    //    Console.WriteLine($"Name  : {name}");
        //    //}

        //}
    }
}
