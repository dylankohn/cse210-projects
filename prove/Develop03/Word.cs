using System;
using System.Collections.Generic;

class Word
{
    static Scripture changeScripture = new Scripture();
    string originalScriptureContent = changeScripture.DisplayScripture();
    private List<int> blankedWords = new List<int>();
    private Random random = new Random();

    public string removeWord()
    {
        string[] words = originalScriptureContent.Split(' '); //takes the scripture and turns in to array of words

        int remainingWordsToBlank = Math.Min(3, words.Length - blankedWords.Count); //checks how many words are left

        if (remainingWordsToBlank <= 0)
        {
            return string.Join(" ", words);
        }

        //blanks three words randomly
        for (int i = 0; i < remainingWordsToBlank; i++)
        {
            int wordIndex = randomWordIndex(words.Length);
            words[wordIndex] = "___";
        }
        
        originalScriptureContent = string.Join(" ", words); //adds blanked words to original scripture
        return originalScriptureContent;
    }

    //to generate random indexes to assign to words
    private int randomWordIndex(int wordCount)
    {
        int index;
        do
        {
            index = random.Next(wordCount);
        } while (blankedWords.Contains(index));

        blankedWords.Add(index);
        return index;
    }
}
