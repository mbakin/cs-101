using System;

namespace Lesson_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi coder!");
            Console.WriteLine("Please enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your surname : ");
            string surname = Console.ReadLine();
            
            Console.WriteLine("Hello " + name +" "+ surname + ". This is first console application.");
            Console.ReadLine();
            
            
        }
    }
}
