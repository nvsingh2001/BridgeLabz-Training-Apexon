namespace LINQ.LambdaExpressions;

public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{RollNo} {Name}";
    }
}