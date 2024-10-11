using System;
using System.Security.Cryptography.X509Certificates;

class Journal
{
    
    public List<Entry> _entryList = new List<Entry>();
    public void displayEntry()
    {
        foreach (var entries in _entryList)
        {
            Console.WriteLine($"{entries._EntryDate}: {entries._EntryContent}");
            
        }
    }
    public void saveData() {

        foreach (var entry in _entryList)
        {
            string saveEntry = $"Prompt: {entry._EntryPrompt}\n{entry._EntryDate}: {entry._EntryContent}\n";
            SaveEntryToFile(saveEntry);
        }
    }
    
     public void SaveEntryToFile(string entry)
    {
        string filePath = "journal.txt"; 

        using (StreamWriter outputFile = new StreamWriter(filePath, true))
        {
            outputFile.WriteLine(entry);
        }
        Console.WriteLine("Saved to Journal");
        
    }
    
    public void DisplayEntries()
    {
       
        string filePath = "journal.txt";
        // Open the file using StreamReader and read it line by line
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);  // Display each line in the console
            }
        }
    }

}