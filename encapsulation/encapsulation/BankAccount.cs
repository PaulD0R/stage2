class BankAccount
{
    private int _balance;
    private string _owner;

    public BankAccount(string owner, int balance) {_balance = balance; _owner = owner;}

    public int Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public string Owner
    {
        get { return _owner; }
    }
    public void replenishment(int sum)
    {
        _balance += sum;
    }

    public void writeOff(int sum)
    {
        _balance -= sum;
    }
}
