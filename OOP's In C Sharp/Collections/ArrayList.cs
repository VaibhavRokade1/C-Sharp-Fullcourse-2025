using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp.Collections
{
    public class ArrayListcl
    {
        public static void ArrayListClass (){
            ArrayList arr = new ArrayList();

            //Console.WriteLine(arr.Capacity); 

           //byte default capacity is increace by 4 or after that duable the size  4 -> 8 -> 16 -> 32
            //Console.WriteLine(arr.Capacity);
            //Console.WriteLine(arr.Capacity);

            arr.Add(100);
            arr.Add(200);
            arr.Add(300);
            arr.Add(400);
            arr.Add(500);

            
            Console.WriteLine("--------- Array value ------------");
            foreach (object obj in arr) {
                Console.WriteLine(obj);
            }
            // remove by actual value or object 
            arr.Remove(300);

            // remove by index 
            arr.RemoveAt(1);


            // insert in between 
            //arr.Insert(7,303030);

            //IndexOutOfRangeException occur here....


            Console.WriteLine("--------- Array value ------------");
            foreach (object obj in arr)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
