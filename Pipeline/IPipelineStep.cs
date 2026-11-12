using Models;
using OrderProcessing.Helpers;

namespace Pipeline
{
    public interface IPipelineStep
    {
        Task<OrderResult> ExecuteAsync(Order order);
        bool ContinueOnFailure { get; }
    }
}


