using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{//an empty constructor is given by default but in case there are other constructors you must define it and write it down if their wasn't any others you don't need to
    internal class Human
    {
        //member variable
        public string firstName;
        public string lastName;
        //best practice is using constructor to pass parameters to the new objects and setting the properties to private don't use them directly

        public Human()
        {
            //if you remove this constructor in this case you will have an error in the main method because you need to write it down
        }
       public Human(string firstName, string lastName)
        {
            firstName = this.firstName;
            lastName = this.lastName;
        }




        public void IntroduceYourself()
        {
            Console.WriteLine("My first name is {0}",   this.firstName);
            Console.WriteLine("My last name is " + this.lastName);
        }
    }


    //resources for access modifiers or access specifiers:https://code-maze.com/csharp-access-modifiers/
    //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers  



}
