using System;

public class Simple : Goal
{
    public Simple()
    {
        _name = "";
        _description = "";
        _goalPoints = 0;
        _status = false;
    }

    public Simple(string name, string description, int goalPoints, bool status)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _status = status;
    }

    // creates a simple goal
    public override void CreateGoal()
    {
        CreateMainGoal();
    }

    public override void RecordEvent()
    {
        if (_status == false)
        {
            _status = true;
        }
        else
        {
            Console.WriteLine("Goal is already completed.");
        }
    }

    public override bool Complete()
    {
        if (_status == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void ListGoal()
    {
        string statusMark = "";
        bool status = Complete();
        if (status == true)
        {
            statusMark = "X";
        }
        else
        {
            statusMark = " ";
        }
        Console.Write($"[{statusMark}] {_name} ({_description})");
    }

    public override int GetPoints()
    {
        bool status = Complete();
        int total = 0;
        if (status == true)
        {
            total = _goalPoints;
        }
        else
        {
            total = 0;
        }
        return total;
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"SimpleGoal:{_name},{_description},{_goalPoints},{Complete().ToString()}";
        return line;
    }
}
