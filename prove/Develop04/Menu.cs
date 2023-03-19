using System;
using System.Collections.Generic;

public class Menu
{
    private string _choice;
    private Dictionary<string, Activity> _dictionary = new Dictionary<string, Activity>() 
    {
        {"1" , new Breathing(new MovingDot())},
        {"2" , new Reflecting(new Spinner())},
        {"3" , new Listing(new Stopwatch())}
    };
    public void Begin()
    {
        while (true) {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            // Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            DisplayMenu();
            if (_choice == "4")
            {
                return;
            }
            Activity act = _dictionary[_choice];
            Console.Clear();
            act.SetUp();
            Console.Clear();
            act.GetReady();
            act.Start();
            Console.WriteLine();
            act.DisplayEndMessage();
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Menu Options:\n1. Start Breathing Activity\n2. Start Reflectiong Activity\n3. Start Listing Activity\n4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        _choice = choice;
    }

}