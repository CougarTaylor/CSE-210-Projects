using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbersList = new List<int>();
        int currentNumber = 0;
        int listSum = 0;
        int largestNum = 0;
        int numCount = 0;
        do
        {
            Console.Write("Please enter a number: ");
            string currentNumberString = Console.ReadLine();
            currentNumber = int.Parse(currentNumberString);
            numbersList.Add(currentNumber);
        } while (currentNumber != 0);

        foreach (int number in numbersList)
        {
            numCount += 1;
            listSum += number;
            if (number > largestNum)
            {
                largestNum = number;
            }
        }

        int listAverage = listSum / numCount;

        Console.WriteLine($"The sum is: {listSum}");
        Console.WriteLine($"The average is: {listAverage}");
        Console.WriteLine($"The largest number is: {largestNum}");

    }
}