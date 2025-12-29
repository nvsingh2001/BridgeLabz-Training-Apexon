using System.Runtime.InteropServices.ComTypes;

namespace DesignPatterns;

using static System.Console;
using System.Text.Json;
using System.Collections.Generic;

/// <summary>
/// Prototype Design Patten
/// </summary>
public class PrototypeDemo
{
    public void Run()
    {
        var manager = new ColorManager();
        
        // Initialize with standard colors
        manager[ColorType.Red] = new Color {Red = 255, Blue = 0, Green = 0};
        manager[ColorType.Green] = new Color { Red = 0, Blue = 0, Green = 255 };
        manager[ColorType.Blue] = new Color { Red = 0, Blue = 255, Green = 0 };
        
        // User adds personalized colors
        manager[ColorType.Angry] = new Color { Red = 255, Blue = 54, Green = 0 };
        manager[ColorType.Peace] = new Color { Red = 128, Blue = 211, Green = 128 };
        manager[ColorType.Flame] = new Color { Red = 211, Blue = 34, Green = 20 };
        
        // User uses selected colors
        _ = manager[ColorType.Red].Clone();
        _ = manager[ColorType.Peace].Clone();
        _ = manager[ColorType.Flame].Clone(false); // Deep Copy
        
        // Wait for user
        ReadKey();
    }
}

/// <summary>
/// ICloneable ins not supported in .NET Core
/// </summary>
public interface ICloneableObject
{
    object Clone();
}

public class Color : ICloneable
{
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }

    // Returns a shallow or a deep copy
    public object Clone(bool shallow)
    {
        return shallow ? Clone() : DeepCopy();
    }

    public object Clone()
    {
        WriteLine("Shallow copy of color RGB: {0,3}, {1,3}, {2,3}", Red, Green, Blue);
        
        return MemberwiseClone();
    }
    
    // Creates a deep copy
    public object? DeepCopy()
    {
        // Use serialized to create a deep copy
        var serialized = JsonSerializer.Serialize(this);
        var copy = JsonSerializer.Deserialize<Color>(serialized);

        if (copy is not null)
        {
            WriteLine("*Deep* copy of Color RGB:{0,3},{1,3},{2,3}",
                (copy as Color).Red , (copy as Color).Green, (copy as Color).Blue
                );
        }
        
        return copy;
    }
}
/// <summary>
/// Color type enumerations
/// </summary>
public enum ColorType
{
    Red,
    Green,
    Blue,
    Angry,
    Peace,
    Flame
}
    
/// <summary>
/// Type-Safe Prototype manager
/// </summary>
public record ColorManager
{
    private readonly Dictionary<ColorType, Color> _colors = [];
        
    // Gets or sets color
    public Color this[ColorType type]
    {
        get => _colors[type];
        set => _colors.Add(type, value);
    }
}

