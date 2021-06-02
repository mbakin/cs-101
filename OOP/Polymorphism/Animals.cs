using System;

namespace Inheritance
{
    public class Animals : Alive
    {
        public void Adaptation()
        {
            Console.WriteLine("Animals have got a process of adaptation ");
            
        }
        public override void Reaction()
        {
            base.Reaction();
            Console.WriteLine("Animals have got reaction");
            
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
            base.Reaction();
            
            
        }
        public void Flying()  // Just for Bird
        {
            Console.WriteLine("Birds can fly");
            
        }
    }
}