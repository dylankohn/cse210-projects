using System;

public class Goal
{
    // initialize variables
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _status;
    protected int _subCounter;
    protected int _steps;
    protected int _bonusPoints;
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;
    public int GetTotalPoints()
    {
        int points = _totalPoints;
        return points;
    }

    // function to save all goals to a file.
    public void SaveAllGoals()
    {
        string fileName = "";
        Console.Write("Enter the file name: ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            int totalPoints = GetTotalPoints();
            outputFile.WriteLine(totalPoints.ToString());
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    // loads all goals from specified file
    public void LoadAllGoals()
    {
        _goals.Clear();

        string fileName = "";
        Console.Write("Enter the file name: ");
        fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        _totalPoints = Convert.ToInt32(lines[0]);

        for (int i = 1; i < lines.Count(); i++)
        {
            string[] parts = lines[i].Split(',');

            if (parts[0] == "SimpleGoal")
            {
                Simple newSimple = new Simple(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToBoolean(parts[4]));
                _goals.Add(newSimple);
            }
            else if (parts[0] == "EternalGoal")
            {
                Eternal newEternal = new Eternal(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToBoolean(parts[5]));
                _goals.Add(newEternal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                Checklist newChecklist = new Checklist(parts[1], parts[2], Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5]), Convert.ToInt32(parts[6]));
                _goals.Add(newChecklist);
            }
        }
    }

    // lists all goals in file
    public void ListAllGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. ");
            _goals[i].ListGoal();
            Console.Write("\n");
        }
        Console.WriteLine();
    }

    // adds goal to list
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // calculates all points
    public int CalculateAllPoints()
    {
        int totalCalculatedPoints = _totalPoints;
        foreach (Goal goal in _goals)
        {
            totalCalculatedPoints += goal.GetPoints();
        }
        _totalPoints = totalCalculatedPoints;
        return totalCalculatedPoints;
    }

    // records completion of goal
    public void RecordCompletion()
    {
        string goalIndex = "";
        Console.Write("Which goal did you complete? ");
        goalIndex = Console.ReadLine();
        int goalIndexNumber = Convert.ToInt32(goalIndex) - 1;

        if (_goals[goalIndexNumber].Complete() == false)
        {
            _goals[goalIndexNumber].RecordEvent();
            int pointsGotten = _goals[goalIndexNumber].GetPoints();

            _totalPoints += pointsGotten;
            Console.WriteLine($"You have gained {pointsGotten} points!");
        }
        else
        {
            Console.WriteLine("Already Completed!");
        }
    }

    public Goal()
    {
        _name = "";
        _description = "";
        _goalPoints = 50;
        _status = false;
    }

    public Goal(string name, string description, int goalPoints)
    {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    // function to run when a goal is to be created
    protected void CreateMainGoal()
    {
        Console.Write("Enter the name of the goal: ");
        _name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        _description = Console.ReadLine();
        Console.Write("Enter the goal points: ");
        _goalPoints = Convert.ToInt32(Console.ReadLine());

        _status = false;
    }   

    // saves goal depending on type using polymorphism
    public virtual string SaveGoal()
    {
        string line = "";
        return line;
    }

    // here and down are the polymorphic functions
    public virtual void CreateGoal()
    {

    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool Complete()
    {
        return false;
    }

    public virtual void ListGoal()
    {

    }

    public virtual int GetPoints()
    {
        return _totalPoints;
    }

}