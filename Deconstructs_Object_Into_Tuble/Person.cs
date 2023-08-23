namespace Deconstructs_Object_Into_Tuble;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Occupation { get; set; }
    public decimal Salary { get; set; }
    

    public (string, int, string, decimal) GetPersonInfo()
    {
        return (Name, Age, Occupation, Salary);
    }
    
    
    public (string name, int age, string occupation, decimal salary) GetPersonInfoWithNames()
    {
        return (Name, Age, Occupation, Salary);
    }
}