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
    }
    public class SelectMethod
    {
        
        List<Employee> emp = new List<Employee> {
            new Employee(){ id = 1 , name = "Vaibhav Rokade" , age = 19 , deparment = "IT" , salary = 1000.10},
            new Employee(){ id = 2 , name = "Vaibhav Rokade" , age = 26 , deparment = "IT" , salary = 2000.10},
            new Employee(){ id = 3 , name = "Vaibhav Rokade" , age = 19 , deparment = "IT" , salary = 1500.10},
            new Employee(){ id = 4 , name = "Vaibhav Rokade" , age = 19 , deparment = "IT" , salary = 1900.10},
            new Employee(){ id = 5 , name = "Vaibhav Rokade" , age = 19 , deparment = "IT" , salary = 1080.10},
        };


        public static void Main(String[] args) 
        {
            SelectMethod sm = new SelectMethod();

            //IEnumerable<string> names = sm.emp.Select(e => e.name).ToArray();

            // select method is use to tranform one form to another form like collaction to string or more than that 

            //foreach (var name in names)
            //{
            //    Console.WriteLine($"Name  : {name}");
            //}

        }
    }
}
