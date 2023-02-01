using System;


public class FileManager
{
    public void SaveEntries(List<Entry> entries)
    {
        string fileName = "MyJournal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date},.,{entry._prompt},.,{entry._userInput}");
            }
        }
    }
    public void LoadEntries(Journal journal)
    {
        string filename = "MyJournal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        journal.entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",.,");

            string date = parts[0];
            string prompt = parts[1];
            string input = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompt = prompt;
            entry._userInput = input;
            journal.entries.Add(entry);

        }
        Console.WriteLine($"Entries Loaded");
    }
}
