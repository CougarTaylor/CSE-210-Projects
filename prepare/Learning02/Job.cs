using System;

public class Job
{    
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayCompany()
    {
        Console.WriteLine($"{_company}");
    }
    public void DisplayInfoLeak()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }


}