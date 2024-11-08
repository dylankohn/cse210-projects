using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
public class Listing : Activity
{
    public Listing()
    {
        // List of prompts for the user to consider
        List<string> prompts = new List<string>
        {
            "List three personal achievements you're proud of and why they mean so much to you.",
            "What are the qualities you value most in other people, and why are these important to you?",
            "Name challenges you've overcome in the past year and what each taught you.",
        };
        // defining the variables
        string selectedPrompt = randomPrompt(prompts);
        _startMessage = "Welcome to the Listing Activity.";
        _description = "This activity will help you list things that you are grateful for or were meaningful to you.";

        //displays the activity specific messages
        DisplayMessages();
        string userinput = Console.ReadLine();
        _duration = int.Parse(userinput);
        Console.Clear();
        int itemsCount = 0;

        //loading screen
        Console.WriteLine("Get Ready...");
        Animation();
        Thread.Sleep(500);

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"-- {selectedPrompt} --");

        //starts timer
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        //runs until the timer reaches the set time of user
        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            
            Console.Write("> ");
            string[] items = Console.ReadLine().Split(',');
            itemsCount += items.Length;

            if (stopwatch.Elapsed.TotalSeconds >= _duration)
            {
                break;
            }
        }

        stopwatch.Stop();
        Console.WriteLine("Listing activity complete." + Environment.NewLine);
        Console.WriteLine($"You listed {itemsCount} things!");
        Thread.Sleep(4000);
        Console.Clear();
    }

    //function to randomize prompts
    private string randomPrompt(List<string> prompts) 
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    } 
}