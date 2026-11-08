using Models;

namespace Pipeline
{
    public interface IPipelineStep
    {
        Task ExecuteAsync(Order order);
    }
}


