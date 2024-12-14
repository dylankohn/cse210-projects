using System;
using System.IO;

public class Budgeting : BaseClass
{
    private decimal _remainingBudget;

    public override void Process()
    {
        Console.WriteLine("Processing Budgeting...");
    }

    public void SetBudget(decimal amount)
    {
        _remainingBudget = amount;
    }

    public decimal GetRemainingBudget()
    {
        return _remainingBudget;
    }

    public void SaveBudgetToCsv(string filePath)
    {
        try
        {

            bool fileExists = File.Exists(filePath);

            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {

                if (!fileExists)
                {
                    writer.WriteLine("Date,RemainingBudget");
                }

                string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                writer.WriteLine($"{currentDate},{_remainingBudget}");
            }

            Console.WriteLine("Budget saved to CSV successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the budget: {ex.Message}");
        }
    }
}
