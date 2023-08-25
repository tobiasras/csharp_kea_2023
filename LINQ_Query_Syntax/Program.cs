// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace LINQ_Query_Syntax;

class Program
{
    public static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new() { Name = "John Doe", Department = "IT", Salary = 60000.00M },
            new() { Name = "Jane Smith", Department = "Finance", Salary = 65000.00M },
            new() { Name = "Robert Brown", Department = "IT", Salary = 63000.00M },
            new() { Name = "Emily Clark", Department = "HR", Salary = 55000.00M },
            new() { Name = "Michael White", Department = "IT", Salary = 62000.00M },
            new() { Name = "Sarah Green", Department = "Finance", Salary = 64000.00M },
            new() { Name = "Chris Blue", Department = "Marketing", Salary = 58000.00M },
            new() { Name = "Rebecca Black", Department = "HR", Salary = 57000.00M },
            new() { Name = "Alan Gray", Department = "Sales", Salary = 66000.00M },
            new() { Name = "Sophia Yellow", Department = "Sales", Salary = 67000.00M },
            new() { Name = "Lucas Red", Department = "Marketing", Salary = 59000.00M },
            new() { Name = "Olivia Purple", Department = "HR", Salary = 56000.00M },
            new() { Name = "William Pink", Department = "IT", Salary = 64000.00M },
            new() { Name = "Emma Cyan", Department = "Finance", Salary = 65000.00M },
            new() { Name = "Jacob Indigo", Department = "Sales", Salary = 68000.00M },
            new() { Name = "Isabella Magenta", Department = "Marketing", Salary = 60000.00M },
            new() { Name = "Ethan Lime", Department = "IT", Salary = 61500.00M },
            new() { Name = "Mia Violet", Department = "Sales", Salary = 65500.00M },
            new() { Name = "Daniel Teal", Department = "HR", Salary = 56500.00M },
            new() { Name = "Ella Tangerine", Department = "Finance", Salary = 64500.00M }
        };

        var onlySales = employees
            .Where(employee => employee.Department == "Sales");
        foreach (var i in onlySales)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("order by");

        var orderBy = employees
            .OrderBy(employee => employee.Salary);
        foreach (var i in orderBy)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("then by");

        var thenBy = employees
            .OrderBy(employee => employee.Salary)
            .ThenBy(employee => employee.Name);
        
        foreach (var i in thenBy)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Max salary");
        
        var max = employees
            .Max(employee => employee.Salary);
        Console.WriteLine(max);

        /*

        Console.WriteLine("-- All in sales --");
        foreach (var allInSale in AllInSales(employees))
        {
            Console.WriteLine(allInSale);
        }


        Console.WriteLine("-- AcsendingSalary --");
        foreach (var employee in AcsendingSalary(employees))
        {
            Console.WriteLine(employee);
        }

        Console.WriteLine("-- AcsendingNameBySalary --");
        foreach (var employee in AscByNameSameSalary(employees))
        {
            Console.WriteLine(employee);
        }

        Console.WriteLine("-- Find all names in sale --");
        foreach (var findAllNamesInSale in FindAllNamesInSales(employees))
        {
            Console.WriteLine(findAllNamesInSale);
        }
        */
    }

    public static List<Employee> AllInSales(List<Employee> list)
    {
        IEnumerable<Employee> allSales =
            from employee in list
            where employee.Department == "Sales"
            select employee;

        return new List<Employee>(allSales);
    }

    public static List<Employee> AcsendingSalary(List<Employee> list)
    {
        return list
            .OrderByDescending(i => i.Salary)
            .Reverse()
            .ToList();
    }

    public static List<Employee> AscByNameSameSalary(List<Employee> list)
    {
        // IS CHAT GPT GOOD FOR LINQ ??
        // YUP
        var sortedEmployees = from e in list
            group e by e.Salary
            into g
            from eInGroup in g.OrderBy(e => e.Name)
            select eInGroup;
        return sortedEmployees.ToList();
    }

    public static List<string> FindAllNamesInSales(List<Employee> list)
    {
        var allNames =
            from employee in list
            where employee.Department == "Sales"
            select employee.Name;
        return allNames.ToList();
    }
}
/*
    Write a LINQ query to find all employees who work in the "Sales" department.
    Write a LINQ query to sort the emplyoees by salary in ascending order.
    Write a LINQ query to sort the employees by name in ascending order for employees with the same salary.
    Write a LINQ query to find all names of the employees in the “Sales” department.
*/