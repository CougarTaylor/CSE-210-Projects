using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        Menu menu = new Menu();
        Journal journal = new Journal();
        FileManager fileManager = new FileManager();
        var prompts = new List<string>{"Who was the most interesting person I interacted with today?",
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?",
        "What is something you could do for a friend right now?", "What do you think would be good place to eat at tomorrow?"};

        do
        {
            input = menu.DisplayMenu();

            if (input == "1")
            {
                Entry entry = new Entry();
                Random random = new Random();
                int promptIndex = random.Next(prompts.Count);
                entry._prompt = prompts[promptIndex];
                entry.JournalPrompt();
                journal.entries.Add(entry);
            }
            
            if (input == "2")
            {
                journal.Display();
            }
            
            if (input == "3")
            {
                fileManager.LoadEntries();
            }
            if (input == "4")
            {
                fileManager.SaveEntries(journal.entries);
                Console.WriteLine("Your entries have been saved.");
            }
        
            Console.WriteLine("");
        
        } while (input != "5");
    }
}