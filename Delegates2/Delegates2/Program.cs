using System;
using System.Collections.Generic;

namespace Delegates2
{
    //internal is the default access modifier for a class in c sharp
    internal class Program
    {

        //Defining a delegate type called FilterDelegate that takes a person object and returns a boolean
        public delegate bool FilterDelegate(Person p);


        static void Main(string[] args)
        {

            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoly", Age = 25 };

            //add the objects to a list called people
            //use ctrl + alt hold them to choose multiple elements in VS.
            List<Person> people = new List<Person> { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, IsMinor);
            DisplayPeople("Adults", people, IsAdult);
            DisplayPeople("Seniors", people, IsSenior);

            //here we created a new variable called filyer of type FilterDelegate.
            //then we assigned an anonymous method to it instead of an already defined method.
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age <= 30;
            };

            Console.WriteLine("People between 20 and 30 years old");
            DisplayPeople("Kids", people, filter);
            //dont forget the ; at the end because we are declaring a variable and assiging its value at the dame time just like int x =3; for example


            //A third way to declare a delegate pass an anonymous function directly as a parameter.
            DisplayPeople("All:", people, delegate (Person p) { return true; });



            //statement lambda
            //a search keyword to filter the names
            string searchkeyword = "A";

            DisplayPeople("The list of People that contains the" + searchkeyword, people, p =>
            {
                if (p.Name.Contains(searchkeyword) && p.Age > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            
            //Expression lambda
            //here we are using expression lambda (one line of code)
            DisplayPeople("exactly 25", people, p => p.Age == 25);
        }
        
        //a method will display the list of people that pass the filter consition(returns true)
        //it will take a title to be displayed, a list of people and a filter delegate
        static void DisplayPeople(string title , List<Person> people , FilterDelegate filter)
        {
            //print the title
            Console.WriteLine(title); 

            foreach(Person person in people)
            {
                //check if this person passes the filter
                if (filter(person))
                {
                    Console.WriteLine("The person name is {0} and the age is {1} ", person.Name , person.Age);
                }
            }

        }

        //======Filters=========//

        static bool IsMinor(Person p)
        {
            return p.Age < 18;
        }

        static bool IsAdult(Person p)
        {
            return p.Age >= 18;
        }

        static bool IsSenior(Person p)
        {
            return p.Age >= 65;
        }



    }
}
