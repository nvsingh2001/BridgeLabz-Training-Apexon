// using LINQ.LinqOperators;
// using LINQ.MethodAndQuerySyntax;

using System.Diagnostics.Metrics;
using System.Reflection;
using LINQ.Closures;
using LINQ.Delegates;
using LINQ.LambdaExpressions;
using LINQ.Models;

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
        
        // var employees = new List<Employee>()
        // {
        //     new Employee(1, "Naman", "IT", 30000, new DateTime(2025, 11, 1)),
        //     new Employee(3, "Amit", "HR", 22000, new DateTime(2022, 6, 15)),
        //     new Employee(4, "Priya", "Finance", 28000, new DateTime(2023, 9, 10)),
        //     new Employee(5, "Rohit", "IT", 35000, new DateTime(2021, 11, 5)),
        //     new Employee(6, "Sneha", "Marketing", 24000, new DateTime(2024, 1, 20)),
        //     new Employee(7, "Karan", "Operations", 26000, new DateTime(2022, 3, 30)),
        //     new Employee(8, "Neha", "HR", 23000, new DateTime(2023, 7, 18)),
        //     new Employee(9, "Arjun", "Finance", 32000, new DateTime(2020, 10, 12)),
        //     new Employee(10, "Pooja", "IT", 40000, new DateTime(2019, 5, 25)),
        //     new Employee(2, "Gourav", "IT", 25000, new DateTime(2024, 3, 1)),
        // };
        
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
        
        // List<Product> products = new()
        // {
        //     new Product(1, "Laptop", "Electronics", 75000),
        //     new Product(2, "Smartphone", "Electronics", 45000),
        //     new Product(3, "Headphones", "Electronics", 3000),
        //
        //     new Product(4, "Office Chair", "Furniture", 12000),
        //     new Product(5, "Desk", "Furniture", 18000),
        //     new Product(6, "Bookshelf", "Furniture", 9000),
        //
        //     new Product(7, "T-Shirt", "Clothing", 1200),
        //     new Product(8, "Jeans", "Clothing", 2500),
        //     new Product(9, "Jacket", "Clothing", 5000),
        //
        //     new Product(10, "Coffee Maker", "Appliances", 4000),
        //     new Product(11, "Microwave", "Appliances", 15000),
        //     new Product(12, "Toaster", "Appliances", 2500)
        // };
        //
        // Console.WriteLine(string.Join(Environment.NewLine, products));
        //
        // // How can LINQ be used to group a list of products by category and calculate the average price for each category?
        // var result3 = products.GroupBy(product => product.Category).Select(group => new
        // {
        //     Category = group.Key,
        //     AveragePrice = group.Average(product => product.Price),
        // });
        // Console.WriteLine();
        // Console.WriteLine("Result 3: ");
        // Console.WriteLine(string.Join(Environment.NewLine, result3));
        //
        // // How do you find employees whose salary is greater than the average salary using LINQ? 
        // var result4 = employees.Where(emp => emp.Salary > employees.Average(employee => employee.Salary));
        //
        // Console.WriteLine();
        // Console.WriteLine("Result 4: employees whose salary is greater than the average salary");
        // Console.WriteLine(string.Join(Environment.NewLine, result4));
        //
        // // How can you retrieve the top three highest-paid employees using LINQ?
        // var result5 = employees.OrderByDescending(emp => emp.Salary).Take(3);
        // Console.WriteLine();
        // Console.WriteLine("Result 5: top three highest-paid employees");
        // Console.WriteLine(string.Join(Environment.NewLine, result5));
        //
        // //How do you count the number of employees in each department using LINQ?
        // var result6 = employees.GroupBy(emp => emp.Department).Select(group => new
        //     {
        //         Department = group.Key,
        //         Count = group.Count()
        //     }
        // );
        //
        // Console.WriteLine();
        // Console.WriteLine("Result 6: number of employees in each department");
        // Console.WriteLine(string.Join(Environment.NewLine, result6));
        //
        // // How can you use LINQ to convert all employee names to uppercase 
        // var result7 = employees.Select(emp => emp.Name.ToUpper()).ToList();
        // Console.WriteLine();
        // Console.WriteLine("Result 7: convert all employee names to uppercase");
        // Console.WriteLine(string.Join(Environment.NewLine, result7));
        //
        // // How do you filter products whose prices fall between a specific range using LINQ?
        // var result8 = products.Where(product => product.Price is > 5000 and < 20000).ToList();
        // Console.WriteLine();
        // Console.WriteLine("Result 8: products whose prices fall between a specific range");
        // Console.WriteLine(string.Join(Environment.NewLine, result8));
        //
        // // How can you perform an inner join between Employees and Departments using LINQ and lambda expressions?
        // Console.WriteLine();
        // Console.WriteLine("Result 9: inner join between Employees and Departments");
        // var departments = new[]
        // {
        //     new { DeptName = "IT", Location = "Building A" },
        //     new { DeptName = "HR", Location = "Building B" },
        //     new { DeptName = "Finance", Location = "Building C" }
        // };
        // var joined = employees
        //     .Join(departments,
        //         emp => emp.Department,
        //         dept => dept.DeptName,
        //         (emp, dept) => new { emp.Name, emp.Salary, dept.DeptName, dept.Location});
        // foreach (var item in joined)
        //     Console.WriteLine($"{item.Name} ({item.Salary:C}) works in {item.DeptName} located at {item.Location}");

        // DelegatesExample.Run();
        // MultiCastDelegates.Run();
        // ReturnDelegates.Run();

        // LambdaExpressionsDemo.Run();

        // UserDefinedLE.Run();
        
        // Predicates.Run();
        
        // AnonymousMethodDemo.Run();
        
        // ActionDelegateDemo.Demo();
        
        // FuncDelegatesDemo.Run();

        // Events process = new Events();
        //
        // process.ProcessCompleted += ProcessCompletedHandler;
        //
        // process.Start();
        
        // TaskManager manager = new TaskManager();
        // manager.TaskCompleted += Manager_TaskCompleted;
        //
        // manager.RunTask();

        
        // Downloader downloader = new Downloader();
        // downloader.DownloadCompleted += Downloader_DownloadCompleted;
        //
        // downloader.Download("exmaple.txt");

        // Counter.Run();

        // Assembly executingAssembly = Assembly.GetExecutingAssembly();
        //
        // Type[] types = executingAssembly.GetTypes();
        // foreach (var type in types)
        // {
        //     Console.WriteLine("Class: {0}, Namespace: {1}, IsAbstract: {2}, IsPublic: {3}", type.Name, type.Namespace, type.IsAbstract, type.IsPublic);
        //     
        //     MethodInfo[] methods = type.GetMethods();
        //     foreach (var method in methods)
        //     {
        //         Console.WriteLine("Method: {0}, ReturnType: {1}, IsPrivate: {2}, IsStatic: {3}", method.Name, method.ReturnType, method.IsPrivate, method.IsStatic);
        //         
        //         ParameterInfo[] parameters = method.GetParameters();
        //
        //         foreach (var parameter in parameters)
        //         {
        //             Console.WriteLine("-------------->Parameter: {0}, Type:  {1}", parameter.Name,  parameter.ParameterType);
        //         }
        //     }
        // }
        //
        // Type t = typeof(Object);
        // Console.WriteLine(t.Name);
        // Console.WriteLine(t.Namespace);
        // Console.WriteLine(t.FullName);
        // Console.WriteLine(t.AssemblyQualifiedName);
        
        var employees = new List<Models.Employee>
        {
            new() { Id = 1, Name = "Naman", Department = "IT", Role = "Developer", Salary = 60000, Age = 24, JoinDate = new DateTime(2022,1,10), IsActive = true },
            new() { Id = 2, Name = "Aman", Department = "HR", Role = "Recruiter", Salary = 40000, Age = 29, JoinDate = new DateTime(2021,5,12), IsActive = true },
            new() { Id = 3, Name = "Riya", Department = "Finance", Role = "Analyst", Salary = 55000, Age = 31, JoinDate = new DateTime(2020,3,18), IsActive = false },
            new() { Id = 4, Name = "Sonal", Department = "IT", Role = "Tester", Salary = 45000, Age = 26, JoinDate = new DateTime(2023,2,1), IsActive = true },
            new() { Id = 5, Name = "Rahul", Department = "IT", Role = "Developer", Salary = 80000, Age = 35, JoinDate = new DateTime(2019,7,20), IsActive = true },
            new() { Id = 6, Name = "Kiran", Department = "HR", Role = "Manager", Salary = 70000, Age = 40, JoinDate = new DateTime(2018,11,5), IsActive = true },
            new() { Id = 7, Name = "Neha", Department = "Finance", Role = "Manager", Salary = 90000, Age = 38, JoinDate = new DateTime(2017,9,15), IsActive = true },
            new() { Id = 8, Name = "Arjun", Department = "Sales", Role = "Executive", Salary = 30000, Age = 23, JoinDate = new DateTime(2024,1,5), IsActive = true }
        };
        
        var projects = new List<Project>
        {
            new() { ProjectId = 1, ProjectName = "ERP", Department = "IT", Budget = 500000 },
            new() { ProjectId = 2, ProjectName = "Recruitment Portal", Department = "HR", Budget = 200000 },
            new() { ProjectId = 3, ProjectName = "Audit System", Department = "Finance", Budget = 300000 },
            new() { ProjectId = 4, ProjectName = "CRM", Department = "Sales", Budget = 250000 }
        };

        var orders = new List<Order>
        {
            new() { OrderId = 1, EmployeeId = 1, Product = "Laptop", Quantity = 1, Price = 70000, OrderDate = DateTime.Now.AddDays(-10) },
            new() { OrderId = 2, EmployeeId = 5, Product = "Monitor", Quantity = 2, Price = 15000, OrderDate = DateTime.Now.AddDays(-20) },
            new() { OrderId = 3, EmployeeId = 8, Product = "Phone", Quantity = 1, Price = 30000, OrderDate = DateTime.Now.AddDays(-5) },
            new() { OrderId = 4, EmployeeId = 3, Product = "Tablet", Quantity = 1, Price = 25000, OrderDate = DateTime.Now.AddDays(-40) }
        };
        
        // Get all employees.
        Console.WriteLine(string.Join(Environment.NewLine, employees.Select(e => e)));
        
        // Get names of all employees. 
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Select(e => e.Name)));
        
        // Get all active employees.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.IsActive == true).Select(e => e.Name)));
        
        // Employees older than 30.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.Age > 30).Select(e => e.Name)));

        // Employees from IT department.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.Department == "IT").Select(e => e.Name)));
        
        // Get salaries only
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Select(e => e.Salary)));
        
        // Count total employees.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Count()));
        
        // Check if any employee is inactive.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.IsActive == false).Select(e => e.Name)));
        
        // Find employee with Id = 5.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.Id == 5).Select(e => e.Name)));
        
        // First employee in list.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.First().Name));
        
        // Last employee in list.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Last().Name));
        
        // Employees who joined after 2021.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.JoinDate.Year > 2021).Select(e => e.Name)));
        
        // Employees younger than 25.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.Age < 25).Select(e => e.Name)));
        
        // Employees whose name starts with “N”.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Select(e => e.Name).Where(name => name.StartsWith('N'))));
        
        // Sort employees by age.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.OrderBy(e => e.Age)));
        
        // Sort employees by salary descending.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.OrderByDescending(e => e.Salary)));
        
        // Get top 3 highest paid employees.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.OrderByDescending(e => e.Salary).Take(3)));
        
        // Skip first 2 employees.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Skip(2)));
        
        // Check if all employees are active.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.All(e => e.IsActive)));
        
        // Get distinct departments.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Select(e => e.Department).Distinct()));
        
        // Get total salary paid.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Sum(e => e.Salary)));
        
        // Average salary.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Average(e => e.Salary)));
        
        // Minimum salary.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Min(e => e.Salary)));
        
        // Maximum salary.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Max(e => e.Salary)));
        
        // Count employees per department.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.GroupBy(e => e.Department).Select(e => $"{e.Key} => {e.Count()}")));
        
        // Employees with salary between 40k–70k
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.Salary is > 40000 and < 70000)));
        
        // Select anonymous object (Name + Salary).
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Select(e => new {e.Name, e.Salary})));
        
        // Convert employees to dictionary by Id.
        Console.WriteLine();
        var employeeDictionary = employees.ToDictionary(e => e.Id );
        Console.WriteLine(string.Join(Environment.NewLine, employeeDictionary.Select(e => e)));
        
        // Group employees by Department.
        Console.WriteLine();
        var employeeGroupByDepartment = employees.GroupBy(e => e.Department);
        
        // Average salary per department.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employeeGroupByDepartment.Select(e => e.Average(emp => emp.Salary))));
        
        // Highest paid employee in each department.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.GroupBy(e => e.Department)
            .Select(group => new 
                {
                    group.Key, 
                    Employee = group.OrderByDescending(e => e.Salary).First()
                }
            )
        ));
        
        // Employees grouped by Role.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.GroupBy(e => e.Role)));
        
        // Count employees per Role.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.GroupBy(e => e.Role).Select(group => new {Role = group.Key, Number_Of_Employee = group.Count()})));
        
        // Sort departments by average salary.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.GroupBy(e => e.Department).OrderBy(group => group.Average(e => e.Salary))));
        
        // Employees who joined in last 2 years.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.Where(e => e.JoinDate > DateTime.Now.AddYears(-2))));
        
        // Find second highest salary.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.OrderByDescending(e => e.Salary).Take(2).Skip(1)));
        
        // Get employees ordered by JoinDate.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, employees.OrderBy(e => e.JoinDate)));
        
        // Total project budget.
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, projects.Sum(p => p.Budget)));
        
        // Projects per department.
        Console.WriteLine();
        var projectsPerDepartment = projects.GroupBy(p => p.Department).Select(group => new {Department = group.Key, Number_Of_Projects = group.Count()});
        Console.WriteLine(string.Join(Environment.NewLine, projectsPerDepartment));
        
        // Projects per department.
    }
    // static void Downloader_DownloadCompleted(object sender, DownloadEventArgs e)
    // {
    //     Console.WriteLine($"Download Finished: {e.FileName}");
    // }

    // static void Manager_TaskCompleted(Object sender, EventArgs e)
    // {
    //     Console.WriteLine("Task Completed Even Fired!");
    // }

    // static void ProcessCompletedHandler()
    // {
    //     Console.WriteLine("Process Completed!");
    // }
}