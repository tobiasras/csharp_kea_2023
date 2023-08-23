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
        var duck2 = duckFactory.CreateDuck(stringDuck2);
        var duck3 = duckFactory.CreateDuck(stringDuck3);
        var duck4 = duckFactory.CreateDuck(stringDuck4);
        
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