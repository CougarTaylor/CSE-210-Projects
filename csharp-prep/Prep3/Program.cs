using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        // string magicNumber = number.ToString();

        Console.WriteLine("\nWelcome to the Magic Number Game! \nWe've picked a magic number form 1 to 10.");

        string input;
        int guess;
        do
        {
            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);
            if (guess < number)
            {
                Console.WriteLine("Too Low!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too High!");
            }
            else
            {
                break;
            }
        } while (guess != number);

        Console.Write("You Guessed it!");
    }
}