using System;

using System.Linq;


namespace OOP_s_In_C_Sharp.ArrayinC_
{

    internal class _2DArray
    {
        public static void UI(ref int[] arr) {

            for (int i = 0; i < arr.GetLength(0); i++) 
            {
                Console.WriteLine($"Enter a {i} Element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void Display(int[] arr) {

            foreach (var item in arr) {
                Console.WriteLine($"Items : {item}" );
            }
        
        }
        public static void Main(String[] arg)
        {
            // Call by Reference 
            int[] array = new int[4];
            UI(ref array);

            Display(array);
            

            //int[,] Arr =new int[3, 2];

           
        }
    
    }
}
