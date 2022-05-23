using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an instance of human
            Human denis = new Human();
            denis.firstName = "Denis";
            denis.lastName = "John";
            //Console.WriteLine(denis.firstName);
            denis.IntroduceYourself();


            Human Tom = new Human();
            Tom.firstName = "Tom";
            Tom.lastName = "Bob";
            Tom.IntroduceYourself();
            Console.Read();
        }
    }
}
