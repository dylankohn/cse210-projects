using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        BaseClass baseClass = new BaseClass();
        var budgeting = new Budgeting();
        var expenseTracking = new ExpenseTracking();
        var incomeTracking = new IncomeTracking();
        var debtManager = new DebtManager();
        var investing = new Investing();
        var reminders = new Reminders();
        var goalSetting = new GoalSetting();
        var accountCenter = new AccountCenter();

        string userInput = "";
        decimal totalSpent = 0;
        decimal goalAmount = 0;

        while (userInput != "11")
        {
            Console.WriteLine($"Remaining Budget: {budgeting.GetRemainingBudget()}");
            Console.WriteLine($"Total Expenses: {totalSpent}");
            Console.WriteLine($"Total Income: {incomeTracking.GetTotalIncome()}");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Set Budget");
            Console.WriteLine("  2. Add Expense");
            Console.WriteLine("  3. Add Income");
            Console.WriteLine("  4. Add Debts");
            Console.WriteLine("  5. Add Investments");
            Console.WriteLine("  6. Add Reminder");
            Console.WriteLine("  7. Set Goal");
            Console.WriteLine("  8. Manage Subscriptions");
            Console.WriteLine("  9. Save Data");
            Console.WriteLine(" 10. Load Data");
            Console.WriteLine(" 11. Exit");

            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Write("Enter monthly budget amount: ");
                    budgeting.SetBudget(decimal.Parse(Console.ReadLine()));
                    budgeting.SaveBudgetToCsv("budget.csv");
                    Console.Clear();
                    break;

                case "2":
                    Console.Write("Enter expense amount: ");
                    decimal expense = decimal.Parse(Console.ReadLine());
                    expenseTracking.AddExpense(expense);
                    totalSpent += expense;
                    budgeting.SetBudget(budgeting.GetRemainingBudget() - expense);

                    if (totalSpent % 500 == 0)
                    {
                        reminders.AddReminder($"You've spent another $500. Total Spent: {totalSpent}");
                    }

                    Console.Clear();
                    break;

                case "3":
                    Console.Write("Would you like to pay tithing? (y/n): ");
                    string tithing = Console.ReadLine();
                    if (tithing == "y")
                    {
                        Console.Write("Enter income amount: ");
                        incomeTracking.AddIncomeTithing(decimal.Parse(Console.ReadLine()));
                    }
                    else if (tithing == "n")
                    {
                        Console.Write("Enter income amount: ");
                        incomeTracking.AddIncome(decimal.Parse(Console.ReadLine()));
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice.");
                    }
                    Console.Clear();
                    break;

                case "4":
                    Console.Write("Enter debt amount: ");
                    debtManager.AddDebt(decimal.Parse(Console.ReadLine()));
                    Console.Clear();
                    break;

                case "5":
                    Console.Write("Enter investment amount: ");
                    decimal investment = decimal.Parse(Console.ReadLine());
                    investing.AddInvestment(investment);
                    budgeting.SetBudget(budgeting.GetRemainingBudget() - investment);
                    Console.Clear();
                    break;

                case "6":
                    Console.Write("Enter reminder message: ");
                    reminders.AddReminder(Console.ReadLine());
                    Console.Clear();
                    break;

                case "7":
                    Console.Write("Set monthly goal amount: ");
                    goalAmount = decimal.Parse(Console.ReadLine());
                    goalSetting.SetGoal($"Earn {goalAmount} this month.");
                    Console.Clear();
                    break;

                case "8":
                    Console.Write("Enter subscription name: ");
                    string subscription = Console.ReadLine();
                    accountCenter.AddAccount(subscription);
                    Console.Clear();
                    break;

                case "9":
                    baseClass.SaveDataToCsv(
                        budgeting, 
                        expenseTracking, 
                        incomeTracking, 
                        debtManager, 
                        investing, 
                        reminders, 
                        goalSetting, 
                        accountCenter
                    );
                    Console.WriteLine("Data saved to data.csv.");
                    Console.Clear();
                    break;
                
                case "10":
                    Console.Clear();
                    Thread.Sleep(300);
                    baseClass.Process();
                    Thread.Sleep(300);
                    budgeting.Process();
                    Thread.Sleep(300);
                    expenseTracking.Process();
                    Thread.Sleep(300);
                    incomeTracking.Process();
                    Thread.Sleep(300);
                    debtManager.Process();
                    Thread.Sleep(300);
                    investing.Process();
                    Thread.Sleep(300);
                    reminders.Process();
                    Thread.Sleep(300);
                    goalSetting.Process();
                    Thread.Sleep(300);
                    accountCenter.Process();
                    Thread.Sleep(300);
                    Console.Clear();
                    baseClass.LoadDataFromCsv(
                        budgeting,
                        expenseTracking,
                        incomeTracking,
                        debtManager,
                        investing,
                        reminders,
                        goalSetting,
                        accountCenter
                    );
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;

                case "11":
                    Console.Clear();
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.Write("Reminders:");
            foreach (var reminder in reminders.GetReminders())
            {
                Console.WriteLine(reminder);
            }

            Console.WriteLine();
            Console.WriteLine("Goals:");
            foreach (var goal in goalSetting.GetGoals())
            {
                Console.Write(goal);
            }

            Console.WriteLine();
            Console.Write("Debts: ");
            Console.WriteLine(debtManager.GetTotalDebt());

            Console.WriteLine();
            Console.Write("Investments: ");
            Console.WriteLine(investing.GetTotalInvestments());

            Console.WriteLine();
            Console.Write("Subscriptions:");
            foreach (var account in accountCenter.GetAccounts())
            {
                Console.Write(account);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Budget: ");
            Console.WriteLine(budgeting.GetRemainingBudget());
        }
    }
}

