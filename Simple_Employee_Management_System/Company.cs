namespace Simple_Employee_Management_System;

public class Company
{
    Random _random = new();
    
    public string Name { get; set; }
    public List<Employee> ListOfEmployees { get; set; } = new();
    public List<Department> ListOfDepartments { get; set; } = new();
    
    public bool AddNewEmployee(Person person, Department department)
    {
        if (!ListOfDepartments.Contains(department))
        {
            return false;
        }

        int randomId = _random.Next(99999);
        Employee employee = new()
        {
            Id = randomId,
            Department = department,
            Person = person
        };
        
        ListOfEmployees.Add(employee);
        return true;
    }
    public bool RemoveEmployee(Employee employee)
    {
       return ListOfEmployees.Remove(employee);
    }
    
}