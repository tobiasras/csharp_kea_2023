// See https://aka.ms/new-console-template for more information

namespace Deconstructs_Object_Into_Tuble;

/*

Create a C# class called Person that has the following properties:
    string Name: the name of the person
    int Age: the age of the person
    string Occupation: the occupation of the person
    decimal Salary: the salary of the person

Create a method in the Person class called GetPersonInfo that returns a tuple of the following elements:
    string name: the name of the person
    int age: the age of the person
    string occupation: the occupation of the person
    decimal salary: the salary of the person
 

The GetPersonInfo method should perform the following operations:
    Deconstruct the Person object into four separate variables: name, age, occupation, and salary.
    Return a tuple of the deconstructed values.
 

Once you have implemented the Person class and the GetPersonInfo method, 
you can test it by creating an instance of the Person class and deconstructing it into a tuple.
*/

public class Program
{
    public static void Main(string[] args)
    {
        var person = new Person
        {
            Name = "John",
            Age = 30,
            Occupation = "Software Engineer",
            Salary = 75000.00m
        };

        var (name, age, occupation, _) = person.GetPersonInfo();
        Console.WriteLine($"{name}, {age}, {occupation}");
        
        var tuple = person.GetPersonInfoWithNames();
        Console.WriteLine($"{tuple.name}, {tuple.age}, {tuple.occupation}");
    }
    
}