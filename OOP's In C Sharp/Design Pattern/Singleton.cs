//using OOP_s_In_C_Sharp.Polymorephism;
//using System;
//using System.CodeDom;
//using System.Data;
//namespace OOP_s_In_C_Sharp
//{

//    public class Program {

//        public class MySingleton 
//        {

//            public static MySingleton instance =  null;
//            private MySingleton() { } // constructor private kelya mule constructor ha class chya baher access honar nahi 

//            public static MySingleton GetObj() {

//                if (instance == null) //  instance == null jar asel tar 1 new object create karun return karto
//                {
//                    Console.WriteLine("New Object is Loadding...");

//                    return instance = new MySingleton();
//                }
//                else { // and instance == null nasel tar jo pahilyanda object create kelela aahe toch object retunce karto new create karat nahi
//                    Console.WriteLine("Previous Object is Loadding...");
//                    return instance;
//                }

//            }
//            public void Add(int a , int b) {
//                Console.WriteLine($"Addition is : {a+b}");
//            }
            
//        }
//        public static void Main(String[] args) 
//        {
//            MySingleton mySingleton1 = MySingleton.GetObj();

//            mySingleton1.Add(10 , 20);

//            MySingleton mySingleton2 = MySingleton.GetObj();

//            mySingleton2.Add(20 , 40);

//        }
    
//    }
//}
