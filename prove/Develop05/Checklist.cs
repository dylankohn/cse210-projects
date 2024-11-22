using System;

public class Checklist : Goal
{
    public Checklist()
    {
        _name = "";
        _description = "";
        _goalPoints = 0;
        _bonusPoints = 0;
        _steps = 0;
        _subCounter = 0;
        _status = false;
    }

    public Checklist(string name, string description, int goalPoints, int bonusPoints, int steps, int stepCounter)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _bonusPoints = bonusPoints;
        _steps = steps;
        _subCounter = stepCounter;
    }

    // little different than others because of the steps and bonus points
    public override void CreateGoal()
    {
        CreateMainGoal();

        Console.Write("Enter the number times this goal needs to be accomplished for the bonus? ");
        string goalTimes = Console.ReadLine();
        _steps = Convert.ToInt32(goalTimes);

        Console.Write("Enter the bonus points for completing the goal: ");
        string bonusPoints = Console.ReadLine();
        _bonusPoints = Convert.ToInt32(bonusPoints);

        _subCounter = 0;
    }

    public override bool Complete()
    {
        if (_subCounter >= _steps)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void RecordEvent()
    {
        _subCounter++;
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

        Console.Write($"[{statusMark}] {_name} ({_description}) -- Currently Completed {_subCounter}/{_steps}");
    }

    public override string SaveGoal()
    {
        string line = "";
        line = $"ChecklistGoal,{_name},{_description},{_goalPoints},{_bonusPoints},{_steps},{_subCounter}";
        return line;
    }

    public override int GetPoints()
    {
        int points = 0;
        points = _subCounter * _goalPoints;
        bool status = Complete();
        if (status == true)
        {
            points += _bonusPoints;
        }
        return points;
    }
}