using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csharp
{

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //to string method
        public override string ToString()
        {
            return $"Student[Id: {Id}, Name: {Name}, Age: {Age}]";
        }

    }

    public static class Display<T>
    {
        public static void Show(T[] obs)
        {
            Console.Write("Array {");
            foreach (var ele in obs)
            {
                Console.WriteLine(ele + " ");
            }
            Console.WriteLine("}");
        }
        public static T[] Sort(T[] obs)
        {
            obs = obs.OrderBy(x => x).ToArray();
            return obs;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Student[] studs = new Student[5];
            //here create 5 object of STudent
            studs[0] = new Student() { Id = 1, Name = "Anil", Age = 23 };
            studs[2] = new Student() { Id = 2, Name = "Sunil", Age = 24 };
            studs[4] = new Student() { Id = 3, Name = "Kiran", Age = 27 };
            studs[1] = new Student() { Id = 4, Name = "Ravi", Age = 21 };
            studs[3] = new Student() { Id = 5, Name = "Suresh", Age = 22 };

            Student[] idWiseSort = studs.OrderBy(ob => ob.Id).ToArray();
            Display<Student>.Show(idWiseSort);
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Student[] nameWiseSort = studs.OrderBy(ob => ob.Name).ToArray();
            Display<Student>.Show(nameWiseSort);
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            Student[] ageWiseSort = studs.OrderBy(ob => ob.Age).ToArray();
            Display<Student>.Show(ageWiseSort);
            Console.WriteLine("+++++++++++++++++++++++++++++++");
            //  Display<Student>.Show(studs);

            /*  foreach(Student ob in studs)
              {
                  Console.WriteLine(ob);
              }
  */


        }
    }
}