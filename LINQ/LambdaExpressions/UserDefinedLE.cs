namespace LINQ.LambdaExpressions;

public class UserDefinedLE
{
    public static void Run()
    {
        List<Student> students = new List<Student>()
        {
            new Student { RollNo = 1, Name = "Naman" },
            new Student { RollNo = 2, Name = "Ankit" },
            new Student { RollNo = 3, Name = "Gourav" },
            new Student { RollNo = 4, Name = "Yeshu" },
            new Student { RollNo = 5, Name = "Prashant" },
        };
        
        var sortedList = students.OrderBy(student => student.Name).ToList();
        
        Console.WriteLine(string.Join(Environment.NewLine, sortedList));
    }
}