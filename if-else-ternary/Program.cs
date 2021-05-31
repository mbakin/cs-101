using System;

namespace if_else_ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time >= 6 && time<11)
                Console.WriteLine("Good Morning!");
            else if(time <= 18)
                Console.WriteLine("Have a good days!");
            else
                Console.WriteLine("Good Night!");   
                Console.ReadLine();
            
            
            string result = time <=18 ? "Have a good days!" : "Good night!";
            result = time >= 6 && time<11 ? "Good Morning!" : time <=18 ? "Have good days." : "Have a good night" ;
            Console.WriteLine(result);
            
            
                
        }
    }
}
