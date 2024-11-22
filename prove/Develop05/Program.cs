using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        Goal goals = new Goal();

        while (userInput != "6")
        {
            int points = goals.GetPoints();

            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("The Types of Goals are: ");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string selectGoal = Console.ReadLine();

                    switch (selectGoal)
                    {
                        case "1":
                            Simple newSimple = new Simple();
                            newSimple.CreateGoal();
                            goals.AddGoal(newSimple);
                            break;

                        case "2":
                            Eternal newEternal = new Eternal();
                            newEternal.CreateGoal();
                            goals.AddGoal(newEternal);
                            break;

                        case "3":
                            Checklist newChecklist = new Checklist();
                            newChecklist.CreateGoal();
                            goals.AddGoal(newChecklist);
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                    break;
                
                case "2":
                    goals.ListAllGoals();
                    break;
                
                case "3":
                    goals.SaveAllGoals();
                    break;
                
                case "4":
                    goals.LoadAllGoals();
                    break;

                case "5":
                    goals.RecordCompletion();
                    break;
                
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}