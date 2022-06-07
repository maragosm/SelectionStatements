using System;

namespace Number_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro and User Input
            Console.WriteLine("Want to play a game? Guess my favorite number! (Between 1 and 1,000)");
            var userInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            //Random Number Definition
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            //Guess Check Method Call
            GuessCheck(userInput, favNumber);
        }

        //Guess Check Method
        private static void GuessCheck(int userInput, int favNumber)
        {
            if (userInput > favNumber)
            {
                //Initiates the guess again if too high
                Console.WriteLine("Too high, try guessing lower.");
                userInput = int.Parse(Console.ReadLine());
                GuessCheck(userInput, favNumber);
            }
            else if (userInput < favNumber)
            {
                //Initiates the guess again if too low
                Console.WriteLine("Too low, try guessing higher.");
                userInput = int.Parse(Console.ReadLine());
                GuessCheck(userInput, favNumber);
            }
            else
            {
                //Correct guess results / school subject prompt
                Console.WriteLine("Woo hoo! You got it! Now, tell me your favorite school subject. (or else... well not really, I'm using cases not else checks)");
                string userInput2 = Console.ReadLine();

                //School subject case match check with output
                switch(userInput2)
                {
                    case "math":
                        Console.WriteLine("Neat choice, I like math");
                        break;

                    case "english":
                        Console.WriteLine("Neat choice, I like english");
                        break;  
                        
                    case "science":                       
                        Console.WriteLine("Neat choice, I like science");
                        break;

                    case "history":                       
                        Console.WriteLine("Neat choice, I like history");
                        break;

                    case "gym":                       
                        Console.WriteLine("Great choice! Gotta stay fit");
                        break;

                    default:
                        Console.WriteLine("I have never heard of that subject in my life, sorry bud.");
                        break;
                }
            }
        }
    }
}
