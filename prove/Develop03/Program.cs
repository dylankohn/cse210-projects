using System;

class Program
{
    static void Main(string[] args)
    {
        Reference myReference = new Reference();
        string referenceContent = myReference.displayReference();
        Console.Write(referenceContent);

        Word blankScripture = new Word();
        ConsoleKeyInfo key;

        Scripture originalScripture = new Scripture();
        string scriptureContent = originalScripture.DisplayScripture();
        Console.WriteLine(scriptureContent);

        Console.Write("Press enter to blank a couple words(press 'q' to quit): ");
        
        //while enter is pressed it will blank a random 3 words
        while(true)
        {
            key = Console.ReadKey();

            if (key.Key == ConsoleKey.Q)
            {
                break;
            }

            if (key.Key == ConsoleKey.Enter)
            {
                Console.Write(referenceContent);
                string blankedScripture = blankScripture.removeWord();
                Console.WriteLine(blankedScripture);

                //checks if scripture has all blanked words
                string[] blankedWords = blankedScripture.Split(' ');
                bool allBlanked = Array.TrueForAll(blankedWords, word => word == "___");

                //if true returns the question to check memorization
                if (allBlanked)
                {
                    Console.Write("What is the scripture? ");
                    string memorizer = Console.ReadLine();
                    
                    if (memorizer.ToLower() == scriptureContent.ToLower()) //converts user input and scripture to lowercase for versitility
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect");
                    }
                    break;
                }
            }
        }
    }
}