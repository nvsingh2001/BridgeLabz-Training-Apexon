namespace collections.HashSets;

public class Person(int id, string name)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;

    public override bool Equals(object? obj)
    {
        return obj is Person persons && Id == persons.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }

    public override string ToString()
    {
        return $"{id} {Name}";
    }
}