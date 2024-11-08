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
        string userinput = Console.ReadLine();
        _duration = int.Parse(userinput);
        Console.Clear();
        
        //sets the duration of displaying each prompt
        int reflectionDuration = 5;
        int reflectionCount = _duration/5;
        int elapsedTime = 0;
    
        Console.WriteLine("Get Ready...");
        Animation();
        Thread.Sleep(500);
        
        Console.Clear();
        Console.WriteLine("Consider the following prompt:" + Environment.NewLine);
        Console.WriteLine($"-- {selectedPrompt} --" + Environment.NewLine);

        Console.WriteLine("Press Enter to begin reflecting..." + Environment.NewLine);
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.Clear();
            Console.WriteLine("Now ponder on the following questions relating to your answer." + Environment.NewLine);
            StartAnimation(reflectionDuration);
            Thread.Sleep(500);
            
            //displays prompts until the set time is reached
            for (int i = 0; i < reflectionCount; i++)
            {
                if (elapsedTime >= _duration) break;
                Console.Write("\b \b");

                string selectedFollowup = followupPrompt(followup);
                Console.WriteLine(selectedFollowup + Environment.NewLine);
                StartAnimation(reflectionDuration);
                Thread.Sleep(5000);
                elapsedTime += 5;
            }
            Console.Clear();
            Console.WriteLine("Reflection activity complete.");
            Thread.Sleep(5000);
            Console.Clear();
        }
    }

    //randomizes the prompts
    private string randomPrompt(List<string> prompts) 
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    } 

    //randomizes the followup questions
    private string followupPrompt(List<string> followup) 
    {
        Random random = new Random();
        int index = random.Next(followup.Count);
        return followup[index];
    }
}