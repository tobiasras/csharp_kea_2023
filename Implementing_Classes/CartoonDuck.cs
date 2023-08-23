namespace Implementing_Classes;

class CartoonDuck : Duck
{
    public bool IsMainCharactor { get; set; }
    public string OutfitColor { get; set; }

    public override string ToString()
    {
        return $"{Name} is the mainChar? : {IsMainCharactor} has the outfit color: {OutfitColor}";
    }
}