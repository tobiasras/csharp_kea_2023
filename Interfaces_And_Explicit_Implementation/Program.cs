
namespace Interfaces_And_Explicit_Implementation;

class Program
{
    public static void Main(string[] args)
    {
        
        GoTCharacter jonSnow = new GoTCharacter
        {
            Name = "Jon Snow",
            Age = 30,
            House = "Stark",
            Location = "Winterfell"
        };
        
        ((IHumanoid)jonSnow).Talk();
    }
    
    
}