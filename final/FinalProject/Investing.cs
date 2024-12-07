public class Investing : BaseClass
{
    private decimal[] _investments = new decimal[100];
    private int _investmentCount = 0;

    public override void Process()
    {
        Console.WriteLine("Processing Investing...");
    }

    public void AddInvestment(decimal investment)
    {
        if (_investmentCount < _investments.Length)
        {
            _investments[_investmentCount++] = investment;
        }
        else
        {
            Console.WriteLine("Investment list is full.");
        }
    }

    public decimal GetTotalInvestments()
    {
        decimal total = 0;
        for (int i = 0; i < _investmentCount; i++)
        {
            total += _investments[i];
        }
        return total;
    }
}
