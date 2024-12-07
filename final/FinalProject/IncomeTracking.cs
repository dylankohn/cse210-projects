public class IncomeTracking : BaseClass
{
    private decimal[] _income = new decimal[100];
    private int _incomeCount = 0;

    public override void Process()
    {
        Console.WriteLine("Processing Income Tracking...");
    }

    public void AddIncome(decimal income)
    {
        if (_incomeCount < _income.Length)
        {
            _income[_incomeCount++] = income;
        }
        else
        {
            Console.WriteLine("Income list is full.");
        }
    }

    public decimal GetTotalIncome()
    {
        decimal total = 0;
        for (int i = 0; i < _incomeCount; i++)
        {
            total += _income[i];
        }
        return total;
    }
}
