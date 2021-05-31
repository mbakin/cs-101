using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int value ;
            // value = 1;
            // string n = null;
            // string N = null ; // Case Senstiviy is important n !=== N
            // string 1first = null ; //  variables can't start be number.
            // string Class = ""; // variables can't get a special name. Class, Object etc.
            // string foo + data= null; // variables can't get a operators for define.
            
            // ========================
            
            // Numbers
            // byte b = 6;    // 1 byte 
            // sbyte sb = 10; // 1 byte 
            // short s = 5;   // 2 byte  
            // ushort us = 5; // 2 byte
            // Int16 i16 = 2; // 2 byte
            // int i = 2 ;    // 4 byte
            // Int32 i32 = 2; // 4 byte
            // Int64 i64 = 2; // 8 byte
            // uint ui =2;    // 4 byte
            // long l = 2;    // 8 byte
            // ulong ul = 2;  // 8 byte
            // float f = 2 ;  // 4 byte
            // double d =5 ;  // 8 byte
            // decimal dc=2.1;// 16 byte
            
            //==========================
            
            // Strings
            // char ch ='2';           // 2 byte
            // string str = "abcdef"   // unlimited
            // bool bl = false;
            // DateTime dt = DateTime.Now; // for date & time
            // object obj = "x";
            // object obj2 = 'y';
            // object obj3 = 3;
            // object obj4 = 3.9;
            
            // ========================
            
            // String Expressions
            string str = string.Empty;
            str = "Hello coder!";
            string firstName = "Tim";
            string lastName = "Cook";
            string fullName = firstName + " " + lastName;
            
            // =========================
            
            // Integer Expressions
            int integer1 = 5;
            int integer2 = 1;
            int integer3 = integer1*integer2;

            // =========================

            // Boolean 
            //bool t1est = 10<2;     // False 
            //bool t2est = 2< 10;   // True 

            // =========================

            //Variables Conversions ToString / ToInt32
            string str11 = "11";
            int integer11 = 111;
            
            string newValue = str11 + integer11.ToString();
            Console.WriteLine(newValue);  //  Output: 11111
            
            int integer22 = integer11 + Convert.ToInt32(str11);
            Console.WriteLine(integer22); // Output 122;

            integer22 = integer11 + int.Parse(str11);
            Console.WriteLine(integer22);  // Output 122
            Console.ReadLine();

            // String Datetime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);
            Console.ReadLine();     // Output: 29.05.2021
            

        }
    }
}
