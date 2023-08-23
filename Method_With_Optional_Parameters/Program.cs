namespace Method_With_Optional_Parameters;
/*
Create a C# method called SendMessage that takes the following parameters:
    string message: the message to be sent
    string recipient: the recipient of the message
    bool isUrgent: a flag indicating whether the message is urgent or not (optional, default value is false)
    DateTime? scheduledTime: the scheduled time for the message to be sent (optional, default value is null)

The SendMessage method should perform the following operations:
    If isUrgent is true, the method should add "URGENT: " to the beginning of the message parameter
    If scheduledTime is not null, the method should schedule the message to be sent at the specified scheduledTime. 
    If scheduledTime is null, the message should be sent immediately.
    The method should print a message to the console indicating the details of the message that was sent or scheduled. 
 */

class Program
{
    public static void Main(string[] args)
    {
        SendMessage("Hello, how are you?", "John");
        SendMessage("Meeting postponed", "All employees", true);
        SendMessage("Reminder: project due in 2 days", "Project team", scheduledTime: DateTime.Now.AddDays(2));
    }
    
    public static void SendMessage(string message, string recipient, bool isUrgent = false, DateTime? scheduledTime = null)
    {
        string log = String.Empty;
        string urgentPrefix = isUrgent ? "URGENT: " : string.Empty;
        string finalMessage = $"{urgentPrefix}{message}";
        log += $"Recipient: {recipient}\n";
        log += $"Message: {finalMessage}\n";
        
        if (scheduledTime.HasValue)
        {
            log += $"Scheduled at: {scheduledTime.ToString()}";
        }
        else
        {
            log += $"Send immediately";
        }

        Console.WriteLine(log + "\n");
    }
}