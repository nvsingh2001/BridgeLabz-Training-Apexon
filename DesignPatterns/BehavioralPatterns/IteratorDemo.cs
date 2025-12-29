namespace DesignPatterns.BehavioralPatterns;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

public class IteratorDemo
{
    public static void Run()
    {
        ConcreteAggregate aggregate = new ConcreteAggregate();
        aggregate[0] = "Item A";
        aggregate[1] = "Item B";
        aggregate[2] = "Item C";
        aggregate[3] = "Item D";
        
        // Create Iteraotr and provide aggregate
        Iterator iterator = aggregate.CreateIterator();
        
        WriteLine("Iterating over collection: ");
        
        object item = iterator.First();

        while (item != null)
        {
            WriteLine(item);
            item = iterator.Next();
        }
    }
}

/// <summary>
/// The 'Aggregate' abstract class
/// </summary>
public abstract class Aggregate
{
    public abstract Iterator CreateIterator();
}

/// <summary>
/// The 'ConcreteAggregate' class
/// </summary>
public class ConcreteAggregate : Aggregate
{
    List<object> items = new List<object>();

    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }
    
    // Get item count
    public int Count
    {
        get { return items.Count; }
    }
    
    // Indexer

    public object this[int index]
    {
        get { return items[index]; }
        set { items.Insert(index, value); }
    }
}

/// <summary>
/// The 'Iterator' abstract class
/// </summary>
public abstract class Iterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}

public class ConcreteIterator : Iterator
{
    private ConcreteAggregate aggregate;
    private int current = 0;
    
    // Constructor

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }
    
    // Gets first iteration item
    public override object First()
    {
        return aggregate[0];
    }
    
    // Get next iteration item
    public override object Next()
    {
        object ret = null!;
        if (current < aggregate.Count - 1)
        {
            ret = aggregate[++current];
        }

        return ret;
    }
    
    // Gets current iteration item

    public override object CurrentItem()
    {
        return aggregate[current];
    }
    
    //Gets whether iterations are complete

    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }
}