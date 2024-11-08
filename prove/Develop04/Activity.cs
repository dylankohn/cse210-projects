using System;

public class Activity
{
    protected string _startMessage;
    protected string _description;
    public void DisplayMessages()
    {
        Console.WriteLine(_startMessage);
        Console.WriteLine(_description);
        Console.Write("How long would you like to do this activity for in seconds? ");
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