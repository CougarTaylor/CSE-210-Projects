using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Magic Number Game! \nWe've picked a magic number form 1 to 100.");

        string input;
        int guess;
        int numOfGuesses = 0;
        string playMore = null;
        do
        {
            
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            do
            {
                Console.Write("What is your guess? ");
                input = Console.ReadLine();
                guess = int.Parse(input);
                if (guess < number)
                {
                    Console.WriteLine("Too Low!");
                    numOfGuesses += 1;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too High!");
                    numOfGuesses += 1;
                }
                else
                {
                    break;
                }
            } while (guess != number);

            Console.WriteLine($"You Guessed it!  You took {numOfGuesses} tries.");
            Console.Write("Would you like to play again? ");
            playMore = Console.ReadLine();
            if (playMore == "yes") 
            {
                Console.WriteLine();
                Console.WriteLine("Great! A new number has been chosen.");
                numOfGuesses = 0;
            }
        } while (playMore == "yes");
    }
}