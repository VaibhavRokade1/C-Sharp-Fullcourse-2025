using System;

namespace OOP_s_In_C_Sharp
{
    class ClassA {

       public virtual void Parent()
        {
            Console.WriteLine("This is parent Methods");
        }

    }
    class ClassB : ClassA { 
     public override void Parent()
        {
            Console.WriteLine(" This is child Methods But, Override from parent.");
        }
    }
    internal class Upcasting
    {
        public static void Main(String[]arg)
        {
            // 1. we can hold parent class object in a parent class refernce.
           ClassA cobj = new ClassA();
            cobj.Parent(); // Output : This is parent Methods.

            // 2. we can hold child class object in a parent class refernce.
            ClassA a = new ClassB();
            a.Parent(); // Output :  This is child Methods But, Override from parent.

            // 3. we can hold child class object in a child class refernce.
            ClassB b = new ClassB();
            b.Parent();
            // Output :  This is child Methods But, Override from parent.


            // Note: 4. we can not hold parent class object in a child class refernce.

        }
    }
}
