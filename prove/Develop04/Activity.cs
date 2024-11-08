using System;

public class Activity
{
    protected string _startMessage;
    protected string _description;
    public void DisplayMessages()
    {
        Console.Clear();
        Console.WriteLine(_startMessage);
        Console.WriteLine(_description + Environment.NewLine);
        Console.Write("How long would you like to do this activity for in seconds? " + Environment.NewLine);
    }
    protected int _duration = 0;

    public void Animation()
    {
        Console.Write("+");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

    protected void StartAnimation(int length)
    {
        Thread animationThread = new Thread(() => RepeatAnimation(length));
        animationThread.Start();
    }

    protected void RepeatAnimation(int length)
    {
        for (int i = 0; i < length; i++)
        {
            ClearAnimation();
            Animation();
        }
    }

    protected void ClearAnimation()
    {
        Console.Write("\b \b");
    }
}