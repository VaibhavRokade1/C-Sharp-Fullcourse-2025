using System;

namespace OOP_s_In_C_Sharp.Inheritance
{
    public class ClassA1 {
        
       public  ClassA1() {
            Console.WriteLine("Constructor of Class A");
        }
        public void MethodA() {
            Console.WriteLine("Method from Class A");
        }
    }

    public class ClassB1 : ClassA1
    {
        public ClassB1() 
        {
            Console.WriteLine("Constructor of Class B");
        }

        public void MethodB() 
        {
            Console.WriteLine("Method from Class B");
        }
        
    }


    public class ClassC1 : ClassA1 //, ClassB1 // This will cause a compile-time error because C# does not support multiple inheritance
    {
        ClassC1() 
        {

            Console.WriteLine("Constructor of Class C");
        }
        public void MethodC() 
        {
            Console.WriteLine("Method from Class C");
        }
    }

    internal class MultipleInheritance
    {
        public static void Main(string[] args)
        {
           ClassB1 a = new ClassB1(); // Create an instance of ClassB  

            a.MethodB(); // Call method from ClassB
        }

    }
}
