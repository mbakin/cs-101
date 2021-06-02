using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count workers : {0}", Worker.CountWorker);
            Worker worker = new Worker("Dwight", "Schrute","Sales Manager");
            Console.WriteLine("Count workers : {0}", Worker.CountWorker);
            

            Console.WriteLine("Results of sum : {0}", Maths.Sum(1,100));
            Console.WriteLine("Results of multiply : {0}", Maths.Multiply(1,100));
            
            
        }
    }

    class Worker
    {
        private static int countWorker;

    public static int CountWorker { get => countWorker; }

    private string Name;
    private string Lastname;
    private string Department;

    static Worker()
    {
        countWorker = 0;
    }

    public Worker(string name, string lastname, string department)
    {
        this.Name = name;
        this.Lastname = lastname;
        this.Department = department;
        countWorker ++;
    }
  }
    static class Maths
    {
        public static long Sum (int num1, int num2)
        {
            return num1 + num2;
        }
        public static long Multiply (int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
