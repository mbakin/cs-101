using System;

namespace Inheritance
{
    public class Alive
    {
        protected void Eat()
        {
            Console.WriteLine("Alive things eating");
            
        }
        protected void Respiratory()
        {
            Console.WriteLine("Alive things breathe");
        }
        protected void Urinary()
        {
            Console.WriteLine("Alive things urinary");
        }
    }
}