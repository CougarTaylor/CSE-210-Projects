using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.Write("Please enter your grade percentage: ");       //    Changing Strings to Integers
        string gradeNumberString = Console.ReadLine();
        int gradeNumber = int.Parse(gradeNumberString);   //    Use .ToString()  to go the other way

        Random randomGenerator = new Random();   //    For example
        int number = randomGenerator.Next(1, 11);
        string magicNumber = number.ToString();



                                        //      If statements
        if (gradeNumber >= 90)
        {
            grade = "A";
            a = "an";
        }
        else if (gradeNumber >= 80)
        {
            grade = "B";
        }
        else
        {
            grade = "F";
            passing = "No";
        }
        
        if (gradeNumber >= 60 && gradeNumber < 90)
        {
            Console.Write("Do Nothing");
        }



        string input;                      //             While Loops
        do
        {
            Console.Write("Do you want to continue? ");
            input = Console.ReadLine();
        } while (input == "yes");


                                           //           For Loops
        for (int i = 0; i < 10; i++) //      Same as      for (int i = 2; i <= 20; i = i + 1)
        {
            Console.WriteLine(i);
        }

        foreach (string color in colors)   //     ForEach Loops
        {
            Console.WriteLine(color);
        }

                                                //           Easy Random Number 
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);



        string name = null;     //   How to disable "Local Variable restriction for --STRINGS--
        // Important!!  --  if you are not calculating or changing an integer, then it's fine to leave it blank
        // when creating it, such as  " int numberx; ". 
        // However, if you are messing with it, then you must assign a value first like this " int numberx = 0 ".






















    }
}