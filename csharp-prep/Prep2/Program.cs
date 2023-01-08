using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string gradeNumberString = Console.ReadLine();
        int gradeNumber = int.Parse(gradeNumberString);
        string grade = "A";
        string passing = "Yes";
        string a = "a";
        string rate = "";

        if (gradeNumber >= 90)
        {
            grade = "A";
            a = "an";
        }
        else if (gradeNumber >= 80)
        {
            grade = "B";
        }
        else if (gradeNumber >= 70)
        {
            grade = "C";
        }
        else if (gradeNumber >= 60)
        {
            grade = "D";
        }
        else
        {
            // grade = "F";
            passing = "No";
        }

        if (gradeNumber >= 60 && gradeNumber < 90)
        {
            if ((gradeNumber /= 10) >= 7)
            {
                rate = "+";
            }
            else if ((gradeNumber /= 10) < 3)
            {
                rate = "-";
            }
        }

        if (passing == "Yes")
        {
            Console.Write($"Congragulations, your grade is equivilant to {a} {grade}{rate}");
        }
        else if (passing == "No")
        {
            Console.Write("Sorry, you got an F, hope you do better next time!");
        }
    }
}