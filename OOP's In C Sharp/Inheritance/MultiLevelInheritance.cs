using System;


namespace OOP_s_In_C_Sharp.Inheritance
{
    // Multi-level inheritance is a type of inheritance in which a class (child class) inherits from another child class,
    // forming a chain of inheritance. In this case, ClassCC inherits from ClassBB, which in turn inherits from ClassAA.
    public class ClassAA // Grand Perent Class inheritance 
    {
        public void Method1()
        {
            Console.WriteLine("Method A from ClassA");
        }
    }
    class ClassBB : ClassAA // Parent Class inheritance  
                            // class ClassBB contains the method Method2 and Method1 from ClassAA
    {
        public void Method2()
        {
            Console.WriteLine("Method B from ClassB");
        }
    }

    class ClassCC : ClassBB // Child Class inheritance
                            // class ClassCC contains the method Method3, Method2 and Method1 from ClassAA
    {
        public void Method3()
        {
            Console.WriteLine("Method C from ClassC");
        }
    }
    internal class MultiLevelInheritance
    {
       public static void Main(string[] args)
        {
            // Creating an instance of ClassCC
            ClassCC obj = new ClassCC();
            // Calling methods from ClassCC, ClassBB, and ClassAA
            obj.Method1(); // Output: Method A from ClassA
            obj.Method2(); // Output: Method B from ClassB
            obj.Method3(); // Output: Method C from ClassC
        }

    }
}
