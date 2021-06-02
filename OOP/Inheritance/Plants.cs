using System;

namespace Inheritance
{
    public class Plants : Alive
    {
        protected void Photosynthesis() // Common feature
        {
            Console.WriteLine("Plants do photosynthesis");
            
        }
    }

    public class SeedPlants  : Plants
    {
        public SeedPlants()
        {
            base.Photosynthesis();
            base.Eat();
            base.Urinary();
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