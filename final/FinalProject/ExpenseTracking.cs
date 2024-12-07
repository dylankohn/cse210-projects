public class ExpenseTracking : BaseClass
{
    private decimal[] _expenses = new decimal[100];
    private int _expenseCount = 0;

    public override void Process()
    {
        Console.WriteLine("Processing Expense Tracking...");
    }

    public void AddExpense(decimal expense)
    {
        if (_expenseCount < _expenses.Length)
        {
            _expenses[_expenseCount++] = expense;
        }
        else
        {
            Console.WriteLine("Expense list is full.");
        }
    }

    public decimal[] GetExpenses()
    {
        decimal[] result = new decimal[_expenseCount];
        for (int i = 0; i < _expenseCount; i++)
        {
            result[i] = _expenses[i];
        }
        return result;
    }
}
