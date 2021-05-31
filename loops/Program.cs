using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number : ");
            int value =int.Parse(Console.ReadLine());

            for (int i = 1; i <= value; i++)
            {
                if (i %2 == 1)
                   Console.WriteLine(i);
            }

            // Odd Numbers
            int oddSum = 0, evenSum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if( i %2 ==1)
                   oddSum = oddSum + i; //oddSum += i ;
                else
                   evenSum = evenSum + i;    // evenSum += i;

            }
            Console.WriteLine("Sum of odd numbers : " + oddSum);
            Console.WriteLine("Sum of even numbers : " + evenSum);
            
            // If we use break in the loop:          
            for (int i = 1; i < 10; i++)
            {
                if( i == 4)
                    break;
                    Console.WriteLine( i ) ; 
            }
            // Output : 1,2,3


            // If we use continue in the loop:
            for (int i = 1; i < 10; i++)
            {
                if( i == 4)
                    continue;
                    Console.WriteLine( i ) ; 
            }
            // Output : 1,2,3,5,6,7,8,9 ( i = 4 is skipping)

            // While Loops
            Console.WriteLine("Please enter a number : ");
            int number = int.Parse(Console.ReadLine());
            int counter1 = 1,sum = 0;
            while (counter1 <= number)
            {
                sum += counter1;
                counter1 ++ ;
            }
            Console.WriteLine("Average result : " + sum/number);

            // Alphabet on A-Z
             char character = 'a';
             while (character <= 'z')
             {
                 Console.Write(character);
                 character ++;
             }

            
            // foreach loops
             string[] cars = {"Audi","Bmw","Ford","Gmc"};
             foreach (var car in cars)
             {
                 Console.WriteLine(car);
             }

            Console.ReadKey();
        }
    }
}
