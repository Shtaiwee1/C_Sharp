using System;
using System.Threading;

namespace Threading
{
    internal class Program
    {//Thread is a small piece of work or task  to execute individually or in a parallel manner
        static void Main(string[] args) //Threading used to pause a thread for a specific amount of time
        {
            /*
            Console.WriteLine("Hello World!");
            Thread.Sleep(1500); //do something after a specific amount of time
            Console.WriteLine("Hello World!");
            Thread.Sleep(1000);
            Console.WriteLine("Hello World!");
            Thread.Sleep(1500);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            */
            

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Thread 4");
            }).Start();

            Console.Read();

        }

        //There are two types types of threading, single threading and multi-threading.JavaScript is a single threaded
        //programming language, Java or C# are multi-threaded programming languages.
        //What this means is that JavaScript can only run one instruction at a time while Java could run multiple instructions concurrently
    }
}
