class Program
{
    static void Main(string[] args)
    {
        BaseClass[] components = new BaseClass[]
        {
            new Budgeting(),
            new ExpenseTracking(),
            new IncomeTracking(),
            new DebtManager(),
            new Investing(),
            new Reminders(),
            new GoalSetting(),
            new AccountCenter()
        };

        // Polymorphic processing
        foreach (var component in components)
        {
            component.Process();
        }

        // Example specific usage
        var budgeting = new Budgeting();
        budgeting.SetBudget(500m);
        System.Console.WriteLine($"Remaining Budget: {budgeting.GetRemainingBudget()}");

        var expenseTracking = new ExpenseTracking();
        expenseTracking.AddExpense(100m);
        System.Console.WriteLine($"Expenses: {string.Join(", ", expenseTracking.GetExpenses())}");
    }
}
