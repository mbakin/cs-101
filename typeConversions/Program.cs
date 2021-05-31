using System;

namespace typeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
                byte a = 5;
                sbyte b = 30;
                short c = 10;

                int d = a + b + c ;
                Console.WriteLine("d :" + d );

                long h = d;
                Console.WriteLine("h:" + h );

                float i = h;
                Console.WriteLine("i:" + i);

                string s = "bill" ;
                char f   =    'c' ; // 'c' is char but ' c ' is string. Because one space is one character. Also char has got one character.
                object g = s + f;
                Console.WriteLine("g: " + g);

        // Explicit Conversion
                
                int x = 4 ;
                // byte y = x ; ERORR!
                byte y = (byte)x ;
                Console.WriteLine("y : " + y);

                int z = 100 ;
                byte t = (byte)z;
                Console.WriteLine("t : " + t );

                float w = 10.3f;
                byte v = (byte)w;
                Console.WriteLine("v : " + v );


        // ToString Method

                int a1 = 6;
                string b1 = a1.ToString();
                Console.WriteLine("yy:" + b1 );

                string c1 = 12.5f.ToString();
                Console.WriteLine("zz:" + c1 );

        // System.Convert Class 
                
                string t1 = "10", t2 = "20";
                int num1, num2, result;

                num1 = Convert.ToInt32(t1);
                num2 = Convert.ToInt32(t2);

                result = num1 + num2 ;
                Console.WriteLine("Result : " + result);

        // Parse Method
            
                ParseMethod(); 
                Console.ReadKey();
        }

        public static void ParseMethod()
        {
            string str1 = "15";
            int number1 ;
            number1 = Int32.Parse(str1);
            Console.WriteLine("number1 : " + number1);

            string str2 = "10,25";
            double double1;
            double1 = Double.Parse(str2);
            Console.WriteLine("Double1 : " + double1);

        }
    }
}
