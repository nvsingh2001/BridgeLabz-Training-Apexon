namespace LINQ.Models;

public class Order
{
    public int OrderId { get; set; }
    public int EmployeeId { get; set; }
    public string Product { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime OrderDate { get; set; }
}