namespace Generic_Fellowship;

public class Character
{
    public Character(string race, string name, int level)
    {
        Race = race;
        Name = name;
        Level = level;
    }
    
    public string Race { get; set; }
    public string Name { get; set; }
    public int Level { get; set; }

    public bool Attack(Character character)
    {
        Console.WriteLine($"{Name}, the {Race}: Attacked {character.Name} the {character.Race}");

        if (Level > character.Level)
        {
            Console.WriteLine($"{Name} killed the {character.Name}, a {character.Race}");
            return true;
        }
        else
        {
            Console.WriteLine($"{Name}, got killed and left the fellowship \n");
            return false;
        }
    }
}
