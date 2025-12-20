namespace LINQ;

public class Employee(int id, string name, string department, decimal salary, DateTime joiningDate)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Department { get; set; } = department;
    public decimal Salary { get; set; } = salary;
    public DateTime JoiningDate { get; set; }  = joiningDate;

    public override string ToString()
    {
        return $"{Id} -  {Name} ({Department}), Salary: {Salary:C}, JoiningDate: {JoiningDate}";
    }
}