namespace Sub_01_Null_Propagation_String_Interpolation_Pattern_Matching;

public class Customer
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public string? Email { get; set; }

    private string AgeMessage()
    {
        // PATTERN MATCHING
        return Age switch
        {
            > 40 => "The customer is over 40",
            < 30 => "The customer is over 30",
            _ => "The customer is between 30 and 40"
        };
    }
    
    public override string ToString()
    {
        // STRING INTERPOLATION                 NULL PROPAGATION
        return $"Name: { Name }, Age: { Age }, { Email ?? "email not available" }, { AgeMessage() }";
    }
}