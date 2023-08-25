using System.Globalization;

namespace LINQ_Query_Syntax;

class Employee
{
    public string Name { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public decimal Salary { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Department} - {Salary.ToString(CultureInfo.CurrentCulture)}";
    }
}