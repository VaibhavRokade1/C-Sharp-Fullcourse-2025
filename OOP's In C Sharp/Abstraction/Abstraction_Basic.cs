using System;


namespace OOP_s_In_C_Sharp.Abstraction
{
    //Abstraction in Sharp

    // it is a process of hiding a implementation details and showing a only neccessry information to the user

    // Abstract class or methods is basicly in in-complate methods
    // 

    abstract class Instrument {
        abstract public void Play();
    }

    // Concrete class that implements the abstract method

     class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Guitar ");
        }
    }

    internal class Abstraction_Basic
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
