namespace Implementing_Classes;

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