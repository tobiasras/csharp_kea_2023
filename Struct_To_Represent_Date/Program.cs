// See https://aka.ms/new-console-template for more information

/*

Problem Statement:
 Create a C# struct called Date that represents a date with a year, month, and day component.
 The struct should have the following properties and methods:

Properties:
 Year: an integer representing the year of the date
 Month: an integer representing the month of the date (1-12)
 Day: an integer representing the day of the date (1-31)

Methods:
 IsValid(): returns true if the date is a valid date, and false otherwise
 ToString(): returns a string representation of the date in the format "yyyy-mm-dd"
*/

namespace StructToRepresentDate;

class Program
{
    public static void Main(string[] args)
    {
        Date date1 = new Date(2023, 2, 17);
        Date date2 = new Date(2023, 2, 29);
        Date date3 = new Date(2023, 13, 1);

        
        Console.WriteLine("IS VALID 1 METHOD");
        // SHOULD BE VALID
        Console.WriteLine("Date 1 is valid? " + date1.IsValidWithTryParse());
        // SHOULD NOT BE VALID
        Console.WriteLine("Date 2 is valid? " + date2.IsValidWithTryParse());
        // SHOULD BE VALID
        Console.WriteLine("Date 3 is valid? " + date3.IsValidWithTryParse());
        
        Console.WriteLine("IS VALID 2 METHOD");
        // SHOULD BE VALID
        Console.WriteLine("Date 1 is valid? " + date1.IsValidWithTryCatch());
        // SHOULD NOT BE VALID
        Console.WriteLine("Date 2 is valid? " + date2.IsValidWithTryCatch());
        // SHOULD BE VALID
        Console.WriteLine("Date 3 is valid? " + date3.IsValidWithTryCatch());
        
        Console.WriteLine("Date 1: " + date1.ToString());
        Console.WriteLine("Date 2: " + date2.ToString());
        Console.WriteLine("Date 3: " + date3.ToString());
    }
}