using System;

namespace OOP_s_In_C_Sharp.ArrayinC_
{
    // Student class
    // / POCO class (Plain Old CLR Object)
    public class Students {
        
        public int Id { get; set; }
        public String Name { get; set; }
        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}";
        }

    }

    // Generic class
    // Type is a placeholder for the data type
    // What is Generic class?
    // Generic class is a class that can work with any data type
    // Generic class is a class that can be used to create a class, method, delegate, or interface
    public static class DisplayArrays<Type>
    {
        public static void Display(Type[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }

        public static Type[] UserInput(Type[] arr) {

           for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Element " + (i + 1));
                arr[i] = (Type)Convert.ChangeType(Console.ReadLine(), typeof(Type));
            }

            return arr;
        }
    }

    internal class GenericInC_
    {
        //// method overloading
        //public static void Display(double[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + ", ");
        //    }
        //}


        //public static void Display(int[] arr)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        Console.Write(arr[i] + ", ");
        //    }
        //}

        public static void Main(String[] arg)
        {
            Students[] students = new Students[5];

            students[0] = new Students() { Id = 44, Name = "Vaibhav" };
            students[1] = new Students() { Id = 45, Name = "Ankush" };
            students[2] = new Students() { Id = 46, Name = "Sanket" };
            students[3] = new Students() { Id = 47, Name = "Sagar" };
            students[4] = new Students() { Id = 48, Name = "Rohit" };

            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            double[] arr1 = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };

            


            //Display(arr);

            DisplayArrays<int>.Display(arr);

            Console.WriteLine("\n-----------------------------------");

            //Display(arr1);

           DisplayArrays<double>.Display(arr1);

            Console.WriteLine("\n-----------------------------------");

            string[] name = new string[5] ;

            string[] sArray= DisplayArrays<string>.UserInput(name);

            DisplayArrays<string>.Display(sArray);

        }
    }
}
