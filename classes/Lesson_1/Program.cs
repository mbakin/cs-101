using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // public, private, protected, internal
            
            Worker worker1 = new Worker(); // instance
            worker1.name = "Micheal";
            worker1.lastName = "Scott";
            worker1.id = 123456;
            worker1.department = "Manager";

            worker1.workerInfo();
        }
    }
    
    class Worker
    {
        public string name;
        public string lastName;
        public int id ;
        public string department { get; set; }
        
        public void workerInfo()
        {
            Console.WriteLine($"Worker's Name : {0}", name);
            Console.WriteLine($"Worker's Lastname : {0}", lastName);
            Console.WriteLine($"Worker's Id : {0}", id);
            Console.WriteLine($"Worker's Department : {0}", department);
        }
        
        
        
        
        
    }
}
