using System;

namespace Inheritance
{
    public class Animals : Alive
    {
        protected void Adaptation()
        {
            Console.WriteLine("Animals have got a process of adaptation ");
            
        }
    }

    public class Reptiles : Animals 
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Eat();
        }
        public void Crawlers() // // Just for Reptiles
        {
            Console.WriteLine("They move by crawling");
        }
    }

    public class Bird : Animals 
    {
        public Bird()
        {
            base.Adaptation();
            base.Eat();
            base.Respiratory();
            
        }
        public void Flying()  // Just for Bird
        {
            Console.WriteLine("Birds can fly");
            
        }
    }
}