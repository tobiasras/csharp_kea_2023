namespace Interfaces_And_Explicit_Implementation;

interface IHumanoid
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Talk();
}