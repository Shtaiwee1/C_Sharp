using System;

namespace MethodsAndFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            doSomething();
            takeAParameter("Lets goooooooooo");
            Console.WriteLine(Divide(654, 54));
            Console.WriteLine(Divide(654.41, 54.785));
            Console.WriteLine(Divide(Divide(654.41, 54.785), Divide(654.4, 97.5)));
            GreetFriend("Osama");
            //Console.Read();

            //If you want to call any method inside another static method that method has to be static also
            //all methods called here must be static



            //try catch and finally for error and exception handling
            Console.WriteLine("Please enter a number");
            string EnteredNumber = Console.ReadLine();
            try
            {

                int EnteredNumber2 = int.Parse(EnteredNumber);

                Console.WriteLine("The entered number is {0} that is a nice number" , EnteredNumber2);


            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a the correct datatype");
            }
            finally
            {
                Console.WriteLine("This will be read anyways");
            }

            Console.Read();






            int num1 = 5;
            int num2 = 0;


            

            try
            {

                int result = num1 / num2;
                Console.WriteLine(result);

            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Dividing by zero is not acceptable");
            }




            Console.WriteLine("Please enter a number!");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }

            Console.ReadKey();





        }





        public static void doSomething() //static keyword is mandatory because we are not using an object to call the method
        {
            Console.WriteLine("I'm a method called from the main method");
            //Console.Read(); // cant use console.read here to read the whole program you must use it in the main  to read the whole program
        }


        public static void takeAParameter(String text)
        {
            Console.WriteLine(text);
        }

        public static double Divide(double num1 , double num2)
        {
            return num1 / num2;
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine(" Hi " + name);
        }



        













    }
}
