using OOPsInCSharp.File_Handling;
using System;
using System.Collections.Generic;
using System.IO;

namespace OOPsInCSharp.File_Handling
{
    public class FileClass
    {
        string  FilePath = $"";
       
        public void CreateFile(string fileName) {

            FilePath = $"D:\\{fileName}";
            File.Create(FilePath);

            if (File.Exists(FilePath))
            {
                Console.WriteLine("File Created Successfully...!!!");
            }
            else {
                Console.WriteLine("Unable to Create File...!!!");
            }
        }

        public void DeleteFile(string filename) 
        {

            FilePath = $"D:\\{filename}";
            
            File.Delete(FilePath);

            if (!File.Exists(FilePath))
            {
               Console.WriteLine("File Delete Successfully...");
            }
            else 
            {
               Console.WriteLine("Unable to Delete...");
            }
                
    
        }
        
    }
}


//FileClass fileClass = new FileClass();

//int choice = 0;

//while (true)
//{
//    Console.WriteLine("1.Create new file ( demo.txt ) : ");
//    Console.WriteLine("2.Delete file : ");

//    choice = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            Console.WriteLine("Enter a File Name : ");
//            string fileName1 = Console.ReadLine();
//            fileClass.CreateFile(fileName1);
//            break;
//        case 2:
//            Console.WriteLine("Enter a Name Witch you want to delete ( Demo.txt ) : ");
//            string fileName2 = Console.ReadLine();
//            fileClass.DeleteFile(fileName2);
//            break;
//    }
//}