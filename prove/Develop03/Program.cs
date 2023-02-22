using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Would you like a shorter or longer scripture? (s/l)?");
        string verseLength = Console.ReadLine();
        string scriptureText;
        RandomScripture randomScripture = new RandomScripture();
        if (verseLength == "s")
        {
            scriptureText = randomScripture.GetShortScripture();
        }
        else
        {
            scriptureText = randomScripture.GetlongScriptures();
        }
        Scripture scripture = new Scripture(scriptureText);
        string choice = "aaa";
        while (choice.ToLower() != "quit")
        {
            Console.Clear();
            scripture.DisplayVerse();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue, type 'undo' to show the last word hidden, or 'quit' to quit: ");
            choice = Console.ReadLine();
            
            if (choice.ToLower() == "undo")
            {
                scripture.ShowWord();
                Console.WriteLine();
            }
            else if (choice == "")
            {
                if (scripture._count != scripture._maxCount)
                {
                    scripture.HideWord();
                    Console.WriteLine();
                }
                else
                {
                    choice = "quit";
                }
            } 
        }
    }
}
