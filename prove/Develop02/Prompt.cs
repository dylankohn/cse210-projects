using System;
using System.Runtime.InteropServices;

class Prompt
{
    static public string[] _promptPool = {
            "What has been the best part of your day?", "Tell me what you did today!", "What was frustrating today?", 
            "Did you achieve any of your goals today?", "What was something fun that you did today?", 
            "What new thing did you try today?", "How often did you remember God today?", 
            "What is the thing that made you the most happy today?", "What do you think you can do differently tomorrow?", 
            "How have you blessed other peoples lives today?"
        };
    
    static private Random random = new Random();

    public string generatePrompt()
    {
        int _randomIndex = random.Next(0, _promptPool.Length);
        string _randomPrompt = _promptPool[_randomIndex];
        return _randomPrompt;
    }
}
