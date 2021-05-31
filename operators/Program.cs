using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // This project for operators in C#  
            
            int x = 3;
            int y = 3;
            y = y + 2;   // this line same y += 2 ;
            Console.WriteLine(y);
            y /= 1 ;
            x += 5 ;
            Console.WriteLine("X :" + x + " " +  "Y :" + y);
            Console.WriteLine(x + y);

            //Logic Operators || : OR, && : AND , ! : NOT

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)     // If :  true && false = false 
                Console.WriteLine("Congratulations!");
            //Output : This code will be run but does not produce results

            if (isSuccess || isCompleted)  // If :  true || false = true 
                Console.WriteLine("Cool!");
            //Output : Cool !

            if (isSuccess && !isCompleted)  //If : true && true = true 
                Console.WriteLine("Success!");
            //Output : Success!
            
            // < ,> , <= , >= , == , != :not equal

            int number1 = 1 ;
            int number2 = 2 ;

            bool foo = number1 < number2 ;
            Console.WriteLine(foo);
            //Output : true

            foo = number1 > number2 ;
            Console.WriteLine(foo);
            //Output : false

            foo = number1 <= number2 ;
            Console.WriteLine(foo);
            //Output : true

            foo = number1 >= number2 ;
            Console.WriteLine(foo);
            //Output : true

            foo = number1 == number2 ;
            Console.WriteLine(foo);
            //Output : false

            foo = number1 != number2 ;
            Console.WriteLine(foo);
            //Output : true
            
            
            //  / , * , + , - , % :(mode)
            int num1 = 25;
            int num2 = 5;
            int result1 = num1/num2;
            Console.WriteLine(result1);
            //Output : 25/5 = 5

            result1 = num1 + num2;
            Console.WriteLine(result1);
            //Output : 25 + 5 = 30

            result1 = num1 - num2;
            Console.WriteLine(result1);
            //Output : 25-5 = 20

            result1 = num1 * num2;
            Console.WriteLine(result1);
            //Output : 25*5 = 125

            result1 = num1 % num2;
            Console.WriteLine(result1);
            //Output : 25 / 5 = 0 mode is 0 

            result1 = num1++;
            Console.WriteLine(result1); 
            //Output : 25
        }
    }
}
