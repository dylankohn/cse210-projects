using System.IO;

public class BaseClass
{
    public virtual void Process()
    {
        Console.WriteLine("Processing Data...");
    }
    public void SaveDataToCsv(
        Budgeting budgeting,
        ExpenseTracking expenseTracking,
        IncomeTracking incomeTracking,
        DebtManager debtManager,
        Investing investing,
        Reminders reminders,
        GoalSetting goalSetting,
        AccountCenter accountCenter
    )
    {
        using (StreamWriter writer = new StreamWriter("data.csv"))
        {
            writer.WriteLine("Category,Details");
            writer.WriteLine($"Budget,{budgeting.GetRemainingBudget()}");
            writer.WriteLine($"Expenses,{string.Join("|", expenseTracking.GetExpenses())}");
            writer.WriteLine($"Income,{string.Join("|", incomeTracking.GetTotalIncome())}");
            writer.WriteLine($"Debts,{debtManager.GetTotalDebt()}");
            writer.WriteLine($"Investments,{investing.GetTotalInvestments()}");
            writer.WriteLine($"Reminders,{string.Join("|", reminders.GetReminders())}");
            writer.WriteLine($"Goals,{string.Join("|", goalSetting.GetGoals())}");
            writer.WriteLine($"Subscriptions,{string.Join("|", accountCenter.GetAccounts())}");
        }
    }

    public void LoadDataFromCsv(
        Budgeting budgeting,
        ExpenseTracking expenseTracking,
        IncomeTracking incomeTracking,
        DebtManager debtManager,
        Investing investing,
        Reminders reminders,
        GoalSetting goalSetting,
        AccountCenter accountCenter
    )
    {
        string fileName = "data.csv";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found. Please check the file name and try again.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length < 2) continue; // Skip invalid lines

            string category = parts[0].Trim();
            string details = parts[1].Trim();

            Console.WriteLine($"Reading category: {category}, details: {details}");  // Debugging line

            switch (category)
            {
                case "Budget":
                    if (decimal.TryParse(details, out var budget))
                    {
                        budgeting.SetBudget(budget);
                    }
                    break;

                case "Expenses":
                    string[] expenses = details.Split('|');
                    foreach (string expense in expenses)
                    {
                        if (decimal.TryParse(expense, out var expenseValue))
                        {
                            expenseTracking.AddExpense(expenseValue);
                        }
                    }
                    break;

                case "Income":
                    string[] incomes = details.Split('|');
                    foreach (string income in incomes)
                    {
                        if (decimal.TryParse(income, out var incomeValue))
                        {
                            incomeTracking.AddIncome(incomeValue);
                        }
                    }
                    break;

                case "Debts":
                    if (decimal.TryParse(details, out var debt))
                    {
                        debtManager.AddDebt(debt);
                    }
                    break;

                case "Investments":
                    string[] investments = details.Split('|');
                    foreach (string investment in investments)
                    {
                        if (decimal.TryParse(investment, out var investmentValue))
                        {
                            investing.AddInvestment(investmentValue);
                        }
                    }
                    break;

                case "Reminders":
                    string[] remindersArray = details.Split('|');
                    foreach (string reminder in remindersArray)
                    {
                        reminders.AddReminder(reminder);
                    }
                    break;

                case "Goals":
                    string[] goals = details.Split('|');
                    foreach (string goal in goals)
                    {
                        goalSetting.SetGoal(goal);
                    }
                    break;

                case "Subscriptions":
                    string[] subscriptions = details.Split('|');
                    foreach (string subscription in subscriptions)
                    {
                        accountCenter.AddAccount(subscription);
                    }
                    break;

                default:
                    Console.WriteLine($"Unknown category: {category}. Skipping.");
                    break;
            }
        }

        Console.WriteLine("Data successfully loaded.");
    }

}