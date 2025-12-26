namespace LINQ.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Role { get; set; }
    public decimal Salary { get; set; }
    public int Age { get; set; }
    public DateTime JoinDate { get; set; }
    public bool IsActive { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Department} {Role} {Salary} {Age} {JoinDate} {IsActive}";
    }
}