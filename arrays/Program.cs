using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7]; 

            string[] animals = { "forg", "bird", "dog", "cat" };

            int[] x;
            x = new int[6];

            

            days[0] = "Sunday"; // Array's firt index of value 0
            Console.WriteLine(animals[1]); // Output: bird
            x[3] = 10;
            Console.WriteLine(x[3]);
            Console.WriteLine(days[0]);


            // Example1
            // int[] numArr = new int[20];
            // int sum = 0;
            // for (int i = 0; i < numArr.Length; i++)
            // {
            //     Console.Write("Please {0}. enter a number :", i + 1);
            //     numArr[i] = Convert.ToInt32(Console.ReadLine());
            //     sum += numArr[i];
            // }
            // double avrg = sum / 20;
            // Console.WriteLine("Avarage of number :  " + avrg);
            // Console.ReadLine();
            // Example2
            // Console.WriteLine("How many array elements do you want : ");
            // int arrayLength = int.Parse(Console.ReadLine());
            // int[] arrayNumber = new int[arrayLength];

            // for (int i = 0; i < arrayLength; i++)
            // {
            //     Console.WriteLine("Please {0}. enter a number : ", i + 1);
            //     arrayNumber[i] = int.Parse(Console.ReadLine());
            // }

            // int sum = 0;
            // foreach (var num in arrayNumber)
            //     sum += num;
            // Console.WriteLine("Avarage :" + sum / arrayLength);

            // sort
            int[] num_arr = {23,12,4,86,72,3,11,17};
            foreach (var num1 in num_arr)
                Console.WriteLine(num1);
            
            Array.Sort(num_arr);

            foreach (var num1 in num_arr)
                Console.WriteLine(num1);

            // Clear
            Array.Clear(num_arr,2,2);
            foreach (var num1 in num_arr)
                Console.WriteLine(num1);
            // Array Reverse
            Array.Reverse(num_arr,2,2);
            foreach (var num1 in num_arr)
                Console.WriteLine(num1);

            // Array IndexOf
            Console.WriteLine(Array.IndexOf(num_arr,3));

            Console.ReadKey();
        }
    }
}
