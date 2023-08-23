// See https://aka.ms/new-console-template for more information

/*
Create a C# class called Person that has the following properties:
    string Name: the name of the person (required, length between 1 and 100 characters)
    int Age: the age of the person (required, value between 0 and 120)
    string Email: the email address of the person (optional, valid email format)
 

The Person class should have a constructor that takes parameters for
Name, Age, and Email and assigns them to the corresponding properties.

The Person class should also have a method called Validate that performs the following data validation checks:
    The Name property must not be null or empty, and its length must be between 1 and 100 characters.
    The Age property must be greater than or equal to 0 and less than or equal to 120.
    The Email property must be null or a valid email address format.
 

If any of these validation checks fail, the Validate method should list which validations that failed,
but also throw an ArgumentException

Once you have implemented the Person class, you can test it by creating an instance of the Person class 
with valid and invalid data, and calling the Validate method to observe the behavior of the data validation.
*/

using System.ComponentModel.DataAnnotations;

namespace DataValidation;
class Program
{
    public static void Main(string[] args)
    {
        Person personCorrect = new Person("Tobias", 25, "tobiasras.job@gmail.com");
        //Person personWrongName = new Person(String.Empty, 25, "tobiasras.job@gmail.com");
        //Person personWrongAge = new Person("Tobias", 150, "tobiasras.jobgmail.com");
        Person personWrongMail = new Person("Tobias", -25, "tobicom");

        Console.WriteLine($"PersonWrongEmail: {personCorrect.Validate()}");
        Console.WriteLine($"PersonWrongEmail: {personWrongMail.Validate()}");
    }
}