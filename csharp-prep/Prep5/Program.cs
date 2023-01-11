using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName =  PromptUserName();
        int userNum = PromptUserNumber();
        int squaredNum = SquareNumber(userNum);
        DisplayResult(userName, squaredNum);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            return number;
        }

        static int SquareNumber(int originalNum)
        {
            int newNum = originalNum * originalNum;
            return newNum;
        }
        
        static void DisplayResult(string name, int num)
        {
            Console.Write($"{name}, the square of your number is {num}");
        }

    }
}