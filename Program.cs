using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowGreeting();

            int low = 1;
            int high = 1024;
            int guess = 0;
            string userResponse = "";

            while (userResponse != "CORRECT")
            {
                guess = (low + high) / 2;
                userResponse = IsGuessCorrect(guess);

                if (!ValidateResponse(userResponse))
                {
                    Console.WriteLine("Invalid response, exiting the game...");
                    return;
                }
                if (userResponse == "LOWER")
                {
                    high = guess;
                }
                else if (userResponse == "HIGHER")
                {
                    low = guess;
                }
            }

            BragWhenCorrect();
        }

        static void ShowGreeting()
        {
          Console.WriteLine();
          Console.WriteLine("GREETINGS! I AM THE AMAZING NUMBER GUESSER! 🔮");
          Console.WriteLine();
          Console.WriteLine("Please think of, BUT DO NOT TELL ME 🤫, a number between 1 and 1024.");
          Console.WriteLine("Using my amazing computing power I will figure out your number by asking you questions.");
          Console.WriteLine();
          Console.WriteLine("Here we go!");
          Console.WriteLine("🚀🚀🚀");
          Console.WriteLine();
          Console.WriteLine();
        }

        static string IsGuessCorrect(int guess)
        {
          Console.WriteLine($"My guess is {guess}. ");

           Console.WriteLine($"Is your number HIGHER, LOWER, or am I CORRECT?");
           return Console.ReadLine().ToUpper();
         
        }
        
        static bool ValidateResponse(string userResponse)
          {
            if (userResponse == "CORRECT" || userResponse == "HIGHER" || userResponse == "LOWER")
            {
                return true;
            }
            else
            {
              return false;
            }
          }
        static void BragWhenCorrect()
        {
          Console.WriteLine("You are no match for my amazing computing power!");
        }
    }
}
