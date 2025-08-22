using System;
namespace OOPsInCSharp.Polymorephism.Questions
{
    public class Shape 
    {
        public virtual void Draw()
        {
            Console.WriteLine("Hi i am Drowing Class.");
        }
    }
    public class Circle : Shape 
    {
        public override void Draw()
        {
            Console.WriteLine("This is Circle Class.");
        }
    }

    public class Ractangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is Ractangle Class.");            
        }
    }
    
    public class OverridingQustion1
    {
        public static void Main(String []args)
        {
            Shape circle = new Circle();
            circle.Draw();
        }

    }
}
