using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_s_In_C_Sharp.ArrayinC_
{
    internal class _2DArrayinCSharp
    {
        public static void Main() 
        {
            //2D Array structure (3 x 3)
            //[
            //[1,3,4],
            //[4,6,6],
            //[8,9,2]                
            //]
            // 2D Array Declearation
            int[,] arr = new int[3,3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"Elements for Row {i+1}");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"value [{i},{j}] :");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("[");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j < i)
                    {
                        Console.Write($"   , ");
                    }
                    else {
                        Console.Write($" {arr[i, j]} , ");
                    }
                }
                Console.WriteLine("]");
            }

        }
    }
}
