namespace DesignPatterns;
using static System.Console;

/// <summary>
/// The'AbstractProductA' interface
/// </summary>

public interface IHerbivore
{
}

/// <summary>
/// The 'AbstractProductB' interface
/// </summary>

public interface ICarnivore
{
    void Eat(IHerbivore herbivore);
}

/// <summary>
/// The 'ProductA1 class
/// </summary>
public class Wildebeest : IHerbivore
{
}

/// <summary>
/// The 'ProductB1' class
/// </summary>
public class Lion : ICarnivore
{
    // Eat Wildebeest
    public void Eat(IHerbivore herbivore) => WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
}

/// <summary>
/// The 'ProductA2' Class
/// </summary>
public class Bison : IHerbivore
{
}

/// <summary>
/// The'ProductA2' class
/// </summary>
public class Wolf : ICarnivore
{
    //Eat Bison
    public void Eat(IHerbivore herbivore) => WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
}

/// <summary>
/// The 'Client' interface
/// </summary>
public interface IAnimalWorld
{
    void RunFoodChain();
}

/// <summary>
/// The 'AbstractFactory' interface.
/// </summary>
public interface IContinentFactory
{
    IHerbivore CreateHerbivore();
    ICarnivore CreateCarnivore();
}

/// <summary>
/// The 'ConcreteFactory1' class.
/// </summary>
public class Africa : IContinentFactory
{
    public IHerbivore CreateHerbivore() => new Wildebeest();
    public ICarnivore CreateCarnivore() => new Lion();
}

/// <summary>
/// The 'AbstractProductB' interface 
/// </summary>
public class America : IContinentFactory
{
    public IHerbivore CreateHerbivore() => new Bison();
    
    public ICarnivore CreateCarnivore() => new Wolf();
}

/// <summary>
/// The 'Client' Class
/// </summary>

public class AnimalWorld<T> : IAnimalWorld where T: IContinentFactory, new()
{
    private readonly IHerbivore herbivore;
    private readonly ICarnivore carnivore;

    public AnimalWorld() {
        var factory = new T();
        
        herbivore = factory.CreateHerbivore();
        carnivore = factory.CreateCarnivore();
    }
    
    public void RunFoodChain(){
        carnivore.Eat(herbivore);
    }
}
    
    
public class AbstractFactoryDemo
{
    public void Run()
    {
        var africa = new AnimalWorld<Africa>();
        africa.RunFoodChain();
        
        var america = new AnimalWorld<America>();
        america.RunFoodChain();

        ReadKey();
    }
}