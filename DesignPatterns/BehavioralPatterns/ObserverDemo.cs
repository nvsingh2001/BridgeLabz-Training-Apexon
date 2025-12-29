using System.Security.Principal;

namespace DesignPatterns.BehavioralPatterns;
using static System.Console;

public class ObserverDemo
{
    public static void Run()
    {
        // Create IBM stock and attach investors
        var ibm = new IBM(120.00);
        
        // Attach 'listeners', i.e. investors
        ibm.Attach(new Investor{ Name = "Sorros"});
        ibm.Attach(new Investor{ Name = "Berkshire"});
        
        // Fluctuating prices will notify listening investors
        ibm.Price = 120.00;
        ibm.Price = 121.00;
        ibm.Price = 120.50;
        ibm.Price = 120.75;

        ReadKey();
    }
}

// Custom event arguments
public class ChangeEventArgs : EventArgs
{
    // Gets or sets symbol
    public string Symbol { get; set; }
    
    // Gets or sets price
    public double Price { get; set; }
}

/// <summary>
/// The 'ConcreteObserver' class
/// </summary>
public interface IInvestor
{
    void Update(object sender, ChangeEventArgs e);
}

/// <summary>
/// The 'Subject' abstract class
/// </summary>
public abstract class Stock(string symbol, double price)
{
    protected string symbol = symbol;
    protected double price =  price;

    // Event
    public event EventHandler<ChangeEventArgs> Change = null!;
    
    // Invoke the Change event
    public virtual void OnChange(ChangeEventArgs e)
    {
        Change?.Invoke(this, e);
    }
    
    // Invoke the chnage event 
    public void Attach(IInvestor investor)
    {
        Change += investor.Update;
    }

    public void Detach(IInvestor investor)
    {
        Change -= investor.Update;
    }
    
    // Gets or Sets the price
    public double Price
    {
        get => price;
        set
        {
            if (!price.Equals(value))
            {
                price = value;
                OnChange(new ChangeEventArgs { Symbol = symbol, Price = price });
                WriteLine("");
            }
        }
    }
}

/// <summary>
/// The 'ConcreteSubject' class
/// </summary>
/// <param name="price"></param>
public class IBM(double price) : Stock("IBM", price)
{
}

/// <summary>
/// The 'ConcreteObserver' class
/// </summary>
public class Investor: IInvestor
{
    // Gets or sets the investor name
    public string Name { get; set; } = null!;

    // Gets or sets the stock
    public Stock Stock { get; set; } = null!;

    public void Update(object sender, ChangeEventArgs e)
    {
        WriteLine($"Notified {Name} of {e.Symbol}'s change to {e.Price:C}");
    }
}