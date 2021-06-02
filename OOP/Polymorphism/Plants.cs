using System;

namespace Inheritance
{
    public class Plants : Alive
    {
        protected void Photosynthesis() // Common feature
        {
            Console.WriteLine("Plants do photosynthesis");
            
        }
        public override void Reaction()
        {
            base.Reaction();
            Console.WriteLine("Plants respond to the sun");
            
        }
    }

    public class SeedPlants  : Plants
    {
        public SeedPlants()
        {
            base.Photosynthesis();
            base.Eat();
            base.Urinary();
            base.Reaction();
        }
        public void Germination()  // Just for SeedPlants
        {
            Console.WriteLine("Germinated!");
            
        }
    }
    public class SeedlessPlants  : Plants
    {
        public SeedlessPlants()
        {
            base.Photosynthesis();
        }
        public void Reproduction()  // // Just for SeedlessPlants
        {
            Console.WriteLine("Finally!");
            
        }
    }
}