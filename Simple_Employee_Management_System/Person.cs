namespace Simple_Employee_Management_System;

public class Person
{
    public Person(int age, string name, char gender)
    {
        Age = age;
        Name = name;
        Gender = gender;
    }

    public int Age { get; set; }
    public string Name { get; set; }
    public char Gender { get; set; }
}
