using System;


namespace OOP_s_In_C_Sharp
{
    internal class BaseKeyword
    {
        public class ClassA1
        {

            public ClassA1()
            {
                Console.WriteLine("Constructor of Class A");
            }

            public ClassA1(int num)
            {
                Console.WriteLine("Constructor of Class A " + num);
            }
            public ClassA1(String str) : this(54236) // Calling the default constructor of the same class
            {
                //this(); // Calling the default constructor of the same class
                Console.WriteLine($"Hey, {str}");
            }
            public void MethodA()
            {
                Console.WriteLine("Method from Class A");
                // Removed 'this();' as it is invalid syntax in C#.
                // If you want to call a constructor, you cannot do so from a method.
                // If you want to call another method, use 'this.MethodName();'
            }
        }

        public class ClassB1 : ClassA1
        {
            //public ClassB1() : base() // base class Constructor Calling...
            //{
            //    Console.WriteLine("Constructor of Class B");

            //}
            public ClassB1()
            {
                Console.WriteLine("Constructor of Class B");
       
            }

            public ClassB1(String str)
            {
                
                // this(); // in C# you not current class constructor using this keyword
                // base(str); // base class Constructor
                Console.WriteLine($"Hey, {str}");
            }
            

            public void MethodB()
            {
                base.MethodA(); // Calling method from base class
                Console.WriteLine("Method from Class B");
            }
            

        }

        //{
        //    ClassB1 b1 = new ClassB1("Hi Constructor...");

        //    ClassA1 a1 = new ClassA1();
        //    Console.WriteLine("Main Method Called...");
        //    b1.MethodB(); // Call method from ClassB

            

        //}
     
    }

}
