namespace DesignPatterns.StructuralPatterns;
using static System.Console;

public class FacadeDemo
{
    public static void Run()
    {
        // Facade
        var mortgage = new Mortagage();
        
        // Evaluate mortgage eligibility for customer
        var customer = new Customer("Ann McKinsey");
        var eligible =  mortgage.IsEligible(customer, 125000);
        
        var result = eligible ? "Approved" : "Rejected";
        
        WriteLine($"\n{customer.Name} has been {result}");
    }
}

/// <summary>
/// The 'SubsystemClassA' class
/// </summary>
public class Bank
{
    public bool HasSufficientSavings(Customer customer, int amount)
    {
        WriteLine($"Check bank for {customer.Name}");
        return true;
    }
}

/// <summary>
/// the 'subsystemclassb' class
/// </summary>
public class Credit
{
    public bool HasGoodCredit(Customer customer)
    {
        WriteLine($"Check credit for {customer.Name}");
        return true;
    }
}

/// <summary>
/// the 'subsystemclassb' class
/// </summary>
public class Loan
{
    public bool HasNoBadLoans(Customer customer)
    {
        WriteLine($"Check loan for {customer.Name}");
        return true;
    }
}

public class Mortagage
{
    private readonly Bank bank = new ();
    private readonly Loan loan = new ();
    private readonly Credit credit = new ();

    public bool IsEligible(Customer customer, int amount)
    {
        WriteLine($"{customer.Name} applies for {amount:C} loan\n");
        
        // Check creditWorthiness of applicant
       return bank.HasSufficientSavings(customer, amount) 
                   && loan.HasNoBadLoans(customer) 
                   && credit.HasGoodCredit(customer);        
    }
}

/// <summary>
/// Customer Class
/// </summary>
/// <param name="Name"></param>
public record Customer(string Name);