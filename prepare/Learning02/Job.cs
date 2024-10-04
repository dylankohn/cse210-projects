using System.Security.AccessControl;

public class Job 
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        string result = "";
        result += _jobTitle + " ";
        result += "(" + _company + ") ";
        result += _startYear + "-" + _endYear;
        Console.WriteLine(result);
    }
}