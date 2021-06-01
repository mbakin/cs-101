using System;
using System.Collections.Generic;

namespace genericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class;
            // System.Collection.Generic
            // T -> Object

            List<int> numList = new List<int>();
            numList.Add(11);
            numList.Add(22);
            numList.Add(33);
            numList.Add(5);
            numList.Add(44);
            numList.Add(55);

            List<string> colorList = new List<string>();
            colorList.Add("Red");
            colorList.Add("White");
            colorList.Add("Blue");
            colorList.Add("Green");
            colorList.Add("Yellow");
            colorList.Add("Purple");

            // Count
            Console.WriteLine(colorList.Count);
            Console.WriteLine(numList.Count);

            foreach (var number in numList)
            {
                Console.WriteLine(number);
            }
            foreach (var color in colorList)
            {
                Console.WriteLine(color); 
            }
            numList.ForEach(number => Console.WriteLine(number));
            colorList.ForEach(color => Console.WriteLine(color));

            // Remove 
            numList.Remove(11);
            colorList.Remove("Green");
            numList.RemoveAt(0); //  Deletes the elements in the zeroth index. Index start with 0. 
            colorList.RemoveAt(2); // Deletes the elements in the second index.
            
            // Contains : Search in list
            if (numList.Contains(22))
            {
                Console.WriteLine("Find it!");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            // BinartSearch : Access index number with element
            Console.WriteLine(colorList.BinarySearch("White"));
             // Output: 1

            // Convert Array to List
            string[] animals = {"dog","bird","cat","whale"};
            List<string> animalList = new List<string>(animals);

            // Cleaning list items
            animalList.Clear();

            // Create object in list
            List<Users> userList = new List<Users>();

            Users user1 = new Users();

            user1.Name = "Aoron";
            user1.LastName = "Swartz";
            user1.Age = 26;

            Users user2 = new Users();
            user2.Name ="Tim";
            user2.LastName = "Gates";
            user2.Age = 66;

            userList.Add(user1);
            userList.Add(user2);

            List<Users> newList = new List<Users>();
            newList.Add(new Users()
            {
                Name= "Feyyaz",
                LastName = "Yigit",
                Age= 42
            });
            foreach (var user in userList)
            {
                Console.WriteLine("Name : " + user.Name);
                Console.WriteLine("Lastname : " + user.LastName);
                Console.WriteLine("Age : " + user.Age);
                
            }
            newList.Clear();
        }
    }
    public class Users
    {
        private string name;
        private string lastName;
        private int age;

    public int Age { get => age; set => age = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string Name { get => name; set => name = value; }
    }
}
