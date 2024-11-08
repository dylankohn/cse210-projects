public class Reflection : Activity
{
    public Reflection()
    {

        List<string> prompts = new List<string>
        {
            "What is something you've learned recently that you wish you had known sooner?",
            "What are three things youre grateful for today?",
            "How have your goals evolved in the past year?",
        };

        List<string> followup = new List<string>
        {
            "Why do you think this realization or insight is especially relevant to your life right now?",
            "How might things have been different if you'd realized this sooner?",
            "What actions or changes can you make based on this new understanding?",
            "Is there anyone who influenced or inspired this new perspective? How did they help?",
        };

        string selectedPrompt = randomPrompt(prompts);
        _startMessage = "Welcome to the Reflection Activity.";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";

        DisplayMessages();
        Console.Write("How long would you like to do this activity for in seconds? ");
        string userinput = Console.ReadLine();
        _duration = int.Parse(userinput);
        int reflectionDuration = 5;
        int reflectionCount = _duration/5;
        int elapsedTime = 0;
        
        Console.WriteLine("Get Ready...");
        Animation();
        Thread.Sleep(500);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"-- {selectedPrompt} --");

        Console.WriteLine("Press Enter to begin reflecting...");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Now ponder on the following questions relating to your answer.");
            StartAnimation(reflectionDuration);
            Thread.Sleep(500);

            for (int i = 0; i < reflectionCount; i++)
            {
                
                if (elapsedTime >= _duration) break;
                Console.Write("\b \b");

                string selectedFollowup = followupPrompt(followup);
                Console.WriteLine(selectedFollowup);
                StartAnimation(reflectionDuration);
                Thread.Sleep(5000);
                elapsedTime += 5;
            }
            Console.WriteLine("Reflection activity complete.");
            Thread.Sleep(5000);
        }
    }

    private string randomPrompt(List<string> prompts) 
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    } 

    private string followupPrompt(List<string> followup) 
    {
        Random random = new Random();
        int index = random.Next(followup.Count);
        return followup[index];
    }
}