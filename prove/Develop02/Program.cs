using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static Entry entry = new Entry();
    public static Journal myJournal = new Journal();
    
    static void Main(string[] args)
    {
        int menuInput = -1;
        while (menuInput != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string menuSelect = Console.ReadLine();
            menuInput = int.Parse(menuSelect);

            if (menuInput == 1){
                Console.Write("Prompt: ");
                Prompt myPrompt = new Prompt();
                string promptContent = myPrompt.generatePrompt();
                Console.WriteLine(promptContent);
        
                DateTime theCurrentTime = DateTime.Now;
                string dateInput = theCurrentTime.ToShortDateString();

                string input;
                Console.Write("Write: ");
                input = Console.ReadLine();
                myJournal._entryList.Add(new Entry(input, dateInput, promptContent));
    
            }

            if(menuInput == 2){
                myJournal.displayEntry();
            }

            if(menuInput == 3){
                myJournal.DisplayEntries();
            }

            if(menuInput == 4){
                myJournal.saveData();
            }
            
        }   
    }
}