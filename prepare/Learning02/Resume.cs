using System;

public class Resume
{    
    public string _name;

    // It would do well for me to remember....
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        foreach (Job job in _jobs)
        {
            job.DisplayInfoLeak();
        }
    }

}