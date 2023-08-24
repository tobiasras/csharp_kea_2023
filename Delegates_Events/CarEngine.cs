namespace Delegates_Events;

class CarEngine
{
    public void StartEngine()
    {
        IsRunning = true;
        EngineStarted.Invoke();
    }

    public void StopEngine()
    {
        IsRunning = false;
        EngineStopped.Invoke();
    }
    public void SetEngineSpeed(int speed)
    {
        CurrentEngineSpeed = speed;
        EngineSpeedChanged.Invoke(speed);
    }

    private bool IsRunning { get; set; } = false;
    private int CurrentEngineSpeed { get; set; } = 0;

    public delegate void EngineStartHandler();
    public delegate void EngineStopHandler();
    public delegate void EngineSpeedChangeHandler(int speed);

    public event EngineStartHandler EngineStarted;
    public event EngineStopHandler EngineStopped;
    public event EngineSpeedChangeHandler EngineSpeedChanged = (int speed) => { };
}