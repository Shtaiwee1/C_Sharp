using System;

namespace GeneralPractice
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Check(0);
            CheckScore(90, "Mohammad");
            Console.Read();
        }






        public static void Check(int Num) //triple equality is not included in C# unlike Javascript
        {
            if(Num % 2 == 0)
            {
                Console.WriteLine("This is an even number and it is {0}" , Num);
            }else if (Num % 2 != 0)
            {
                Console.WriteLine("This is an odd number and it is {0}", Num);
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

        static int HighScore = 84;
        static string ScoreHolder = "Rashed";
        public static void CheckScore(int Score , string Player) 
        {
            
            if (HighScore >= Score)
            {
                Console.WriteLine("The recore hasnt been broken the high score is still {0} and the holder is {1} " , HighScore, ScoreHolder);
            }else if(HighScore < Score)
            {
                Console.WriteLine("The recore has been broken the new high score is {0} and the holder is {1} ", Score, Player);
            }
            
        }
    }
}
