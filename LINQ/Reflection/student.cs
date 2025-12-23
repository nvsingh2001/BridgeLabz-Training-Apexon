namespace LINQ.Reflection;

public class student {
    
    // Properties definition
    public int RollNo
    {
        get;
        set;
    }
    
    public string Name
    {
        get;
        set;
    }

    // No Argument Constructor
    public student()
    {
        RollNo = 0;
        Name = string.Empty;
    }

    // Parameterised Constructor
    public student(int rno, string n)
    {
        RollNo = rno;
        Name = n;
    }

    // Method to Display Student Data
    public void displayData()
    {
        Console.WriteLine("Roll Number : {0}", RollNo);
        Console.WriteLine("Name : {0}", Name);
    }
}

