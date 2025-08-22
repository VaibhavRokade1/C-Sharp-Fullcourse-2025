using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s_In_C_Sharp.ArrayinC_
{
    public class  Functions {

        public static void Display(string[] arr)
        {
            // Display the array elements
            Console.Write("Array Element are : {");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            Console.WriteLine("}");
        }
    }
    internal class ArrayDeclearation
    {
        public static void Main(String[] arg)
        {
            //1. Array Creation
            //int[] arr = new int[5];

            // accepting array elements from user
            //for (int i = 0; i < arr.Length; i++) {
            //    Console.WriteLine("Enter Element " + (i + 1));
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //2. Array Creation with Initialization
            //decimal[] arr = new decimal[] { 1.1m, 2.2m, 3.3m, 4.4m, 5.5m };

            //3. Array Creation with Implicit Initialization
            //int[] arr = { 10, 20, 30, 40, 50 };

            //4. Array Creation first an then initialization
            //int[] arr; // Declaration
            //arr = new int[] { 100, 200, 300, 400, 500 }; // Creation and Initialization

            // Display the array elements
            //Console.Write("{");
            //for (int i = 0; i < arr.Length; i++) {
            //    Console.Write(arr[i] + ", ");
            //}
            //Console.WriteLine("}");
        }

            //int[] arr = new int[5];
            //arr[0] = 10;
            //arr[1] = 20;
            //arr[2] = 30;
            //arr[3] = 40;
            //arr[4] = 50;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}



    }
}
