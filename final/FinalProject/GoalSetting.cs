public class GoalSetting : BaseClass
{
    private string[] _goals = new string[100];
    private int _goalCount = 0;

    public override void Process()
    {
       Console.WriteLine("Processing Goal Setting...");
    }

    public void SetGoal(string goal)
    {
        if (_goalCount < _goals.Length)
        {
            _goals[_goalCount++] = goal;
        }
        else
        {
            Console.WriteLine("Goal list is full.");
        }
    }

    public string[] GetGoals()
    {
        string[] result = new string[_goalCount];
        for (int i = 0; i < _goalCount; i++)
        {
            result[i] = _goals[i];
        }
        return result;
    }
}
