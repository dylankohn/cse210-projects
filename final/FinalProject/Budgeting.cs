public class Budgeting : BaseClass
{
    private decimal _totalBudget;
    private decimal _remainingBudget;

    public override void Process()
    {
        Console.WriteLine("Processing Budgeting...");
    }

    public void SetBudget(decimal amount)
    {
        _totalBudget = amount;
        _remainingBudget = amount;
    }

    public decimal GetRemainingBudget()
    {
        return _remainingBudget;
    }
}
