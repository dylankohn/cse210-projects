using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
public class Listing : Activity
{
    public Listing()
    {
        List<string> prompts = new List<string>
        {
            "List three personal achievements you're proud of and why they mean so much to you.",
            "What are three qualities you value most in other people, and why are these important to you?",
            "Name three challenges you've overcome in the past year and what each taught you.",
        };
        string selectedPrompt = randomPrompt(prompts);
        _startMessage = "Welcome to the Listing Activity.";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";

        DisplayMessages();
        string userinput = Console.ReadLine();
        _duration = int.Parse(userinput);
        int itemsCount = 0;

        Console.WriteLine("Get Ready...");
        Animation();
        Thread.Sleep(500);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"-- {selectedPrompt} --");

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("> ");
            string[] items = Console.ReadLine().Split(',');
            itemsCount += items.Length;
        }

        stopwatch.Stop();
        Console.WriteLine($"You listed {itemsCount} ");
    }

    private string randomPrompt(List<string> prompts) 
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    } 
}