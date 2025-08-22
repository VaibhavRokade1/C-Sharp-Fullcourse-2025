using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s_In_C_Sharp.ArrayinC_
{
   
    // what is Array 
    // Array is a collection of items of the same type
    // Array is a reference type
    //// Array is a fixed size collection
    //// Array is a zero-based index collection
    //// Array is a collection of items that can be accessed by index
    //multiple values of the same type store in single variable and compiler seperated by using index
    //multiple ways to creation of array 
    //Genenic class 


    class DisplayArray<T>
    {
        public static void Display(T[] arr)
        {
            // Display the array elements
            Console.Write("Array Element are : {");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("}");
        }

        public static T[] UI(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Element " + (i + 1));
                arr[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }
            return arr;
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}";
        }
    }
    public class Demo
    {

        /* public static void Display(string[] arr)
         {
             // Display the array elements
             Console.Write("Array Element are : {");
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.Write(arr[i] + ", ");
             }
             Console.WriteLine("}");
         }
         public static void Display(double[] arr)
         {
             // Display the array elements
             Console.Write("Array Element are : {");
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.Write(arr[i] + " ,");
             }
             Console.WriteLine("}");
         }
         public static void Display(Student[] arr)
         {
             // Display the array elements
             Console.Write("Array Element are : {");
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.Write(arr[i] + ", ");
             }
             Console.WriteLine("}");
         }
         public static void Display(int[] arr)
         {
             // Display the array elements
             Console.Write("Array Element are : {");
             for (int i = 0; i < arr.Length; i++)
             {
                 Console.Write(arr[i] + ", ");
             }
             Console.WriteLine("}");
         }
        */
        public static int[] UI(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter Element " + (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        public static void Task()
        {
            // Array declaration and Creation 
            //int[] arr = new int[4];
            // Array declaration and Creation with initialization
            //int[] arr = new int[] { 1, 2, 3, 4, 5 ,6};
            // Array declaration and Creation with initialization and without new keyword
            /* int[] arr1;
                 arr1= new int[]{ 1, 2, 3, 4, 5 };
             int[] a, b;*/

            //create 4 objects 
            Student[] studs = new Student[4];
            studs[0] = new Student { Id = 1, Name = "Vaibhav" };
            studs[1] = new Student { Id = 2, Name = "Amit" };
            studs[2] = new Student { Id = 3, Name = "Ravi" };
            studs[3] = new Student { Id = 4, Name = "Aditya" };
            DisplayArray<Student>.Display(studs);
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            int[] arr1;
            arr1 = new int[3];
            int[] arr = new int[4];
            double[] radius = { 1.2, 2.3, 3.4, 4.5, 5.6 };
            DisplayArray<double>.Display(radius);
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            string[] name = { "Amit", "Ravi", "Suresh", "Rajesh" };
            DisplayArray<string>.Display(name);
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            /*   
               arr= UI(arr);
               arr1 = UI(arr1);
                //array Display 
               Display(arr);
                Display(arr1);*/


        }
    }




}
