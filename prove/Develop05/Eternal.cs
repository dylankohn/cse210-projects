using System;

public class Eternal : Goal
{
    DateTime now = DateTime.Now;
    public Eternal()
    {
        _name = "";
        _description = "";
        _goalPoints = 0;
        _subCounter = 0;
        _status = false;
    }

    public Eternal(string name, string description, int goalPoints, int subCounter, bool status)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _subCounter = subCounter;
        _status = status;
    }

    public override void CreateGoal()
    {
        CreateMainGoal();
    }

    public override void ListGoal()
    {
        Console.Write($"[ ] {_name} ({_description})");
    }

    public override bool Complete()
    {
        if (_status == true)
        {
            return true;
        }
        else if (now.TimeOfDay == TimeSpan.Zero) // This is to check if the time is midnight and reset the goal.
        {
            return false;
        }
        else
        {
            return false;
        }
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"EternalGoal,{_name},{_description},{_goalPoints},{_subCounter}";
        return line;
    }

    public override void RecordEvent()
    {
        _subCounter++;
    }

    public override int GetPoints()
    {
        int points = _goalPoints;
        return points;
    }
}