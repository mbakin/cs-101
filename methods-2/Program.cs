using System;

namespace methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parameters
            string num = "999";
            bool result = int.TryParse(num, out int outNum);
            if (result)
            {
                Console.WriteLine("Success");
                Console.WriteLine(outNum);
            }
            else
            {
                Console.WriteLine("Fail!");
            }

            Methods methods = new Methods();
            methods.results(2,3, out int result1);
            Console.WriteLine(result1);
            
            // Methods Overloading
            int foo = 1111111;
            methods.showResult(Convert.ToString(foo));
            methods.showResult(foo); // Overloading
            Console.WriteLine();
            
        }
    }
    class Methods
    {
        public void results(int a,int b, out int sumResults)
        {
            sumResults = a + b;
        }

        public void showResult (string data)
        {
            Console.WriteLine(data);
            
        }
        public void showResult (int data)
        {
            Console.WriteLine(data);
            
        }
    }

}
