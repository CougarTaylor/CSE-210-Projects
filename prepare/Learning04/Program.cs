using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment task = new Assignment("Jack Daniels", "Liqour Samples");
        Console.WriteLine(task.GetSummary());

        MathAssignment task2 = new MathAssignment("Hammy Commings", "Stimulations", "6.9", "4-20");
        Console.WriteLine(task2.GetSummary());
        Console.WriteLine(task2.GetHomeWorkList());

        WritingAssignment task3 = new WritingAssignment("Jason Borne", "Withering", "European History");
        Console.WriteLine(task3.GetWritingInformation());
    }
}