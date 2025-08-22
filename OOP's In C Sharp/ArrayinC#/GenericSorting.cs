using System;
using System.Linq;


namespace OOP_s_In_C_Sharp.ArrayinC_
{
    public static class Display<T>
    {
        public static void ShowRecourds(T[] arr) {
            Console.WriteLine("All Students Recourds : {");
            foreach  (T item in arr) {
                Console.WriteLine(item + " , ");
            }
            Console.WriteLine("}");
        }
    }
    public class MyStudent { 
        public int Id { get; set; }
         public string Name { get; set; }
        public int Age { get; set; }
        //to string method is mendratory other wise filename well be print a place of object 

        //public override string ToString()
        //{
        //    return $"[ Id : {this.Id} , Name : {this.Name} , Age : {this.Age} ]";
        //}
    }

    
    internal class GenericSorting
    {
        public static void Main()
        {
            MyStudent[] stdnts = new MyStudent[5];

            stdnts[0] = new MyStudent() {Id = 1, Name = "Vaibhav Rokade" , Age = 23};
            stdnts[1] = new MyStudent() { Id = 3, Name = "Anil Rokade", Age = 24 };
            stdnts[2] = new MyStudent() { Id = 5, Name = "Sunil Rokade", Age = 25 };
            stdnts[3] = new MyStudent() { Id = 2, Name = "Kiran Rokade", Age = 26 };
            stdnts[4] = new MyStudent() { Id = 4, Name = "Ravi Rokade", Age = 27 };

            MyStudent[] SortedStudents =  stdnts.OrderBy(obj => obj.Id).ToArray();

            Display<MyStudent>.ShowRecourds(SortedStudents);

        }       
    }
}
