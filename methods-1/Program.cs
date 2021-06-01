using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b =1;
            Console.WriteLine(a+b);

            int result = sumOfNum(a,b);
            Console.WriteLine(result);  
            
            Methods methods = new Methods(); 
            methods.showResult(Convert.ToString(result));
            int result2 = methods.increaseOf(ref a,ref b);
        }

        static int sumOfNum(int val1, int val2)
        {
            return (val1+val2);
        }
    }
    class Methods
    {
        public void showResult(string data1)
        {
            Console.WriteLine(data1);
            
        }
        public int increaseOf(ref int val1, ref int val2)
        {
            val1+=1;
            val2+=1;
            return val1 + val2;
        }
    }

    
}
