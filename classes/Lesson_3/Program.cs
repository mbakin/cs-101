using System;

namespace Lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Micheal";
            student.LastName ="Dwight";
            student.StudentId = 10;
            student.Department = "Math";

            student.studentInfo();
            student.descId();

            Student student1 = new Student("Dwight","Schrute",1,"Math");
            student1.descId();
            student1.descId();
            student1.studentInfo();

        }
        
    }
    class Student
    {
        private string name;
        private string lastName;
        private int studentId;
        private string department;

        public string Name 
        { 
            get => name;
            set => name = value;
        }
        public string LastName 
        { 
            get => lastName; 
            set => lastName = value;
        }
        public int StudentId 
        {   get => studentId;
            set 
            {
                if (value <= 1)
                {
                    Console.WriteLine($"Student id minimum value is 1");
                    studentId =1;
                }
                else
                {
                    studentId = value;
                }
            }
        }
        public string Department 
        {   
            get => department;
            set => department = value; 
        }

        public Student(string name, string lastName, int studentId, string department)
        {
            Name = name;
            LastName = lastName;
            StudentId = studentId;
            Department = department;
        }
        public Student(){}

        public void studentInfo()
        {
            Console.WriteLine("Student's Info");
            Console.WriteLine("Student Name : {0}" , this.Name);
            Console.WriteLine("Student Lastname : {0}" , this.LastName);
            Console.WriteLine("Student  Id : {0}" , this.StudentId);
            Console.WriteLine("Student Department : {0}" , this.Department);
        }
        public void ChangeId()
        {
            this.StudentId = this.StudentId + 1;
        }
        public void descId ()
        {
            this.StudentId = this.StudentId - 1;
        }
    }
}
