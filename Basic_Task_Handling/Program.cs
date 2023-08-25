using System.Diagnostics;

namespace Basic_Task_Handling;

/*
It is easy to create Tasks with the Task.Run() method.
In this assignment, you must simple make use of it, and have a look at the class


Create a new class in which to experiment with Tasks
Create an array of string containing name of famous football teams in Denmark
Create an instance of System.Diagnostics.StopWatch and call Start() on it


For each football team:
Create a task that wait a random amount of seconds, before announcing a goal by the specified team.
You can use this example

Random r = new Random();
int seconds = r.Next(0, 90);
Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
Console.WriteLine($" {team} scored a goal after {seconds} game minutes");


Wait for all tasks to complete with Task.WaitAll(…)
Call Stop() on the stopwatch and print out the ElapsedMilliseconds propert
*/

class Program
{
    public static void Main(string[] args)
    {
        Experiments experiments = new();
        experiments.Start();
    }
}

class Experiments
{
    private Stopwatch _stopwatch = new();
    
    public void Start()
    {
        _stopwatch.Start();
        List<Task> allTask = new();
        foreach (var team in DanishFootballTeams)
        {
            var task = Task.Run(() =>
            {
                Random r = new Random();
                int seconds = r.Next(0, 90);
                Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
                Console.WriteLine($" {team} scored a goal after {seconds} game minutes");
            });
            allTask.Add(task);
        }

        Console.WriteLine("___RESULTS___");

        foreach (var task in allTask)
            task.Wait();

        _stopwatch.Stop();
        Console.WriteLine(_stopwatch.Elapsed.Milliseconds);
    }
    
    
    public string[] DanishFootballTeams { get; set; } = 
    {
        "FC Copenhagen",
        "Brøndby IF",
        "Aarhus GF",
        "Odense Boldklub",
        "FC Midtjylland",
        "FC Nordsjælland",
        "Esbjerg fB",
        "Vejle Boldklub"
    };
}