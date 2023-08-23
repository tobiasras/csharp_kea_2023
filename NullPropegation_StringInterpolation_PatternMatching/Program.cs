// See https://aka.ms/new-console-template for more information

/*
Problem Statement:

You are given a list of customers with the following information: name, age, and email.
Your task is to write a program that iterates over each customer, and displays the following information:

Name: [Customer's Name]
Age: [Customer's Age]
Email: [Customer's Email Address in lowercase, or "email not available" if the email address is null]

A message indicating whether the customer is under 30, between 30 and 40, or 40 or older.

Requirements:
 Use null propagation to safely access the email address.
 Use string interpolation to format the output.
 Use pattern matching to check the customer's age.

Example
 Name: John Doe, Age: 30, Email: john.doe@example.com The customer is between 30 and 40
 Name: Jane Doe, Age: 25, Email: jane.doe@example.com The customer is under 30.
 Name: Jim Smith, Age: 35, Email: email not available The customer is between 30 and 40.
 */

namespace Sub_01_Null_Propagation_String_Interpolation_Pattern_Matching;

class Program
{
    private static void Main(string[] args)
    {
        List<Customer> listOfCustomers = new List<Customer>
        {
            new() { Name = "Tobias Rasmussen", Age = 25 },
            new() { Name = "Johan Juul Rasmussen", Email = "Johan@mail.com", Age = 45 },
            new() { Name = "Kasper rasmussen", Age = 35, Email = "Kasper@rasmussen.dk" }
        };

        foreach (var customer in listOfCustomers)
        {
            Console.WriteLine(customer);
        }
    }
}