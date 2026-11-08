using Models;

namespace Pipeline.Steps;

public class NotificationStep : IPipelineStep
{
    public async Task ExecuteAsync(Order order)
    {
        Console.WriteLine("Uyari ekledik");
    }
}