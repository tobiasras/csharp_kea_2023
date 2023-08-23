namespace Implementing_Classes;

class NaturalDuck : Duck
{
    public bool CanFly { get; set; }
    public bool HasOrangeBeak { get; set; }

    public override string ToString()
    {
        return
            $"{Name} can fly?, {CanFly} & has a orangeBeak? {HasOrangeBeak}. the gender of the duck is : {Gender} + is domestic: {IsDomestic}";
    }
}