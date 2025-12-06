namespace OOP.Encapsulation;

public class BankAccount
{
    private double _balance;
    public long Id { get;}

    public BankAccount(long id)
    {
        this.Id = id;
        this.Balance = 0;
    }

    private double Balance
    {
        get => _balance; 
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Amount cannot be negative");
                return;
            }
            _balance = value;
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposit amount: {amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }
        Balance -= amount;
        Console.WriteLine($"Withdrawal amount: {amount}");
    }
}