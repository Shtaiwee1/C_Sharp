using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>() { "Tom", "Jerry", "Luffy", "Zoro" , "Aiden" , "Sif" , "Mimo" };

            //print the names before the removeAll method
            Console.WriteLine("-----before-----");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //removeall method will remove all names fro mthe list , we passed a method filter which we created
            names.RemoveAll(Filter);

            Console.WriteLine("-----After-----");
            //print the names after
            foreach (string name in names)
            {
                
                Console.WriteLine(name);
            }
            //A method called filter which will take a string(in this example filter method is a delegate or a predicate)
            static bool Filter(string s)
            {
                //return whether string s contains the letter i
                //the contains method will return a bool whic hwe will return as well
                return s.Contains("i");
            }

            Console.Read();
        }
    }
}
