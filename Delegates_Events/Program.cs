// See https://aka.ms/new-console-template for more information

namespace Delegates_Events;

class Program
    {
        static void Main(string[] args)
        {
            CarEngine carEngine = new CarEngine();
            
            carEngine.EngineStarted += () => Console.WriteLine("The engine has started!");
            carEngine.EngineStopped += () => Console.WriteLine("The engine has stopped!");
            carEngine.EngineSpeedChanged += OnSpeedChangeOne;

            carEngine.StartEngine();
            carEngine.SetEngineSpeed(519);
            carEngine.StopEngine();
        }

        static void OnSpeedChangeOne(int speed)
        {
            Console.WriteLine($"OnSpeedChangeOne: Engine speed is now {speed}");
        }
        
    }