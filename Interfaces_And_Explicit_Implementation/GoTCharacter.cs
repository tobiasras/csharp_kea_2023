namespace Interfaces_And_Explicit_Implementation;

class GoTCharacter : IWesterosi, IHumanoid
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string House { get; set; }
    public string Location { get; set; }
    
    void IHumanoid.Talk()
    {
        Console.WriteLine($"{Name} from House {House} is talking...");
    }
}