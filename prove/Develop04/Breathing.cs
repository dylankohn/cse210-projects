public class Breathing : Activity
{
    public Breathing()
    {
        _startMessage = "Welcome to the Breathing Activity.";
        _description = "This activity will help you relax and focus on your breathing.";

        DisplayMessages();
        Console.Write("How long would you like to do this activity for in seconds? ");
        string userinput = Console.ReadLine();
        _duration = int.Parse(userinput);

        int breathDuration = 4;
        int breathCount = _duration / breathDuration;

        int elapsedTime = 0;

        for (int i = 0; i < breathCount; i++)
        {
            if (elapsedTime >= _duration) break;
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.WriteLine("Breathe in ");
            StartAnimation(breathDuration);
            Thread.Sleep(4000);

            elapsedTime += 4;

            if (elapsedTime >= _duration) break;
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.WriteLine("Breathe out ");
            StartAnimation(breathDuration);
            Thread.Sleep(4000);
            
            elapsedTime += 4;
        }
        Console.WriteLine("Breathing activity complete.");
        Thread.Sleep(4000);
    }
}
