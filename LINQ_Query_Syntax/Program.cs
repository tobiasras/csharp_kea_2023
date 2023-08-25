// See https://aka.ms/new-console-template for more information

namespace LINQ_Query_Syntax;

class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "John Doe", Department = "IT", Salary = 60000.00M },
            new Employee { Name = "Jane Smith", Department = "Finance", Salary = 65000.00M },
            new Employee { Name = "Robert Brown", Department = "IT", Salary = 63000.00M },
            new Employee { Name = "Emily Clark", Department = "HR", Salary = 55000.00M },
            new Employee { Name = "Michael White", Department = "IT", Salary = 62000.00M },
            new Employee { Name = "Sarah Green", Department = "Finance", Salary = 64000.00M },
            new Employee { Name = "Chris Blue", Department = "Marketing", Salary = 58000.00M },
            new Employee { Name = "Rebecca Black", Department = "HR", Salary = 57000.00M },
            new Employee { Name = "Alan Gray", Department = "Sales", Salary = 66000.00M },
            new Employee { Name = "Sophia Yellow", Department = "Sales", Salary = 67000.00M },
            new Employee { Name = "Lucas Red", Department = "Marketing", Salary = 59000.00M },
            new Employee { Name = "Olivia Purple", Department = "HR", Salary = 56000.00M },
            new Employee { Name = "William Pink", Department = "IT", Salary = 64000.00M },
            new Employee { Name = "Emma Cyan", Department = "Finance", Salary = 65000.00M },
            new Employee { Name = "Jacob Indigo", Department = "Sales", Salary = 68000.00M },
            new Employee { Name = "Isabella Magenta", Department = "Marketing", Salary = 60000.00M },
            new Employee { Name = "Ethan Lime", Department = "IT", Salary = 61500.00M },
            new Employee { Name = "Mia Violet", Department = "Sales", Salary = 65500.00M },
            new Employee { Name = "Daniel Teal", Department = "HR", Salary = 56500.00M },
            new Employee { Name = "Ella Tangerine", Department = "Finance", Salary = 64500.00M }
        };

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
        

        foreach (var employee in AscByNameSameSalary(employees))
        {
            Console.WriteLine(employee);
        }
        */

        foreach (var findAllNamesInSale in FindAllNamesInSales(employees))
        {
            Console.WriteLine(findAllNamesInSale);
        }
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
        IEnumerable<Employee> allSales = list;

        return allSales
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