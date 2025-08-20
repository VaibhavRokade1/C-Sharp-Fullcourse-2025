using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s_In_C_Sharp
{
    internal class ObjectCreation
    {
      



        // ------------------------------ Start Person ------------------------------------------
        class Person
        {
            //Person()
            //{
            //    Id = 1;
            //    name = "Vaibhav Rokade";
            //    age = 30;
            //}

            public int Id;
            public String name;
            public int age;

            public void display()
            {

                Console.WriteLine($"My Name is {this.name}, my age {this.age} years old and my ID is {this.Id}");
            }

        }
        // ------------------------------ End Person ------------------------------------------


        // ------------------------------ Start Room ----------------------------------------
        class Room
        {

            public int RoomId;
            public string RoomType;
            public decimal RoomRent;

            public void Display()
            {
                Console.WriteLine($"Your RoomId is : {RoomId} , RoomType is : {RoomType} and RoomRente is : {RoomRent}");
            }
        }
        // ------------------------------ End Room ------------------------------------------


        // ------------------------------ Start Watch ---------------------------------------
        class Watch
        {

            public int WatchID;
            public string Componyname;
            public float WatchPrice;

            public void Display()
            {
                Console.WriteLine($"Your WatchID is : {WatchID} , name of the watch Compony is : {Componyname} and Watch Price is :{WatchPrice} ");
            }

        }
        // ------------------------------ End Watch -----------------------------------------



        // ------------------------------ Start Student ---------------------------------------
        class Student
        {
            public int StudentId;
            public string StudentName;
            public string course;

            public void Display()
            {
                Console.WriteLine($"your id is : {StudentId} \n your name is {StudentName} \n Your course is : {course}");
            }

        }
        // ------------------------------ End Student -----------------------------------------


        // ------------------------------ Start Book ---------------------------------------
        class Book
        {
            public int BookID;
            public string BookName;
            public float BookPrice;

            public void Display()
            {

                Console.WriteLine($"Book Id is : {BookID} and your book name is : {BookName} and your book price : {BookPrice}");

            }
        }

        // ------------------------------ End Book -----------------------------------------


        // ------------------------------ Start Account ---------------------------------------

        class Account
        {
            public int AccountId;
            public string UserName;
            public float Balance;

            public void Display()
            {
                Console.WriteLine($"Account Id is : {AccountId} and your Account name is : {UserName} and your Balance : {Balance}");
            }
        }

        // ------------------------------ End Account -----------------------------------------


        // ------------------------------ Start Laptop ---------------------------------------
        class Laptop
        {

            public int LaptopID;
            public string LaptopName;
            public float LaptopPrice;

            public void Display()
            {
                Console.WriteLine($" Lapotp ID id {LaptopID} , Laptop Name is {LaptopName} and laptop price is  {LaptopPrice}");
            }
        }
        // ------------------------------ End Laptop -----------------------------------------

        // ------------------------------ Start Movie ---------------------------------------
        class Movie
        {
            public int MovieID;
            public string MovieName;
            public float MoviePrice;


            public void Display()
            {
                Console.WriteLine($"Your Movie id is  {MovieID} , Your Movie Name  is {MovieName} , and its price is :{MoviePrice}");
            }
        }
        // ------------------------------ End Movie -----------------------------------------


        // ------------------------------  Start Country ---------------------------------------

        class Country
        {

            public int CountryID;
            public string Name;
            public string CountryName;

            public void Display()
            {
                Console.WriteLine($"hi {Name} ,Your Country code is {CountryID} and your Country name is {CountryName}  ");
            }


        }

        // ------------------------------ End  Country -----------------------------------------


        // ------------------------------ Start Compony ---------------------------------------

        class Compony
        {
            public int ComponyID;
            public string ComponyName;
            public string ProductName;

            public void Display()
            {
                Console.WriteLine($"Compony id is : {ComponyName} , Conmpony name is : {ComponyName} and Compony Product is {ProductName}");
            }
        }
        // ------------------------------ End Compony -----------------------------------------





        
            static void Main(string[] args)
            {
                //Person p1 = new Person(); 

                //--- Person ----
                Person p = new Person();

                Console.WriteLine("Enter a Person Id : ");
                p.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Person Name : ");
                p.name = Console.ReadLine();

                Console.WriteLine("Enter a Person Age : ");
                p.age = int.Parse(Console.ReadLine());

                p.display();


                //--- Person ----

                //--- Room ----

                Room R = new Room();

                Console.WriteLine("Enter a roomId : ");
                R.RoomId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a RoomType : ");
                R.RoomType = Console.ReadLine();

                Console.WriteLine("Enter a Rent : ");
                R.RoomRent = decimal.Parse(Console.ReadLine());

                R.Display();


                //--- Room ----

                //--- Watch ----

                Watch Wch = new Watch();

                Console.WriteLine("Enter a WatchId : ");
                Wch.WatchID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a ComponyName for Watch : ");
                Wch.Componyname = Console.ReadLine();

                Console.WriteLine("Enter a Watch Price  : ");
                Wch.WatchPrice = float.Parse(Console.ReadLine());

                Wch.Display();
                //--- Watch ----


                //--- Student ----

                Student s = new Student();

                Console.WriteLine("Enter a student id : ");
                s.StudentId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Student name : ");
                s.StudentName = Console.ReadLine();

                Console.WriteLine("Enter a Course :");

                s.course = Console.ReadLine();

                s.Display();

                //--- Student ----


                //--- Book ----

                Book book = new Book();

                Console.WriteLine("Enter a Book Id :");
                book.BookID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Book Name : ");
                book.BookName = Console.ReadLine();

                Console.WriteLine("Enter a Book Price : ");
                book.BookPrice = float.Parse(Console.ReadLine());


                book.Display();

                //--- Book ----



                //--- Account ----

                Account account = new Account();

                Console.WriteLine("Enter a Book Id :");
                account.AccountId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Book Name : ");
                account.UserName = Console.ReadLine();

                Console.WriteLine("Enter a Book Price : ");
                account.Balance = float.Parse(Console.ReadLine());


                account.Display();


                //--- Account ---


                //--- Laptop ----

                Laptop laptop = new Laptop();

                Console.WriteLine("Enter a laptop id ");
                laptop.LaptopID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a laptop Name : ");
                laptop.LaptopName = Console.ReadLine();

                Console.WriteLine("Enter laptop Price : ");
                laptop.LaptopPrice = float.Parse(Console.ReadLine());

                laptop.Display();

                //--- Laptop ----



                //---- Movie ----- 

                Movie movie = new Movie();

                Console.WriteLine("Enter a movie id ");
                movie.MovieID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a movie Name : ");
                movie.MovieName = Console.ReadLine();

                Console.WriteLine("Enter a movie price ");
                movie.MoviePrice = float.Parse(Console.ReadLine());

                movie.Display();

                //---- Movie -----


                // ---- Country -----
                Country country = new Country();

                Console.WriteLine("Enter a Country Code");
                country.CountryID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a User Name :");
                country.Name = Console.ReadLine();

                Console.WriteLine("Enter a Country name ");
                country.CountryName = Console.ReadLine();

                country.Display();


                // ---- Country -----


                // ---- Company -----

                Compony compony = new Compony();

                Console.WriteLine("Enter a compony id ");
                compony.ComponyID = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a Compony Name : ");
                compony.ComponyName = Console.ReadLine();

                Console.WriteLine("Enter a Product Name :");
                compony.ProductName = Console.ReadLine();

                compony.Display();

                // ---- Company -----







            }
        }
    }

