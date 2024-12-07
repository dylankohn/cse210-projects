public class Reminders : BaseClass
{
    private string[] _reminders = new string[100];
    private int _reminderCount = 0;

    public override void Process()
    {
        Console.WriteLine("Processing Reminders...");
    }

    public void AddReminder(string reminder)
    {
        if (_reminderCount < _reminders.Length)
        {
            _reminders[_reminderCount++] = reminder;
        }
        else
        {
            Console.WriteLine("Reminder list is full.");
        }
    }

    public string[] GetReminders()
    {
        string[] result = new string[_reminderCount];
        for (int i = 0; i < _reminderCount; i++)
        {
            result[i] = _reminders[i];
        }
        return result;
    }
}
