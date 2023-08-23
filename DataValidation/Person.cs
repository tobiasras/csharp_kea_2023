using System.ComponentModel.DataAnnotations;

namespace DataValidation;

public class Person
{
    
    public Person(string name, int age, string email)
    {
        Name = name;
        Age = age;
        Email = email;
    }
    
    [Required]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "Field must be between 1 - 100 chars")]
    public string Name { get; set; }
    
    [Range(0, 120, ErrorMessage = "Age not between 0 - 120")]
    public int Age { get; set; }
    
    [EmailAddress(ErrorMessage = "Not a valid email address")]
    public string? Email { get; set; }

    
    public bool Validate()
    {
        var validationContext = new ValidationContext(this);
        var validationResults = new List<ValidationResult>();

        bool result = Validator.TryValidateObject(this, validationContext, validationResults, true);
        Func<string> errorMessage = () => string.Join("",
            validationResults.Select(validationResult => Environment.NewLine + validationResult.ErrorMessage));
        
        return result ? result : throw new ArgumentException($"Error message: {errorMessage()}");
    }
    
}