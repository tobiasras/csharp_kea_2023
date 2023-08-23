// See https://aka.ms/new-console-template for more information
/*
Requirements

Implement a Person class with the following properties:
    Name (string): The name of the person.
    Age (int): The age of the person.
    Gender (char): The gender of the person.
    
Implement an Employee class with the following properties:
    Id (int): The unique identifier of the employee.
    Person (Person): The person class of the employee.
    Department (string): The department that the employee belongs to.
    
Implement a Department struct with the following properties:
    Name (string): The name of the department.
    Head (Employee): The head of the department.
    
Implement a Company class with the following properties:
    Name (string): The name of the company.
    Employees (List of Employee): The list of employees in the company.
    Departments (List of Department): The list of departments in the company.
 

Implement an object initializer for the Person and Employee classes, 
allowing for easy creation of objects with initial property values.

Implement a method in the Company class that allows for adding a new employee to the company, 
as well as assigning them to a department and manager (if applicable).

Implement a method in the Company class that allows for removing an employee from the company.
*/

using System.Threading.Channels;

namespace Simple_Employee_Management_System;

class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person(age: 30, name: "person1", gender: 'F');
        Person person2 = new Person(age: 40, name: "person2", gender: 'M');
        Person person3 = new Person(age: 123, name: "person3", gender: 'F');
        Person person4 = new Person(age: 25, name: "person4", gender: 'F');

        // Create employees
        Employee employee1 = new Employee { Id = 1, Person = person1 };
        Employee employee2 = new Employee { Id = 2, Person = person2 };;

        // Create departments
        Company company = new Company()
        {
            ListOfDepartments = new List<Department>()
            {
                new () { Name = "IT", Head = employee2 },
                new () { Name = "HR", Head = employee1 }
            }
        };

        Console.WriteLine($"adding new employee {company.AddNewEmployee(person3, company.ListOfDepartments[0])}");
        Console.WriteLine($"adding new employee {company.AddNewEmployee(person4, company.ListOfDepartments[1])}");
    }
    
    
}