﻿using System;

namespace dateTimeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddMinutes(45));

            //DateTime format
            Console.WriteLine(DateTime.Now.ToString("dd"));//1
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Tue
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Tuesday 

            Console.WriteLine(DateTime.Now.ToString("MM"));//06
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Jun
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//June

            Console.WriteLine(DateTime.Now.ToString("yy"));//21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2021

            //math kütüphanesi
            Console.WriteLine(Math.Abs(-4)); // 4
            Console.WriteLine(Math.Sin(10)); // -0,544211110889
            Console.WriteLine(Math.Cos(25)); // 0,991202811863
            Console.WriteLine(Math.Tan(45)); // 1,6197751905438

            
            Console.WriteLine(Math.Ceiling(15.6)); 
            Console.WriteLine(Math.Round(15.6)); 
            Console.WriteLine(Math.Floor(15.6)); 
            
            Console.WriteLine(Math.Max(4,6));
            Console.WriteLine(Math.Min(4,6));

            Console.WriteLine(Math.Pow(3,4));
            Console.WriteLine(Math.Sqrt(16)); 
            Console.WriteLine(Math.Log(10)); 
            Console.WriteLine(Math.Exp(3)); 
            Console.WriteLine(Math.Log10(10)); 
        }
    }
}
