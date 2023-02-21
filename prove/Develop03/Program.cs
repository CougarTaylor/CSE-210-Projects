using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Would you like a shorter or longer scripture? (s/l)?");
        string verseLength = Console.ReadLine();
        Loader loader;
        RandomScripture randomScripture = new RandomScripture();
        if (verseLength == "s")
        {
            loader = new Loader(randomScripture.GetShortScripture());
        }
        else
        {
            loader = new Loader(randomScripture.GetlongScriptures());
        }
        Verse verse = new Verse(loader._text);
        string choice = "aaa";
        while (choice.ToLower() != "quit")
        {
            Console.Clear();
            verse.DisplayVerse();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue, type 'undo' to show the last word hidden, or 'quit' to quit: ");
            choice = Console.ReadLine();
            
            if (choice.ToLower() == "undo")
            {
                verse.ShowWord();
                Console.WriteLine();
            }
            else if (choice == "")
            {
                if (verse._count != verse._maxCount)
                {
                    verse.HideWord();
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
