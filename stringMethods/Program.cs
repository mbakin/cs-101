using System;

namespace stringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string foo = "Lorem ipsum dolor sit amet";
            string foo2 = "lorem ipsum dolor sit amet";

            //length
            Console.WriteLine(foo.Length);

            //ToUpper ve ToLower
            Console.WriteLine(foo.ToLower());
            Console.WriteLine(foo.ToUpper());

            //Concat
            Console.WriteLine(String.Concat(foo," Morning!"));

            //Compare , CompareTo
            Console.WriteLine(foo.CompareTo(foo2)); // 0,1,-1 döndürür
            Console.WriteLine(String.Compare(foo,foo2,true));
            Console.WriteLine(String.Compare(foo,foo2,false));

            //Contains
            Console.WriteLine(foo.Contains(foo2));
            Console.WriteLine(foo.EndsWith("Welcome"));
            Console.WriteLine(foo.StartsWith("X"));

            //IndexOf
            Console.WriteLine(foo.IndexOf("sit"));
            Console.WriteLine(foo.IndexOf("Lorem"));
            Console.WriteLine(foo.LastIndexOf("i"));

            //Insert
            Console.WriteLine(foo.Insert(0,"Hi!"));

            //PadLeft PadRight
            Console.WriteLine(foo+foo2.PadLeft(30));
            Console.WriteLine(foo+foo2.PadLeft(30,'*'));
            Console.WriteLine(foo.PadRight(50)+foo2);
            Console.WriteLine(foo.PadRight(50,'-')+foo2);

            //Remove
            Console.WriteLine(foo.Remove(10));
            Console.WriteLine(foo.Remove(5,3));
            Console.WriteLine(foo.Remove(0,1));

            //Replace
            Console.WriteLine(foo.Replace(" ","*"));

            //Split
            Console.WriteLine(foo.Split(' ')[1]);
    
            //Substring
            Console.WriteLine(foo.Substring(4));
            Console.WriteLine(foo.Substring(4,6));
        }
    }
}
