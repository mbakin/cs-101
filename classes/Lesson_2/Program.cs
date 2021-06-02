using System;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Workers-1====");
            Workers workers1 = new Workers("Micheal","Scott",123456,"Manager");
            workers1.workersInfo();
            Console.WriteLine("====Workers-2====");
            
            Workers workers2 = new Workers();
            workers2.Name = "Dwight";
            workers2.LastName = "Schrute";
            workers2.Id = 654321;
            workers2.Department = "Sales Manager";
            workers2.workersInfo();
        }
    }
    class Workers
    {
        public string Name ;
        public string LastName ;
        public int Id ;
        public string Department ;

        public Workers(string name, string lastName, int id, string department)
        {
            Name = name;
            LastName = lastName;
            Id = id;
            Department = department;
        }
        public Workers(){}
        public void workersInfo()
        {
            Console.WriteLine("Worker's Name : {0}" , Name);
            Console.WriteLine("Worker's Lastname : {0}" , LastName);
            Console.WriteLine("Worker's Id : {0}" , Id);
            Console.WriteLine("Worker's Department : {0}" , Department);
            
        }
    }
}
