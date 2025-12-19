namespace collections.HashSets;

public class PersonalManager
{
    public static readonly HashSet<Person> Persons = new HashSet<Person>();

    public static void Display()
    {
        foreach(var person in Persons)
        {
            Console.WriteLine(person);
        }
    }
    
    public static void  Add(Person person)
    {
        Persons.Add(person);
    }
    
    public static void Remove(Person person)
    {
        Persons.Remove(person);
    }
}