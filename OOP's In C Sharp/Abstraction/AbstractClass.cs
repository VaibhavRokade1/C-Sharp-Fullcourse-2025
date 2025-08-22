using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsInCSharp.Abstraction
{
    //we can write abstraction in 2 way in using abstract class and Interface    

    // Abstract class containts normal methods and abstract methods
    // Abstract class declear with abstract keyword
    public abstract class AbstractClass
    {
        public abstract int GetCube(int a);

        public void Show() {
            Console.WriteLine("This is normal method in abstract class.");
        }
    }
}
