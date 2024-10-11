using System;
using System.IO;
public class Entry
{
    public string _EntryContent;
    public string _EntryDate;
    public string _EntryPrompt;
    public Entry()
    {
        
    }
    public Entry(string entryText, string entryDate, string entryPrompt)
    {
        _EntryContent = entryText;
        _EntryDate = entryDate;
        _EntryPrompt = entryPrompt;
    }

    

}