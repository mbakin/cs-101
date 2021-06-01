using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            // list.Add("Ayşe");
            // list.Add(2);
            // list.Add(true);
            // list.Add('T');
            // Console.WriteLine(list[1]);
            // foreach (var item in list)
            //     Console.WriteLine(item);

            //AddRange 
            //string[] colors = {"red", "blue" ,"black","yellow"};
            List<int> numbers = new List<int>(){1,5,10,15,25,45};

            //list.AddRange(colors);
            list.AddRange(numbers);
            foreach (var item in list)
                Console.WriteLine(item);

            //Sort
            list.Sort();

            foreach (var item in list)
                Console.WriteLine(item);

            //Binary Search 
            Console.WriteLine(list.BinarySearch(15));  

            //Reverse
            list.Reverse();
            foreach (var item in list)
                Console.WriteLine(item);

            //Clear
            list.Clear();
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
