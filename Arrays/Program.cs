// See https://aka.ms/new-console-template for more information

/*
In this assignment, you will use C# ranges and arrays to analyze the length of episodes from the Simpsons universe.
You will write a C# program that contains a hardcoded list of episodes,
and then calculates the average length of each season.

The data for this assignment should be hardcoded as an array of tuples, where each tuple represents an episode
and contains the following elements:
    Season number (int)
    Episode number (int)
    Title (string)
    Length (int, in minutes)
    
Your program should perform the following tasks:
    Parse the data to extract the length of each episode, and group the episodes by season
    Calculate the average length of each season
    Display the top three longest seasons of Simpsons

*/


namespace Arrays;

class Program
{
    public static void Main(string[] args)
    {
        var season = new (int season, int episode, string title, int length)[]
        {
            (1, 1, "Simpsons Roasting on an Open Fire", 22),
            (1, 2, "Bart the Genius", 22),
            (1, 3, "Homer's Odyssey", 22),
            (1, 4, "There's No Disgrace Like Home", 23),
            (1, 5, "Bart the General", 22),
            (1, 6, "Moaning Lisa", 22),
            (1, 7, "The Call of the Simpsons", 22),
            (1, 8, "The Telltale Head", 22),
            (1, 9, "Life on the Fast Lane", 22),
            (1, 10, "Homer's Night Out", 22),
        };
        
        var sum = AvgEpisodeLength(season);
        Console.WriteLine(sum);
    }

    private static int AvgEpisodeLength((int season, int episode, string title, int length)[] season)
    {
       return season.Sum(episode => episode.length) / season.Length;
    }
}