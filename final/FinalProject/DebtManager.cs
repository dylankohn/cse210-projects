public class DebtManager : BaseClass
{
    private decimal[] _debts = new decimal[100];
    private int _debtCount = 0;

    public override void Process()
    {
        Console.WriteLine("Processing Debt Manager...");
    }

    public void AddDebt(decimal debt)
    {
        if (_debtCount < _debts.Length)
        {
            _debts[_debtCount++] = debt;
        }
        else
        {
            Console.WriteLine("Debt list is full.");
        }
    }

    public decimal GetTotalDebt()
    {
        decimal total = 0;
        for (int i = 0; i < _debtCount; i++)
        {
            total += _debts[i];
        }
        return total;
    }
}
