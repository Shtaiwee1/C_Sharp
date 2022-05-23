

using System; // importing system namespace to use it's classes and methods ex: console is a class in system.

//Datatypes and variables fundamentals

namespace Net5App
{
    internal class Program
    {

        //entry point of our program
        static void Main(string[] args)
        {
            //when you declare floats you have to use f after a number
            float o = 3.4626452452f;
            //multiple variable declarations
            int num4, num5, num7 , num6;
            int age = 5;
            byte u = 4; //you can refer to byte dtatype as byte or sbyte
            age = 15;
            num4 = 6;
            num6 = 8;
            double pi = 3.145;
            num5 = num6 + num4;
            Console.WriteLine("this is the age " + age + " and this is the number " + num5 + u);
            Console.WriteLine(age);
            Console.WriteLine("Hello World!");
            Console.WriteLine("Im currently learning c#");
            //semicolon is very important in c# 
            // c# is very similar to Java
            string myName = "Mohammad";
            Console.Write(myName);
            Console.Write("Where are you now?"); //console write keeps the cursor on the same line : for more go to: https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline?view=netcore-3.1#System_Console_WriteLine_System_String_

            ///<summary>
            ///this is a cool method
            /// </summary>   XML documentation commenting

            Console.WriteLine(myName.ToUpper());


            //important resources for value and reference types comparisons , categorization and definitions in C#://https://www.tutorialsteacher.com/csharp/csharp-value-type-and-reference-type

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Enter anything you want");
            string EnteredValue = Console.ReadLine();
            int wow = 111;
            //String formatting
            //String formatting uses index
            Console.WriteLine("You entered  {0} and the number is {1}", EnteredValue , wow);

            //Console.Read();//this line is used to keep the console open 

            //string interpolation we can use the dollar sign $ at the beginning which will allow us to write our variables like this {variable}
            Console.WriteLine($"You entered  {EnteredValue} and the number is {wow}");


            //use /n for a line break

            //verbatim strings use @ sign before a string tells the compiler to take the strings literally and ignore any spaces and escape characters like /n







            //implicit conversion
            int num = 65465;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNum = myFloat;
            Console.WriteLine(myNum);


            //type conversion
            string myFloatString = myFloat.ToString();
            bool sun = false;

            string sunny = sun.ToString();
            Console.WriteLine(sunny);





            //explicit conversion
            //cast double to int
            double myDouble = 13.37;
            int myInt = (int)myDouble;
            Console.WriteLine(myInt);





            //use PascalCasing for class names and method names.
            //use camelCasing for local variables and method arguments.
            //Naming Conventions and Coding Standards: https://www.dofactory.com/csharp-coding-standards

            // Class names like ClientActivity


            // Method name like CalculateValue
            // method arguments like firstNumber
            
            
                // local variables like itemCount

                // use userControl instead of usrCtr 

                // don't use numbers at the start of variable names


                // Correct
                string myNam;
                int lastNum;
                bool isSaved;

            // Avoid
            // String myName;
            // Int32 lastNum;
            // Boolean isSaved;


            string myFirstString = "15";
            string mySecondString = "564";

            //parse string to integer you can also parse to any other datatype

            int num1 = Int32.Parse(myFirstString);
            int num2 = Int32.Parse(mySecondString);
            Console.WriteLine(num1 + num2);



            Console.WriteLine(myFirstString + mySecondString); // the strings will be concatenated just like java



            //Parse the string variables from below into the correct datatypes:

            string stringForFloat = "0.85"; // datatype should be float
            float myFirstTest = float.Parse(stringForFloat);
            string stringForInt = "12345"; // datatype should be int
            int test = Int32.Parse(stringForInt); //Int32 or in.Parse are used to parse to integers
            Console.WriteLine(myFirstTest);




            //string methods resources:https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netcore-3.1

            //constants are immutable as always at compile time for the life of the program
            const double PI = 3.15464;
            const int weeks = 54 , fofo = 542;

            //fofo = 87; can't reassign value for a constant as usual



            //cheetsheats:
            //https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netcore-3.1
            //https://cheatography.com/laurence/cheat-sheets/c/


            //string presto;
            //Console.WriteLine("Please enter your name and press enter");
            //presto = Console.ReadLine();
            //Console.WriteLine(presto.ToUpper());
            //Console.WriteLine(presto.ToLower());
            //Console.WriteLine(presto.Trim());
            //Console.WriteLine(presto.Substring(3));
            //Console.Read();

            //to comment something out ctrl + k + c nad ctrl + k + u to uncomment




            //Console.WriteLine("Enter any string here");
            //string theString = Console.ReadLine();
            //Console.WriteLine("Enter a character");
            //char theChar = Console.ReadLine()[0];
            //Console.WriteLine(theString.IndexOf(theChar));
            //Console.Read();


            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter any last name");
            string lastName = Console.ReadLine();
            Console.WriteLine(String.Concat(firstName , " " , lastName));
            Console.Read();















        }

    }
    }


    

