// See https://aka.ms/new-console-template for more information

namespace Implementing_Classes;

class Program
{
    public static void Main(string[] args)
    {
        DuckFactory duckFactory = new DuckFactory();

        string stringDuck1 = "Mallard";
        string stringDuck2 = "Pekin";
        string stringDuck3 = "DonaldDuck";
        string stringDuck4 = "DaisyDuck";

        var duck1 = duckFactory.CreateDuck(stringDuck1);
        var duck2 = duckFactory.CreateDuck(stringDuck1);
        var duck3 = duckFactory.CreateDuck(stringDuck1);
        var duck4 = duckFactory.CreateDuck(stringDuck1);
        
        PrintDuck(duck1);
        PrintDuck(duck2);
        PrintDuck(duck3);
        PrintDuck(duck4);
    }


    public static void PrintDuck(Duck duck)
    {
        switch (duck)
        {
            case NaturalDuck naturalDuck:
                Console.WriteLine(naturalDuck);
                break;
            case CartoonDuck cartoonDuck:
                Console.WriteLine(cartoonDuck);
                break;
            default:
                throw new ArgumentException("Invalid duck type");

        }
    }
}

class DuckFactory
{
    public Duck CreateDuck(string duckType)
    {
        switch (duckType)
        {
            case "Mallard":
                return new NaturalDuck()
                {
                    Name = "Mallard",
                    Gender = "Male",
                    CanFly = true,
                    HasOrangeBeak = true,
                    IsDomestic = true
                };

            case "Pekin":
                return new NaturalDuck()
                {
                    Name = "Pekin",
                    Gender = "Female",
                    CanFly = false,
                    HasOrangeBeak = false,
                    IsDomestic = false
                };

            case "DonaldDuck":
                return new CartoonDuck()
                {
                    IsMainCharactor = true,
                    IsDomestic = true,
                    Name = "Donald duck",
                    Gender = "Male",
                    OutfitColor = "blue"
                };

            case "DaisyDuck":
                return new CartoonDuck()
                {
                    IsMainCharactor = false,
                    IsDomestic = true,
                    Name = "Daisy Duck",
                    Gender = "Female",
                    OutfitColor = "Pink"
                };

            default:
                throw new ArgumentException("Invalid duck name");
        }
    }
}

abstract class Duck
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public bool IsDomestic { get; set; }
}

class NaturalDuck : Duck
{
    public bool CanFly { get; set; }
    public bool HasOrangeBeak { get; set; }

    public override string ToString()
    {
        return
            $"{Name} can fly?, {CanFly} & has a orangeBeak? {HasOrangeBeak}. the gender of the duck is : ${Gender} + is domestic: {IsDomestic}";
    }
}

class CartoonDuck : Duck
{
    public bool IsMainCharactor { get; set; }
    public string OutfitColor { get; set; }

    public override string ToString()
    {
        return $"{Name} is the mainChar? : {IsMainCharactor} has the outfit color: {OutfitColor}";
    }
}