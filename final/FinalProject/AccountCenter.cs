public class AccountCenter : BaseClass
{
    private string[] _accounts = new string[100];
    private int _accountCount = 0;

    public override void Process()
    {
        Console.WriteLine("Processing Account Center...");
    }

    public void AddAccount(string account)
    {
        if (_accountCount < _accounts.Length)
        {
            _accounts[_accountCount++] = account;
        }
        else
        {
            Console.WriteLine("Account list is full.");
        }
    }

    public string[] GetAccounts()
    {
        string[] result = new string[_accountCount];
        for (int i = 0; i < _accountCount; i++)
        {
            result[i] = _accounts[i];
        }
        return result;
    }
}
