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
    public void LoadEntries()
    {
        string filename = "MyJournal.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",.,");

            string date = parts[0];
            string prompt = parts[1];
            string input = parts[2];
            
            Console.WriteLine($"Date: {date} - Prompt: {prompt}");
            Console.WriteLine($"{input}\n");
        }
    }
}
