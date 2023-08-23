using System.Globalization;

namespace StructToRepresentDate;

public struct Date 
{
    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    
    public bool IsValidWithTryParse()
    {
        var result = DateTime.TryParse(ToString(), out _);
        return result;
    }
    
    
    public bool IsValidWithTryCatch()
    {
        try
        {
            // THROWS IF NOT A VALID DATE
            new DateTime(Year, Month, Day);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public override string ToString()
    {            // FORMATING
        return $"{Year:0000}-{Month:00}-{Day:00}";
    }
}