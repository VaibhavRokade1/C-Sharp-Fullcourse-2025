using System;
using System.Text;
using static OOP_s_In_C_Sharp.ConsoleProject01.LibraryManagementSystem.Book;

namespace OOP_s_In_C_Sharp.ConsoleProject01
{
    internal class LibraryManagementSystem
    {
        public class Library{
            Random ran = new Random();
            public Library() {
                this.BookId = (int)ran.Next(1000 , 2000);
                this.MemberId = (int)ran.Next(11111, 99999);
                this.BookCount = 0;
            }
            public int BookId;
            public int BookCount;
            public int MemberId;

        }
        public class Book : Library{
            private string BookName;
            private string BookAuthorName;
            private int BookQuantity;

            // Setters
            public string SetBookName(string bname) => this.BookName = bname;
            public string SetBookAuthorName(string bauthor) => this.BookAuthorName = bauthor;
            public int SetBookQuantity(int qty) => this.BookQuantity = qty;

            // Getters
            public int GetBookId() =>BookId;
            public string GetBookName() => this.BookName;
            public string GetBookAuthorName() => this.BookAuthorName;
            public int GetBookQuantity() => this.BookQuantity;
            

            public void DisplayBookDetails() {
                Console.WriteLine("Book ID: " + GetBookId());
                Console.WriteLine("Book Name: " + GetBookName());
                Console.WriteLine("Author Name: " + GetBookAuthorName());
                Console.WriteLine("Quantity: " + GetBookQuantity());
            }

            public class Member : Library {
                // Member properties

                private string MamberName;
                private decimal MemberPhoneNumber;

                // Setters
                public string SetMemberName(string MamberName) =>this.MamberName = MamberName;
                public decimal SetMemberPhoneNumber(decimal MemberPhoneNumber) => this.MemberPhoneNumber = MemberPhoneNumber;

                // Getters
                public int GetMemberId() => MemberId;
                public string GetMemberName()=> this.MamberName;
                public decimal GetMemeberPhoneNumber() => this.MemberPhoneNumber;

            }
        }
        
        public static void Main(String[]arg) {
            Book book = new Book();
            Member member = new Member();
            int i = 1;
            do{
                int choice;

                Console.WriteLine("\n*******************************"); 
                Console.WriteLine("*  Library Management System  *"); 
                Console.WriteLine("*-----------------------------*"); 
                Console.WriteLine("*  1. Add New Book            *");
                Console.WriteLine("*  2. Add New Member          *");
                Console.WriteLine("*  3. Borrow Book             *");
                Console.WriteLine("*  4. Return Book             *");
                Console.WriteLine("*  5. Display Total Books     *");
                Console.WriteLine("*  6. Exit                    *");
                Console.WriteLine("*******************************");
                Console.Write(" -> Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("-- Add New Book -- \n");
                        Console.Write("Enter Book Name: ");
                        string bookName = Console.ReadLine();
                        book.SetBookName(bookName);

                        Console.WriteLine("Enter a Book Auther Name : ");
                        string bookAuthorName = Console.ReadLine();

                        Console.WriteLine("Enter a Qty:");
                        int bookQuantity = int.Parse(Console.ReadLine());
                        book.SetBookQuantity(bookQuantity);
                        book.BookCount = bookQuantity;
                        Console.WriteLine("Book Added Successfully...!!!");
                        Console.WriteLine($"Book Id : {book.BookId} Book Name : {book.GetBookName()} Book Qty : {book.GetBookQuantity()}\n");

                        break;
                    case 2:
                        Console.WriteLine("-- Add New Member -- \n");

                        Console.WriteLine("Enter a Member Name :");
                        string memberName = Console.ReadLine();
                        member.SetMemberName(memberName);

                        Console.WriteLine("Enter a PhoneNumber :");
                        decimal memberphone = decimal.Parse(Console.ReadLine());
                        member.SetMemberPhoneNumber(memberphone);

                        Console.WriteLine(member.GetMemberName());
                        Console.WriteLine("Member Added Successfully...!!!");
                        Console.WriteLine($"Member Id : {member.MemberId} Member Name : {member.GetMemberName()} MemberPhoneNumber : {member.GetMemeberPhoneNumber()}\n");
                        break;

                    //Borrow Book 
                    case 3:
                           Console.WriteLine("-- Borrow Book --\n");
                        if (book.BookCount > 0)
                        {
                            Console.WriteLine("Enter Book Name do you borrow : ");
                            string bname = Console.ReadLine();

                            Console.WriteLine("Enter a User ID : ");
                           int mid  = int.Parse(Console.ReadLine());

                            if (book.GetBookName() == bname && member.MemberId == mid)
                            {
                                book.BookCount--;
                                Console.WriteLine($"Book {bname} borrowed successfully by Member ID: {mid}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid Book Name or Member ID.");
                            }
                        }
                        else 
                        {
                            Console.WriteLine("Books are not avilable in Library, try later...");
                        }
                           
                        break;
                    // return book
                    case 4:
                        Console.WriteLine("-- Return Book --");
                        int j;
                        for ( j = 1;j<=3;j++)
                        {
                            Console.WriteLine("Enter a UserId");
                            int userId = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter a Book Name : ");
                            string bookNameToReturn = Console.ReadLine();

                            if (book.GetBookName() == bookNameToReturn && member.MemberId == userId)
                            {
                                Console.WriteLine($"Book {bookNameToReturn} Return successfully by Member ID: {userId}");
                                book.BookCount++;
                                break;
                            }
                            else {
                                Console.WriteLine("Invalid Book Name or Member ID.");
                            }
                        }
                        
                        if (j>3) {
                            Console.WriteLine("You have entered wrong UserId or Book Name 3 times, try after a 1hr...");
                        }
                        break;
                    // Display Total Books
                    case 5:
                        Console.WriteLine("-- Display Total Books --");
                        Console.WriteLine($"Total Books available in Library: {book.BookCount}");
                        break;

                    case 6:
                        i = 0; // Exit the loop
                        Console.WriteLine("Exiting the System...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

            } while(i==1);

        }
    }
}
