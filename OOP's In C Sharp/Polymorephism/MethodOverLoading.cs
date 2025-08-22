using OOP_s_In_C_Sharp.Polymorephism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static OOP_s_In_C_Sharp.ConsoleProject01.LibraryManagementSystem.Book;

namespace OOP_s_In_C_Sharp.Polymorephism
{
    // Method overloading : -

    //Method Overloading is when two or more methods have the same name
    ///but different parameters(number or type of parameters).
    public class MethodOverLoading
    {
        public void Add(){
            Console.WriteLine("Simple Add Method");
        }
        public void Add(int num1, int num2) {
            Console.WriteLine($"Addition is : {num1 + num2}");
        }
        
        public void Add(float num1 , float num2) {

            Console.WriteLine($"Addition is  : {num1 +  num2}");
        }
        public void Add(float n1 , int n2) {

            Console.WriteLine($"Addition is : {n1 + n2 }");
        }
    }
}


//MethodOverLoading overLoading = new MethodOverLoading();

//overLoading.Add();
//overLoading.Add(10, 10);
//overLoading.Add(33.52f, 723.36f);