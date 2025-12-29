namespace DesignPatterns;
using static System.Console;

/// <summary>
/// Part type enumeration
/// </summary>
public enum PartType
{
    Frame,
    Engine,
    Wheel,
    Door
}

/// <summary>
/// Vehicle Type enumeration
/// </summary>
public enum VehicleType
{
    Car,
    Scooter,
    MotorCycle
}

/// <summary>
/// The 'Product' Class
/// </summary>
/// <param name="vehicleType"></param>

public class Vehicle(VehicleType vehicleType)
{
    private readonly Dictionary<PartType, string> _parts = [];
    private readonly VehicleType vehicleType = vehicleType;

    public string this[PartType key]
    {
        get => _parts[key];
        set => _parts[key] = value;
    }

    public void Show()
    {
        WriteLine("\n---------------------------");
        WriteLine($"Vehicle Type: {vehicleType}");
        WriteLine($" Frame: {this[PartType.Frame]}");
        WriteLine($" Engine: {this[PartType.Engine]}");
        WriteLine($" Wheels: {this[PartType.Wheel]}");
        WriteLine($" Doors: {this[PartType.Door]}");
    }
}

/// <summary>
/// The 'Builder' abstract class
/// </summary>
public abstract class VehicleBuilder(VehicleType vehicleType)
{
    public Vehicle Vehicle { get; private set; } = new Vehicle(vehicleType);

    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
}

/// <summary>
/// The 'ConcreteBuilder1' class
/// </summary>
public class MotorCycleBuilder : VehicleBuilder
{
    public MotorCycleBuilder() : base(VehicleType.MotorCycle)
    {
    }

    public override void BuildFrame() => Vehicle[PartType.Frame] = "MotorCycle Frame";
    public override void BuildEngine() => Vehicle[PartType.Engine] = "500 cc";
    public override void BuildWheels() => Vehicle[PartType.Wheel] = "2";
    public override void BuildDoors() => Vehicle[PartType.Door] = "0";
}

/// <summary>
/// The 'ConcreteBuilder2' Class
/// </summary>
public class CarBuilder : VehicleBuilder
{
    public CarBuilder() : base(VehicleType.Car)
    {
    }
    
    public override void BuildFrame() => Vehicle[PartType.Frame] = "Car Frame";
    public override void BuildEngine() => Vehicle[PartType.Engine] = "2500 cc";
    public override void BuildWheels() => Vehicle[PartType.Wheel] = "4";
    public override void BuildDoors() => Vehicle[PartType.Door] = "4";
}

/// <summary>
/// The 'Product' Class
/// </summary>
public class ScooterBuilder : VehicleBuilder
{
    public ScooterBuilder(): base(VehicleType.Scooter){}
    
    public override void BuildFrame() => Vehicle[PartType.Frame] = "Scooter Frame";
    public override void BuildEngine() => Vehicle[PartType.Engine] = "50 cc";
    public override void BuildWheels() => Vehicle[PartType.Wheel] = "2";
    public override void BuildDoors() => Vehicle[PartType.Door] = "0";
}

/// <summary>
/// The 'Director' Class
/// </summary>
public class Shop
{
    private VehicleBuilder? _builder;
    
    // Builder uses complex series of steps
    public void Construct(VehicleBuilder builder)
    {
        this._builder = builder;
        
        builder.BuildFrame();
        builder.BuildEngine();
        builder.BuildWheels();
        builder.BuildDoors();
    }
    
    public void ShowVehicle()
    {
        _builder?.Vehicle.Show();
    }
}

public class BuilderDemo
{
    public void Run()
    {
        var shop = new Shop();
        
        shop.Construct(new ScooterBuilder());
        shop.ShowVehicle();
        
        shop.Construct(new MotorCycleBuilder());
        shop.ShowVehicle();
        
        shop.Construct(new MotorCycleBuilder());
        shop.ShowVehicle();

        ReadKey();
    }
}

