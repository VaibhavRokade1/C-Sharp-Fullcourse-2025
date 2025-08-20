using System;
using System.Text;

namespace OOP_s_In_C_Sharp
{
    public class String_StringBuilder
    {
        public void StringBuilding()
        {
            // strings is immuteable 
            // every concatination time string realice the old memory values and create new memory for the new values 
            // strings 
            string str = "Hey Vaibhav";

            str += ", how are you ?";
            str += "Hmmmm";

            Console.WriteLine(str.Replace("Hmmmm", "replace")); // replace the old sub string to new str

            Console.WriteLine(str.Trim()); // trim method can remove the startig and ending white space

            Console.WriteLine(str.Length); // length method return length of the string 

            Console.WriteLine(str.ToLower());// this method convert my string charactors in the lower case 

            // String builder 

            StringBuilder textBuilder = new StringBuilder();

            textBuilder.Append("Hi Vaibhav Rokade"); // concat string data using append method 
            textBuilder.Append("what are you doing....? "); 

            Console.WriteLine(textBuilder);

            // stringbuilder is use to create mutable string 

    }
        //    public static void Main(string[] args)
        //{
        //    String_StringBuilder demo = new String_StringBuilder();
        //    demo.StringBuilding();
        //}
    }
}
