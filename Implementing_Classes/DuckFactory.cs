namespace Implementing_Classes;

class DuckFactory
{
    public Duck CreateDuck(string duckType)
    {
        return duckType.ToLower() switch
        {
            "mallard" => new NaturalDuck()
            {
                Name = "Mallard",
                Gender = "Male",
                CanFly = true,
                HasOrangeBeak = true,
                IsDomestic = true
            },
            "pekin" => new NaturalDuck()
            {
                Name = "Pekin",
                Gender = "Female",
                CanFly = false,
                HasOrangeBeak = false,
                IsDomestic = false
            },
            "donaldduck" => new CartoonDuck()
            {
                IsMainCharactor = true,
                IsDomestic = true,
                Name = "Donald duck",
                Gender = "Male",
                OutfitColor = "blue"
            },
            "daisyduck" => new CartoonDuck()
            {
                IsMainCharactor = false,
                IsDomestic = true,
                Name = "Daisy Duck",
                Gender = "Female",
                OutfitColor = "Pink"
            },
            _ => throw new ArgumentException("Invalid duck name")
        };
    }
}