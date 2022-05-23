using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 30;
            grades[2] = 30;
            grades[3] = 30;
            grades[4] = 30;

            Console.WriteLine("The grade at index 3 is {0}" , grades[3]);
            Console.WriteLine("Enter the new Value");
            string input = Console.ReadLine(); //when you insert a value it will be read as a string that is why you have to parse it again into an integer
            grades[3] = int.Parse(input);// change a value inside an array
            Console.Write("The new value is {0}", grades[3]);
            Console.Read();
        }
    }
}
