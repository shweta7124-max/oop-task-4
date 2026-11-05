
namespace BankApp.Classes;

public class BankAccount
{
    private string name = string.Empty;
    private decimal balance;

    public string Owner { get; set; }
    public string Name
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
            else
                throw new ArgumentException(
                    nameof(value), "Name cannot be empty");
        }
    }

    public decimal Balance
    {
        get => balance;
        set
        {
            if (value >= 0)
                balance = value;
            else
                throw new ArgumentOutOfRangeException(
                    nameof(value), "Balance cannot be negative");
        }
    }

    public bool HasPositiveBalance => balance > 0;
    public BankAccount(string name, string ownerName)
    {
        Name = name;
        Owner = ownerName;
        Balance = 0;
    }

    public BankAccount() : this("Personal", "Unknown")
    {
    }

    public bool Deposit(decimal amount)
    {
        Balance += amount;
        return true;
    }

    public bool Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }

        return false;
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Balance: {Balance}");
    }
}
