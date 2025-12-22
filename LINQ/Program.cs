// using LINQ.LinqOperators;
// using LINQ.MethodAndQuerySyntax;

namespace LINQ;

class Program
{
    static void Main()
    {
        // MethodSyntax.Run();
        // QuerySyntax.Run();
        // SelectOperator.main();
        // SelectManyOperators.Run();
        // WhereOperator.Run();
        // PartitioningQueryOperators.Run();
        // SkipAndSkipWhile.Run();
        // SetOperator.Run();
        
        var employees = new List<Employee>()
        {
            new Employee(1, "Naman", "IT", 30000, new DateTime(2025, 11, 1)),
            new Employee(3, "Amit", "HR", 22000, new DateTime(2022, 6, 15)),
            new Employee(4, "Priya", "Finance", 28000, new DateTime(2023, 9, 10)),
            new Employee(5, "Rohit", "IT", 35000, new DateTime(2021, 11, 5)),
            new Employee(6, "Sneha", "Marketing", 24000, new DateTime(2024, 1, 20)),
            new Employee(7, "Karan", "Operations", 26000, new DateTime(2022, 3, 30)),
            new Employee(8, "Neha", "HR", 23000, new DateTime(2023, 7, 18)),
            new Employee(9, "Arjun", "Finance", 32000, new DateTime(2020, 10, 12)),
            new Employee(10, "Pooja", "IT", 40000, new DateTime(2019, 5, 25)),
            new Employee(2, "Gourav", "IT", 25000, new DateTime(2024, 3, 1)),
        };
        
        // Console.WriteLine(string.Join(Environment.NewLine, employees));
        // // How can you use a lambda expression in LINQ to filter employees who joined in the last six months and belong to a specific department?
        // var result1 = employees.Where(L => L.JoiningDate >= DateTime.Now.AddMonths(-6) 
        //                                    && L.Department == "IT");
        // Console.WriteLine();
        // Console.WriteLine("Results 1: employees who joined in the last six months and belong to a specific department?");
        // Console.WriteLine(string.Join("\n", result1));
        //
        // // How do you use a lambda expression with the LINQ OrderBy method to sort a list of strings based on their length in ascending order?
        // Console.WriteLine();
        // Console.WriteLine("Results 2: sort a list of strings based on their length in ascending order?");
        // Console.WriteLine(string.Join(Environment.NewLine, employees.OrderBy(emp => emp.Name.Length)));
        
        List<Product> products = new()
        {
            new Product(1, "Laptop", "Electronics", 75000),
            new Product(2, "Smartphone", "Electronics", 45000),
            new Product(3, "Headphones", "Electronics", 3000),

            new Product(4, "Office Chair", "Furniture", 12000),
            new Product(5, "Desk", "Furniture", 18000),
            new Product(6, "Bookshelf", "Furniture", 9000),

            new Product(7, "T-Shirt", "Clothing", 1200),
            new Product(8, "Jeans", "Clothing", 2500),
            new Product(9, "Jacket", "Clothing", 5000),

            new Product(10, "Coffee Maker", "Appliances", 4000),
            new Product(11, "Microwave", "Appliances", 15000),
            new Product(12, "Toaster", "Appliances", 2500)
        };
        
        Console.WriteLine(string.Join(Environment.NewLine, products));
        
        // How can LINQ be used to group a list of products by category and calculate the average price for each category?
        var result3 = products.GroupBy(product => product.Category).Select(group => new
        {
            Category = group.Key,
            AveragePrice = group.Average(product => product.Price),
        });
        Console.WriteLine();
        Console.WriteLine("Result 3: ");
        Console.WriteLine(string.Join(Environment.NewLine, result3));
        
        // How do you find employees whose salary is greater than the average salary using LINQ? 
        var result4 = employees.Where(emp => emp.Salary > employees.Average(employee => employee.Salary));
        
        Console.WriteLine();
        Console.WriteLine("Result 4: employees whose salary is greater than the average salary");
        Console.WriteLine(string.Join(Environment.NewLine, result4));
        
        // How can you retrieve the top three highest-paid employees using LINQ?
        var result5 = employees.OrderByDescending(emp => emp.Salary).Take(3);
        Console.WriteLine();
        Console.WriteLine("Result 5: top three highest-paid employees");
        Console.WriteLine(string.Join(Environment.NewLine, result5));
        
        //How do you count the number of employees in each department using LINQ?
        var result6 = employees.GroupBy(emp => emp.Department).Select(group => new
            {
                Department = group.Key,
                Count = group.Count()
            }
        );
        
        Console.WriteLine();
        Console.WriteLine("Result 6: number of employees in each department");
        Console.WriteLine(string.Join(Environment.NewLine, result6));
        
        // How can you use LINQ to convert all employee names to uppercase 
        var result7 = employees.Select(emp => emp.Name.ToUpper()).ToList();
        Console.WriteLine();
        Console.WriteLine("Result 7: convert all employee names to uppercase");
        Console.WriteLine(string.Join(Environment.NewLine, result7));
        
        // How do you filter products whose prices fall between a specific range using LINQ?
        var result8 = products.Where(product => product.Price is > 5000 and < 20000).ToList();
        Console.WriteLine();
        Console.WriteLine("Result 8: products whose prices fall between a specific range");
        Console.WriteLine(string.Join(Environment.NewLine, result8));
        
        // How can you perform an inner join between Employees and Departments using LINQ and lambda expressions?
        Console.WriteLine();
        Console.WriteLine("Result 9: inner join between Employees and Departments");
        var departments = new[]
        {
            new { DeptName = "IT", Location = "Building A" },
            new { DeptName = "HR", Location = "Building B" },
            new { DeptName = "Finance", Location = "Building C" }
        };
        var joined = employees
            .Join(departments,
                emp => emp.Department,
                dept => dept.DeptName,
                (emp, dept) => new { emp.Name, emp.Salary, dept.DeptName, dept.Location});
        foreach (var item in joined)
            Console.WriteLine($"{item.Name} ({item.Salary:C}) works in {item.DeptName} located at {item.Location}");
    }
}